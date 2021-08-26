/*
 * Author: Ramtin Jokar [ mailto:ramtinak@live.com ]
 * 
 * This application requires Private Version Of InstagramApiSharp's library:
 *       https://github.com/ramtinak/InstagramApiSharp/issues/243
 * 
 * This is an example of broadcasting Instagram Live via InstagramApiSharp's library and OBStudio application.
 * 
 * Aug 27, 2021
 * 
 */



// You need to reference these packages:
// Microsoft.CSharp version 4.3.0 or newer
// Newtonsoft.Json version 10.0.3 or newer
// Iconic.Zlib.NetstandardUwp version 1.0.1 or newer
// Portable.BouncyCastle version 1.8.6.7 or newer
// System.Net.Http => for .NETFramework only

// If you are using .net core 3.1 or net5/6, no need to install Portable.BouncyCastle

// netstandard/netframework:    InstagramApiSharp.csproj
// netcore3.1/5:                InstagramApiSharp.NET5.csproj

using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using static LiveDemo.Helper;

namespace LiveDemo
{
    public partial class Form1 : Form
    {
        bool LiveStarted = false;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // Not a good way to handle this but lets set it to false
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            BuildApi();
            Task.Delay(50).Wait();
            UserText.Text = InstaApi.GetLoggedUser().UserName;
            PassText.Text = InstaApi.GetLoggedUser().Password;
            if (InstaApi.IsUserAuthenticated)
            {
                LoginButton.Enabled = false;

                await DefaultFlowAsync().ConfigureAwait(false);
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            BuildApi(UserText.Text, PassText.Text);

            await InstaApi.SendRequestsBeforeLoginAsync();

            await Task.Delay(5000);

            var loginResult = await InstaApi.LoginAsync();

            if (loginResult.Succeeded)
            {
                SaveSession();
                LoginButton.Enabled = false;
                Text = GetTitle();
                await DefaultFlowAsync().ConfigureAwait(false);
            }
            else
            {
                PrintError(loginResult.Info);

                // If you got challenged or 2FA, check the ChallengeRequireExample
            }
        }

        public async Task DefaultFlowAsync()
        {
            var tasks = new Task[]
            {
                InstaApi.SendRequestsAfterLoginAsync(),
                InstaApi.UserProcessor.GetCurrentUserAsync(),
                InstaApi.GetBanyanSuggestionsAsync(),
                InstaApi.StoryProcessor.GetStoryFeedWithPostMethodAsync(),
                InstaApi.FeedProcessor.GetUserTimelineFeedAsync(PaginationParameters.MaxPagesToLoad(1)),
                InstaApi.FeedProcessor.GetRecentActivityFeedAsync(PaginationParameters.MaxPagesToLoad(1)),
                InstaApi.MessagingProcessor.GetUsersPresenceAsync(),
                InstaApi.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(1))
            };
            await Task.WhenAll(tasks).ConfigureAwait(false);
        }

        InstaBroadcastCreate InstaBroadcastCreate = null;

        // Creating has multiple steps:
        //  Step 1: You need to check for creating live broadcast first, if you are allowed,
        //          the response contains a RTMP URL and broadcastId which you should store this respone (InstaBroadcastCreate class)
        //  Step 2: Now you should pass the RTMP URL to an application like OBStudio for streaming part
        //  Step 3: After that you should call StartAsync to start the streaming part
        private async void CreateLiveButton_Click(object sender, EventArgs e)
        {
            if (!InstaApi.IsUserAuthenticated)
                return;

            var result = await InstaApi.LiveProcessor.CreateAsync(1080, 1920, LiveTitleText.Text);

            if (result.Succeeded)
            {
                Text = GetTitle() + " - Live created";
                InstaBroadcastCreate = result.Value;
                RtmpText.Text = result.Value.UploadUrl;
                StartLiveButton.Enabled = StopLiveButton.Enabled = CommentGP.Enabled = true;

                var rtmp = result.Value.UploadUrl;
                // RTMP URLs looks like this:
                // rtmps://live-upload.instagram.com:443/rtmp/17901439873944893?s_sw=0&s_vt=ig&a=AbxfNWA6SZNMhYz_

                ServerText.Text = rtmp.Substring(0, rtmp.IndexOf("/rtmp") + "/rtmp".Length);
                StreamKeyText.Text = rtmp.Substring(rtmp.IndexOf("/rtmp") + "/rtmp".Length);
                
            }
            else
                PrintError(result.Info);
        }

        // After passing the RTMP URL to OBStudio, now we can start the broadcasting
        private async void StartLiveButton_Click(object sender, EventArgs e)
        {
            var result = await InstaApi.
                LiveProcessor.StartAsync(GetBroadcastId());

            if (result.Succeeded)
            {
                Text = GetTitle() + " - Live started";
                LiveStarted = true;
                RunLikeInstagram();
            }
            else
                PrintError(result.Info);
        }

        private async void StopLiveButton_Click(object sender, EventArgs e)
        {
            var result = await InstaApi.
                LiveProcessor.EndAsync(GetBroadcastId());

            if (result.Succeeded)
            {
                LiveStarted = false;
                Text = GetTitle() + " - Live stoped";
                AddToIGTVButton.Enabled = true;
                await InstaApi.LiveProcessor.GetFinalViewerListAsync(GetBroadcastId());

                CommentIds.Clear();
            }
            else
                PrintError(result.Info);
        }


        InstaComment MyLastComment; // For pin/unpin a comment
        private async void CommentButton_Click(object sender, EventArgs e)
        {
            var result = await InstaApi.LiveProcessor
                .CommentAsync(GetBroadcastId(), CommentText.Text.Trim());

            if (result.Succeeded)
            {
                MyLastComment = result.Value;
                PinCommentButton.Enabled = UnPinCommentButton.Enabled = true;
                MessageBox.Show("Comment sent");
            }
            else
                PrintError(result.Info);

        }

        private async void PinCommentButton_Click(object sender, EventArgs e)
        {
            var result = await InstaApi.LiveProcessor
                .PinCommentAsync(GetBroadcastId(), MyLastComment.Pk.ToString());

            if (result.Succeeded)
            {
                PinCommentButton.Enabled = UnPinCommentButton.Enabled = true;
                MessageBox.Show("Comment pinned");
            }
            else
                PrintError(result.Info);
        }

        private async void UnPinCommentButton_Click(object sender, EventArgs e)
        {
            var result = await InstaApi.LiveProcessor
                .UnPinCommentAsync(GetBroadcastId(), MyLastComment.Pk.ToString());

            if (result.Succeeded)
            {
                MessageBox.Show("Comment unpinned");
            }
            else
                PrintError(result.Info);
        }



        uint OffsetToVideoStart = 0;
        // Instagram sends these requests every 2,3 seconds
        async void RunLikeInstagram()
        {
            var broadcastId = GetBroadcastId();
            OffsetToVideoStart = 0;
            // Disable ask a question 
            await InstaApi.LiveProcessor.SetQuestionStatusAsync(broadcastId, false).ConfigureAwait(false);
            
            while (LiveStarted)
            {
                GetComments(broadcastId);
                GetHeartbeat(broadcastId);
                await GetViewerList(broadcastId).ConfigureAwait(false);
                await Task.Delay(2500);
            }
        }


        InstaBroadcastComment LastComment;
        private readonly List<long> CommentIds = new List<long>();
        async void GetComments(string broadcastId)
        {
            try
            {
                var t = LastComment == null ?
                    0 : LastComment.CreatedAtUtc.ToUnixTime();

                var result = await InstaApi.LiveProcessor
                    .GetCommentsAsync(broadcastId, t.ToString());

                if (result.Succeeded && result.Value.Comments.Count > 0)
                {
                    result.Value.Comments.ForEach(cmt =>
                    {
                        if (!CommentIds.Contains(cmt.Pk))
                        {
                            string[] row = { cmt.User.UserName, cmt.Text, cmt.CreatedAtUtc.ToString(), cmt.Pk.ToString() };
                            var listViewItem = new ListViewItem(row);
                            LVComments.Items.Add(listViewItem);

                            CommentIds.Add(cmt.Pk);
                        }
                    });
                    lock(LastComment)
                        LastComment = result.Value.Comments.LastOrDefault();

                }
            }
            catch { }
        }

        async void GetHeartbeat(string broadcastId)
        {
            try
            {
                var result = await InstaApi.LiveProcessor.GetHeartBeatAndViewerCountAsync(broadcastId,
                   OffsetToVideoStart);

                if (result.Succeeded)
                    LiveGroup.Text = "ViewerCount: " + result.Value.ViewerCount;
                OffsetToVideoStart += 2;
            }
            catch { }
        }

        async Task GetViewerList(string broadcastId)
        {
            try
            {
                var result = await InstaApi.LiveProcessor.GetViewerListAsync(broadcastId);
                if (result.Succeeded)
                {
                    // Do something with it
                }
            }
            catch { }
        }

        private async void AddToIGTVButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Check this out");


            string broadcastId = GetBroadcastId();
            string title = "Title bayad dashte bashe"; // cannot be null or empty
            string description = ""; // optional
            bool sharePreviewToFeed = false; // If you want to show a preview of your image in your feeds, set it to TRUE
            var cover = new InstaImage // Your image cover MUST BE VERTICAL
            {
                Uri = "",
                //ImageBytes // Or image bytes
            };

            string igTvSeries = null; // ig tv series, if you would like to create a new TV Series:
            //igTvSeries = await CreateIgTvSeries().ConfigureAwait(false);

            var result = await InstaApi.TVProcessor
                .AddLiveBroadcastToTVAsync(broadcastId,
                cover, 
                title,
                description, 
                sharePreviewToFeed,
                igTvSeries);
        }

        async Task<string> CreateIgTvSeries()
        {
            string name = "MY TV Series";
            string description = "Bluh bluh bluh";
            await InstaApi.TVProcessor.GetTVCreationToolsAsync(); // Must be call one time
            var result = await InstaApi.TVProcessor.CreateTVSeriesAsync(name, description).ConfigureAwait(false);

            return result.Value?.Id;
        }

        private void CopyServerButton_Click(object sender, EventArgs e) =>
            Clipboard.SetText(ServerText.Text);

        private void CopyStreamButton_Click(object sender, EventArgs e) =>
            Clipboard.SetText(StreamKeyText.Text);

        string GetBroadcastId() => InstaBroadcastCreate.BroadcastId.ToString();

        string GetTitle() =>
             $"Live Demo - {UserText.Text} Connected";

        void PrintError(ResultInfo resultInfo) =>
            MessageBox.Show(resultInfo.Message, resultInfo.ResponseType.ToString());

    }
}

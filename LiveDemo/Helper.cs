using InstagramApiSharp.Classes;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Logger;
using InstagramApiSharp.Classes.SessionHandlers;

namespace LiveDemo
{
    static public class Helper
    {
        private const string SESSION_FILE_PATH = "Session.dat";

        internal static IInstaApi InstaApi { get; private set; }

        public static bool BuildApi() => BuildApi("", ""); 
                                                                          

        public static bool BuildApi(string user, string password)
        {
            InstaApi = InstaApiBuilder.CreateBuilder()
               .SetUser(UserSessionData.ForUsername(user).WithPassword(password))
               .UseLogger(new DebugLogger(LogLevel.All))
               .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
               .SetSessionHandler(new FileSessionHandler { FilePath = SESSION_FILE_PATH })
               .Build();

            return LoadSession();
        }

        public static bool LoadSession()
        {
            InstaApi?.SessionHandler?.Load();
            return InstaApi?.IsUserAuthenticated ?? false;
        }

        public static void SaveSession()
        {
            if (InstaApi?.IsUserAuthenticated ?? false)
                InstaApi.SessionHandler?.Save();
        }
    }
}

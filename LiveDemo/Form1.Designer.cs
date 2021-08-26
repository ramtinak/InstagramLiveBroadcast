
namespace LiveDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.LiveGroup = new System.Windows.Forms.GroupBox();
            this.LiveTitleText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddToIGTVButton = new System.Windows.Forms.Button();
            this.CopyStreamButton = new System.Windows.Forms.Button();
            this.CopyServerButton = new System.Windows.Forms.Button();
            this.StreamKeyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerText = new System.Windows.Forms.TextBox();
            this.CreateLiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RtmpText = new System.Windows.Forms.TextBox();
            this.StopLiveButton = new System.Windows.Forms.Button();
            this.StartLiveButton = new System.Windows.Forms.Button();
            this.LVComments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentGP = new System.Windows.Forms.GroupBox();
            this.UnPinCommentButton = new System.Windows.Forms.Button();
            this.PinCommentButton = new System.Windows.Forms.Button();
            this.CommentButton = new System.Windows.Forms.Button();
            this.CommentText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.LiveGroup.SuspendLayout();
            this.CommentGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.PassText);
            this.groupBox1.Controls.Add(this.UserText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(145, 87);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 38);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(13, 59);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(207, 22);
            this.PassText.TabIndex = 2;
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(13, 31);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(207, 22);
            this.UserText.TabIndex = 1;
            // 
            // LiveGroup
            // 
            this.LiveGroup.Controls.Add(this.LiveTitleText);
            this.LiveGroup.Controls.Add(this.label4);
            this.LiveGroup.Controls.Add(this.AddToIGTVButton);
            this.LiveGroup.Controls.Add(this.CopyStreamButton);
            this.LiveGroup.Controls.Add(this.CopyServerButton);
            this.LiveGroup.Controls.Add(this.StreamKeyText);
            this.LiveGroup.Controls.Add(this.label3);
            this.LiveGroup.Controls.Add(this.label2);
            this.LiveGroup.Controls.Add(this.ServerText);
            this.LiveGroup.Controls.Add(this.CreateLiveButton);
            this.LiveGroup.Controls.Add(this.label1);
            this.LiveGroup.Controls.Add(this.RtmpText);
            this.LiveGroup.Controls.Add(this.StopLiveButton);
            this.LiveGroup.Controls.Add(this.StartLiveButton);
            this.LiveGroup.Location = new System.Drawing.Point(248, 8);
            this.LiveGroup.Name = "LiveGroup";
            this.LiveGroup.Size = new System.Drawing.Size(916, 160);
            this.LiveGroup.TabIndex = 1;
            this.LiveGroup.TabStop = false;
            this.LiveGroup.Text = "Live operations";
            // 
            // LiveTitleText
            // 
            this.LiveTitleText.Location = new System.Drawing.Point(74, 18);
            this.LiveTitleText.Multiline = true;
            this.LiveTitleText.Name = "LiveTitleText";
            this.LiveTitleText.Size = new System.Drawing.Size(836, 32);
            this.LiveTitleText.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Live title: ";
            // 
            // AddToIGTVButton
            // 
            this.AddToIGTVButton.Enabled = false;
            this.AddToIGTVButton.Location = new System.Drawing.Point(704, 55);
            this.AddToIGTVButton.Name = "AddToIGTVButton";
            this.AddToIGTVButton.Size = new System.Drawing.Size(206, 38);
            this.AddToIGTVButton.TabIndex = 12;
            this.AddToIGTVButton.Text = "Add to IGTV";
            this.AddToIGTVButton.UseVisualStyleBackColor = true;
            this.AddToIGTVButton.Click += new System.EventHandler(this.AddToIGTVButton_Click);
            // 
            // CopyStreamButton
            // 
            this.CopyStreamButton.Location = new System.Drawing.Point(843, 128);
            this.CopyStreamButton.Name = "CopyStreamButton";
            this.CopyStreamButton.Size = new System.Drawing.Size(52, 23);
            this.CopyStreamButton.TabIndex = 11;
            this.CopyStreamButton.Text = "Copy";
            this.CopyStreamButton.UseVisualStyleBackColor = true;
            this.CopyStreamButton.Click += new System.EventHandler(this.CopyStreamButton_Click);
            // 
            // CopyServerButton
            // 
            this.CopyServerButton.Location = new System.Drawing.Point(317, 129);
            this.CopyServerButton.Name = "CopyServerButton";
            this.CopyServerButton.Size = new System.Drawing.Size(52, 23);
            this.CopyServerButton.TabIndex = 4;
            this.CopyServerButton.Text = "Copy";
            this.CopyServerButton.UseVisualStyleBackColor = true;
            this.CopyServerButton.Click += new System.EventHandler(this.CopyServerButton_Click);
            // 
            // StreamKeyText
            // 
            this.StreamKeyText.Location = new System.Drawing.Point(473, 128);
            this.StreamKeyText.Name = "StreamKeyText";
            this.StreamKeyText.Size = new System.Drawing.Size(357, 22);
            this.StreamKeyText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stream key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server:";
            // 
            // ServerText
            // 
            this.ServerText.Location = new System.Drawing.Point(74, 130);
            this.ServerText.Name = "ServerText";
            this.ServerText.Size = new System.Drawing.Size(237, 22);
            this.ServerText.TabIndex = 7;
            // 
            // CreateLiveButton
            // 
            this.CreateLiveButton.Location = new System.Drawing.Point(106, 56);
            this.CreateLiveButton.Name = "CreateLiveButton";
            this.CreateLiveButton.Size = new System.Drawing.Size(103, 38);
            this.CreateLiveButton.TabIndex = 6;
            this.CreateLiveButton.Text = "Create live";
            this.CreateLiveButton.UseVisualStyleBackColor = true;
            this.CreateLiveButton.Click += new System.EventHandler(this.CreateLiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rtmp:";
            // 
            // RtmpText
            // 
            this.RtmpText.Location = new System.Drawing.Point(65, 99);
            this.RtmpText.Name = "RtmpText";
            this.RtmpText.Size = new System.Drawing.Size(830, 22);
            this.RtmpText.TabIndex = 4;
            // 
            // StopLiveButton
            // 
            this.StopLiveButton.Enabled = false;
            this.StopLiveButton.Location = new System.Drawing.Point(518, 56);
            this.StopLiveButton.Name = "StopLiveButton";
            this.StopLiveButton.Size = new System.Drawing.Size(108, 38);
            this.StopLiveButton.TabIndex = 3;
            this.StopLiveButton.Text = "Stop Live";
            this.StopLiveButton.UseVisualStyleBackColor = true;
            this.StopLiveButton.Click += new System.EventHandler(this.StopLiveButton_Click);
            // 
            // StartLiveButton
            // 
            this.StartLiveButton.Enabled = false;
            this.StartLiveButton.Location = new System.Drawing.Point(309, 56);
            this.StartLiveButton.Name = "StartLiveButton";
            this.StartLiveButton.Size = new System.Drawing.Size(97, 38);
            this.StartLiveButton.TabIndex = 2;
            this.StartLiveButton.Text = "Start live";
            this.StartLiveButton.UseVisualStyleBackColor = true;
            this.StartLiveButton.Click += new System.EventHandler(this.StartLiveButton_Click);
            // 
            // LVComments
            // 
            this.LVComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LVComments.HideSelection = false;
            this.LVComments.Location = new System.Drawing.Point(248, 174);
            this.LVComments.Name = "LVComments";
            this.LVComments.Size = new System.Drawing.Size(916, 273);
            this.LVComments.TabIndex = 2;
            this.LVComments.UseCompatibleStateImageBehavior = false;
            this.LVComments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comment";
            this.columnHeader2.Width = 512;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Timestamp";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pk";
            this.columnHeader4.Width = 119;
            // 
            // CommentGP
            // 
            this.CommentGP.Controls.Add(this.UnPinCommentButton);
            this.CommentGP.Controls.Add(this.PinCommentButton);
            this.CommentGP.Controls.Add(this.CommentButton);
            this.CommentGP.Controls.Add(this.CommentText);
            this.CommentGP.Enabled = false;
            this.CommentGP.Location = new System.Drawing.Point(12, 163);
            this.CommentGP.Name = "CommentGP";
            this.CommentGP.Size = new System.Drawing.Size(223, 275);
            this.CommentGP.TabIndex = 3;
            this.CommentGP.TabStop = false;
            this.CommentGP.Text = "Comment";
            // 
            // UnPinCommentButton
            // 
            this.UnPinCommentButton.Enabled = false;
            this.UnPinCommentButton.Location = new System.Drawing.Point(74, 236);
            this.UnPinCommentButton.Name = "UnPinCommentButton";
            this.UnPinCommentButton.Size = new System.Drawing.Size(143, 38);
            this.UnPinCommentButton.TabIndex = 9;
            this.UnPinCommentButton.Text = "UnPin comment";
            this.UnPinCommentButton.UseVisualStyleBackColor = true;
            this.UnPinCommentButton.Click += new System.EventHandler(this.UnPinCommentButton_Click);
            // 
            // PinCommentButton
            // 
            this.PinCommentButton.Enabled = false;
            this.PinCommentButton.Location = new System.Drawing.Point(74, 195);
            this.PinCommentButton.Name = "PinCommentButton";
            this.PinCommentButton.Size = new System.Drawing.Size(143, 38);
            this.PinCommentButton.TabIndex = 8;
            this.PinCommentButton.Text = "Pin comment";
            this.PinCommentButton.UseVisualStyleBackColor = true;
            this.PinCommentButton.Click += new System.EventHandler(this.PinCommentButton_Click);
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(74, 154);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(143, 38);
            this.CommentButton.TabIndex = 7;
            this.CommentButton.Text = "Send comment";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(6, 21);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(207, 127);
            this.CommentText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.CommentGP);
            this.Controls.Add(this.LVComments);
            this.Controls.Add(this.LiveGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Live Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LiveGroup.ResumeLayout(false);
            this.LiveGroup.PerformLayout();
            this.CommentGP.ResumeLayout(false);
            this.CommentGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.GroupBox LiveGroup;
        private System.Windows.Forms.TextBox RtmpText;
        private System.Windows.Forms.Button StopLiveButton;
        private System.Windows.Forms.Button StartLiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateLiveButton;
        private System.Windows.Forms.ListView LVComments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox CommentGP;
        private System.Windows.Forms.Button UnPinCommentButton;
        private System.Windows.Forms.Button PinCommentButton;
        private System.Windows.Forms.Button CommentButton;
        private System.Windows.Forms.TextBox CommentText;
        private System.Windows.Forms.TextBox ServerText;
        private System.Windows.Forms.TextBox StreamKeyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyStreamButton;
        private System.Windows.Forms.Button CopyServerButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button AddToIGTVButton;
        private System.Windows.Forms.TextBox LiveTitleText;
        private System.Windows.Forms.Label label4;
    }
}


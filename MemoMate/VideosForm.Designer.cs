
namespace NoteTaker
{
    partial class VideosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideosForm));
            this.videoView1 = new VisioForge.Core.UI.WinForms.VideoView();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btKaydetAd = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recycleBinButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.audiosButton = new System.Windows.Forms.Button();
            this.alarmsButton = new System.Windows.Forms.Button();
            this.imagesButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textNotsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.videoView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Controls.Add(this.axWindowsMediaPlayer);
            this.videoView1.Location = new System.Drawing.Point(255, 93);
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(677, 439);
            this.videoView1.StatusOverlay = null;
            this.videoView1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(5, 3);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(669, 433);
            this.axWindowsMediaPlayer.TabIndex = 15;
            this.axWindowsMediaPlayer.Visible = false;
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Enter);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(215, 538);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 34);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(473, 538);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(81, 34);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btKaydet
            // 
            this.btKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKaydet.Location = new System.Drawing.Point(560, 29);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(82, 25);
            this.btKaydet.TabIndex = 4;
            this.btKaydet.Text = "Seç";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video Kayıt Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dosya Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 26);
            this.textBox2.TabIndex = 7;
            // 
            // btKaydetAd
            // 
            this.btKaydetAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKaydetAd.Location = new System.Drawing.Point(560, 61);
            this.btKaydetAd.Name = "btKaydetAd";
            this.btKaydetAd.Size = new System.Drawing.Size(82, 26);
            this.btKaydetAd.TabIndex = 8;
            this.btKaydetAd.Text = "Kaydet";
            this.btKaydetAd.UseVisualStyleBackColor = true;
            this.btKaydetAd.Click += new System.EventHandler(this.btKaydetAd_Click);
            // 
            // btResume
            // 
            this.btResume.Location = new System.Drawing.Point(383, 538);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(81, 34);
            this.btResume.TabIndex = 9;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(296, 538);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(81, 34);
            this.btPause.TabIndex = 10;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 19;
            this.listFile.Location = new System.Drawing.Point(209, 133);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(45, 23);
            this.listFile.TabIndex = 16;
            this.listFile.Visible = false;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Location = new System.Drawing.Point(711, 52);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(221, 35);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Kaydedilmiş Videolar";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.recycleBinButton);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.audiosButton);
            this.panel1.Controls.Add(this.alarmsButton);
            this.panel1.Controls.Add(this.imagesButton);
            this.panel1.Controls.Add(this.videosButton);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.textNotsButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 572);
            this.panel1.TabIndex = 18;
            // 
            // recycleBinButton
            // 
            this.recycleBinButton.FlatAppearance.BorderSize = 0;
            this.recycleBinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recycleBinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recycleBinButton.ForeColor = System.Drawing.Color.White;
            this.recycleBinButton.Image = ((System.Drawing.Image)(resources.GetObject("recycleBinButton.Image")));
            this.recycleBinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recycleBinButton.Location = new System.Drawing.Point(10, 401);
            this.recycleBinButton.Name = "recycleBinButton";
            this.recycleBinButton.Size = new System.Drawing.Size(197, 54);
            this.recycleBinButton.TabIndex = 5;
            this.recycleBinButton.Text = "     Recycle Bin";
            this.recycleBinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recycleBinButton.UseVisualStyleBackColor = true;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // audiosButton
            // 
            this.audiosButton.FlatAppearance.BorderSize = 0;
            this.audiosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audiosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosButton.ForeColor = System.Drawing.Color.White;
            this.audiosButton.Image = ((System.Drawing.Image)(resources.GetObject("audiosButton.Image")));
            this.audiosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.audiosButton.Location = new System.Drawing.Point(10, 227);
            this.audiosButton.Name = "audiosButton";
            this.audiosButton.Size = new System.Drawing.Size(197, 54);
            this.audiosButton.TabIndex = 4;
            this.audiosButton.Text = "        Audious";
            this.audiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.audiosButton.UseVisualStyleBackColor = true;
            this.audiosButton.Click += new System.EventHandler(this.audiosButton_Click);
            // 
            // alarmsButton
            // 
            this.alarmsButton.FlatAppearance.BorderSize = 0;
            this.alarmsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmsButton.ForeColor = System.Drawing.Color.White;
            this.alarmsButton.Image = ((System.Drawing.Image)(resources.GetObject("alarmsButton.Image")));
            this.alarmsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alarmsButton.Location = new System.Drawing.Point(10, 345);
            this.alarmsButton.Name = "alarmsButton";
            this.alarmsButton.Size = new System.Drawing.Size(197, 54);
            this.alarmsButton.TabIndex = 4;
            this.alarmsButton.Text = "          Alarms";
            this.alarmsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alarmsButton.UseVisualStyleBackColor = true;
            // 
            // imagesButton
            // 
            this.imagesButton.FlatAppearance.BorderSize = 0;
            this.imagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesButton.ForeColor = System.Drawing.Color.White;
            this.imagesButton.Image = ((System.Drawing.Image)(resources.GetObject("imagesButton.Image")));
            this.imagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imagesButton.Location = new System.Drawing.Point(10, 285);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(197, 57);
            this.imagesButton.TabIndex = 4;
            this.imagesButton.Text = "   Screenshotes";
            this.imagesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imagesButton.UseVisualStyleBackColor = true;
            // 
            // videosButton
            // 
            this.videosButton.FlatAppearance.BorderSize = 0;
            this.videosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosButton.ForeColor = System.Drawing.Color.White;
            this.videosButton.Image = ((System.Drawing.Image)(resources.GetObject("videosButton.Image")));
            this.videosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videosButton.Location = new System.Drawing.Point(10, 170);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(197, 54);
            this.videosButton.TabIndex = 4;
            this.videosButton.Text = "        Videos";
            this.videosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.videosButton.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textNotsButton
            // 
            this.textNotsButton.FlatAppearance.BorderSize = 0;
            this.textNotsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textNotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotsButton.ForeColor = System.Drawing.Color.White;
            this.textNotsButton.Image = ((System.Drawing.Image)(resources.GetObject("textNotsButton.Image")));
            this.textNotsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textNotsButton.Location = new System.Drawing.Point(12, 115);
            this.textNotsButton.Name = "textNotsButton";
            this.textNotsButton.Size = new System.Drawing.Size(197, 54);
            this.textNotsButton.TabIndex = 4;
            this.textNotsButton.Text = "       Text Notes";
            this.textNotsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.textNotsButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(10, 59);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(197, 54);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "        Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.btnMaximize);
            this.header.Controls.Add(this.buttonMinimize);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(209, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(735, 23);
            this.header.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(709, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaximize.Location = new System.Drawing.Point(677, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 23);
            this.btnMaximize.TabIndex = 20;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMinimize.Location = new System.Drawing.Point(644, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(26, 23);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // VideosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 572);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btKaydetAd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btKaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.videoView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VideosForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.VideosForm_Load);
            this.videoView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private VisioForge.Core.UI.WinForms.VideoView videoView1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btKaydetAd;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btPause;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button recycleBinButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button audiosButton;
        private System.Windows.Forms.Button alarmsButton;
        private System.Windows.Forms.Button imagesButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button textNotsButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button buttonMinimize;
    }
}
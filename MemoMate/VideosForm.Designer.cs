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
            this.listFile = new System.Windows.Forms.ListBox();
            this.btPause = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.videoView1 = new VisioForge.Core.UI.WinForms.VideoView();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btKaydetAd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btKaydet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.videoView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(18, 34);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(10, 4);
            this.listFile.TabIndex = 22;
            this.listFile.Visible = false;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(90, 483);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(81, 34);
            this.btPause.TabIndex = 21;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btResume
            // 
            this.btResume.Location = new System.Drawing.Point(177, 483);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(81, 34);
            this.btResume.TabIndex = 20;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(267, 483);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(81, 34);
            this.btStop.TabIndex = 19;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(9, 483);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 34);
            this.btStart.TabIndex = 18;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Controls.Add(this.axWindowsMediaPlayer);
            this.videoView1.Location = new System.Drawing.Point(18, 38);
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(677, 439);
            this.videoView1.StatusOverlay = null;
            this.videoView1.TabIndex = 17;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(4, 4);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(669, 433);
            this.axWindowsMediaPlayer.TabIndex = 15;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Location = new System.Drawing.Point(552, 480);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(155, 35);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Kaydedilmiş Videolar";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btKaydetAd
            // 
            this.btKaydetAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKaydetAd.Location = new System.Drawing.Point(643, 13);
            this.btKaydetAd.Name = "btKaydetAd";
            this.btKaydetAd.Size = new System.Drawing.Size(56, 20);
            this.btKaydetAd.TabIndex = 28;
            this.btKaydetAd.Text = "Kaydet";
            this.btKaydetAd.UseVisualStyleBackColor = true;
            this.btKaydetAd.Click += new System.EventHandler(this.btKaydetAd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dosya Adı";
            // 
            // btKaydet
            // 
            this.btKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKaydet.Location = new System.Drawing.Point(300, 12);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(48, 20);
            this.btKaydet.TabIndex = 24;
            this.btKaydet.Text = "Seç";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Video Kayıt Yeri";
            // 
            // VideosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btKaydetAd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btKaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.videoView1);
            this.Name = "VideosForm";
            this.Size = new System.Drawing.Size(719, 529);
            this.Load += new System.EventHandler(this.Video2_Load);
            this.videoView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private VisioForge.Core.UI.WinForms.VideoView videoView1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btKaydetAd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btKaydet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


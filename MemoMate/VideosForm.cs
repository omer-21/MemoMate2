using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VisioForge.Core.VideoCapture;
using VisioForge.Types.VideoCapture;
using IVideoView = VisioForge.Types.IVideoView;

namespace NoteTaker
{
    public partial class VideosForm : UserControl
    {

        private VideoCaptureCore core;
        string dosyaYolu, dosyaAdi;
        bool kontrol = false;
        bool kontrol2 = false;
        public static bool home = true;
        private static VideosForm instance;
        public static VideosForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new VideosForm();
                }

                // Return the existing instance
                return instance;
            }
        }

        public VideosForm()
        {
            InitializeComponent();
        }

        private void Video2_Load(object sender, EventArgs e)
        {
            core = new VideoCaptureCore(videoView1 as IVideoView);
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
            btKaydet.BackColor= Color.FromArgb(178, 8, 55);
            btKaydetAd.BackColor= Color.FromArgb(178, 8, 55);
            btnOpen.BackColor= Color.FromArgb(178, 8, 55);
            btPause.BackColor= Color.FromArgb(178, 8, 55);
            btResume.BackColor= Color.FromArgb(178, 8, 55);
            btStart.BackColor= Color.FromArgb(178, 8, 55);
            btStop.BackColor= Color.FromArgb(178, 8, 55);
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Visible = false;
            if (kontrol && kontrol2)
            {
                core.Screen_Capture_Source = new ScreenCaptureSourceSettings() { FullScreen = true };

                var mp4Output = new VisioForge.Types.Output.MP4Output();
                core.Output_Format = mp4Output;
                core.Output_Filename = dosyaYolu + "\\" + dosyaAdi + ".mp4";
                core.Mode = (VisioForge.Types.VideoCapture.VideoCaptureMode)VideoCaptureMode.ScreenCapture;


                await core.StartAsync();
            }
            else
            {
                MessageBox.Show("Video kayıt yeri seçilmedi veya geçersiz dosya adı...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btStop_Click(object sender, EventArgs e)
        {
            await core.StopAsync();
            textBox1.Text = "";
            textBox2.Text = "";
            kontrol = false;
            kontrol2 = false;
        }

        private async void btPause_Click(object sender, EventArgs e)
        {
            await core.PauseAsync();
        }

        private async void btResume_Click(object sender, EventArgs e)
        {
            await core.ResumeAsync();
        }

        private void btKaydetAd_Click(object sender, EventArgs e)
        {
            dosyaAdi = textBox2.Text;
            kontrol2 = true;
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyaYolu;
                kontrol = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listFile.DataSource = files;
                }
            }

            axWindowsMediaPlayer.close();
            axWindowsMediaPlayer.Visible = true;

        }
        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listFile.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }
    }
}

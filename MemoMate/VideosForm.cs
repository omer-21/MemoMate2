using NoteTaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Core;
using VisioForge.Core.VideoCapture;
using VisioForge.Types;
using VisioForge.Types.Output;
using VisioForge.Types.VideoCapture;

namespace NoteTaker
{
    public partial class VideosForm : Form
    {
        private VideoCaptureCore core;
        string dosyaYolu,dosyaAdi;
        Boolean kontrol=false;
        Boolean kontrol2 = false;
        private string outputFileName;


        public VideosForm()
        {
            InitializeComponent();
        }

        private void VideosForm_Load(object sender, EventArgs e)
        {
            core = new VideoCaptureCore(videoView1 as IVideoView);
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
            SidePanel.Height = videosButton.Height;
            SidePanel.Top = videosButton.Top;
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Visible = false;
            if (kontrol && kontrol2)
            {
                core.Screen_Capture_Source = new ScreenCaptureSourceSettings() { FullScreen = true };

                var mp4Output = new MP4Output();
                core.Output_Format = mp4Output;
                core.Output_Filename = dosyaYolu + "\\" + dosyaAdi + ".mp4";
                core.Mode = VideoCaptureMode.ScreenCapture;


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

        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {
            
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

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void audiosButton_Click(object sender, EventArgs e)
        {
            AudiousForm af = new AudiousForm();
            af.StartPosition = FormStartPosition.CenterScreen;
            af.Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.StartPosition = FormStartPosition.CenterScreen;
            hm.Show();
            this.Hide();
        }

    }
}

using NAudio.CoreAudioApi;
using NAudio.Wave;
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

namespace NoteTaker
{
    public partial class AudiousForm : Form
    {
        private string outputFileName;
        private WasapiLoopbackCapture capture;
        private WaveFileWriter writer;

        public AudiousForm()
        {
            InitializeComponent();
            LoadDevices();
            SidePanel.Height = audiosButton.Height;
            SidePanel.Top = audiosButton.Top;
        }

        private void LoadDevices()
        {
            var enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            OutputDeviceComboBox.Items.AddRange(devices.ToArray());
            OutputDeviceComboBox.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files|*.wav";
            
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            outputFileName = dialog.FileName;

            var device = (MMDevice)OutputDeviceComboBox.SelectedItem;
            capture = new WasapiLoopbackCapture(device);
            writer = new WaveFileWriter(outputFileName, capture.WaveFormat);
            capture.DataAvailable += (s, a) =>
            {
                writer.Write(a.Buffer, 0, a.BytesRecorded);
            };
            capture.RecordingStopped += (s, a) =>
            {
                writer.Dispose();
                capture.Dispose();
                StartButton.Enabled = true;
                StopButton.Enabled = false;

                var startInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(outputFileName),
                    UseShellExecute = true
                };
                //Process.Start(startInfo);
            };
            capture.StartRecording();
            StartButton.Enabled = false;
            StopButton.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.StopRecording();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.StartPosition = FormStartPosition.CenterScreen;
            hm.Show();
            this.Hide();
        }

        private void videosButton_Click(object sender, EventArgs e)
        {
            VideosForm vf = new VideosForm();
            vf.StartPosition = FormStartPosition.CenterScreen;
            vf.Show();
            this.Hide();
        }
    }
}

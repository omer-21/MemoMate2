using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using Newtonsoft.Json;

namespace NoteTaker
{
    public partial class AudiosForm : UserControl
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private string fileName;
        private bool isRecording = false;
        private string soundsFilePath = "sounds.json";
        private bool isPlaying = false;
        private PlaybackState playbackState = PlaybackState.Stopped;

        private List<SoundItem> soundItems = new List<SoundItem>();
        public static bool home = true;
        private static AudiosForm instance;
        public static AudiosForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new AudiosForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        public class SoundItem
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public TimeSpan Duration { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSoundsFromFile(soundsFilePath);
            SetColumnHeaderColor();
            RecordButton.BackColor = Color.FromArgb(178, 8, 55);
            PlayButton.BackColor = Color.FromArgb(178, 8, 55);
            DeleteButton.BackColor = Color.FromArgb(178, 8, 55);
        }
        public AudiosForm()
        {
            InitializeComponent();
            waveIn = new WaveInEvent();
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.RecordingStopped += WaveIn_RecordingStopped;
            waveOut = new WaveOutEvent();
            RecordButton.Text = "Start Record";
            pictureBoxStopRec.Visible = false;
            pictureBoxPause.Visible = false;
        }

        private void SetColumnHeaderColor()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                string fileNameInput = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(fileNameInput))
                {
                    MessageBox.Show("Dosya adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fileName = textBox1.Text + ".wav";
                if (waveIn == null)
                {
                    waveIn = new WaveInEvent();
                    waveIn.DataAvailable += WaveIn_DataAvailable;
                    waveIn.RecordingStopped += WaveIn_RecordingStopped;
                }
                waveIn.WaveFormat = new WaveFormat(44100, 16, 1);
                writer = new WaveFileWriter(fileName, waveIn.WaveFormat);
                waveIn.StartRecording();
                isRecording = true;
                RecordButton.Text = "Stop Record";
                textBox1.Text = " ";
                pictureBoxStartRec.Visible = false;
                pictureBoxStopRec.Visible = true;
            }
            else
            {
                waveIn.StopRecording();
                isRecording = false;
                RecordButton.Text = "Start Record";
                pictureBoxStartRec.Visible = true;
                pictureBoxStopRec.Visible = false;


                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    writer = null;
                }

                if (waveIn != null)
                {
                    waveIn.Dispose();
                    waveIn = null;
                }

                var soundItem = new SoundItem
                {
                    FileName = Path.GetFileName(fileName),
                    FilePath = fileName,
                    Duration = GetSoundDuration(fileName)
                };

                soundItems.Add(soundItem);
                AddSoundItemToDataGridView(soundItem);
                SaveSoundsToFile(soundsFilePath);
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }

            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }
        }
        private TimeSpan GetSoundDuration(string filePath)
        {
            try
            {
                using (var audioFileReader = new AudioFileReader(filePath))
                {
                    return audioFileReader.TotalTime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses süresini alırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return TimeSpan.Zero;
            }
        }

        private void AddSoundItemToDataGridView(SoundItem soundItem)
        {
            var rowIndex = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[rowIndex];
            row.Cells["FileNameColumn"].Value = soundItem.FileName;
            row.Cells["DurationColumn"].Value = soundItem.Duration.ToString(@"mm\:ss");
            row.Tag = soundItem; // SoundItem'i satırın Tag özelliğine atayın
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedSoundItem = (SoundItem)selectedRow.Tag;

                if (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    waveOut.Pause(); // Eğer ses çalınıyorsa, duraklat
                    PlayButton.Text = "Play"; // Düğme metnini "Oynat" olarak güncelle
                    pictureBoxPlay.Visible = true;
                    pictureBoxPause.Visible = false;
                }
                else
                {
                    if (waveOut.PlaybackState == PlaybackState.Paused)
                    {
                        waveOut.Play(); // Eğer ses duraklatılmışsa, devam ettir
                    }
                    else
                    {
                        if (audioFile != null)
                        {
                            audioFile.Dispose();
                            audioFile = null;
                        }

                        audioFile = new AudioFileReader(selectedSoundItem.FilePath);
                        waveOut.Init(audioFile);
                        waveOut.Play();
                    }

                    PlayButton.Text = "Pause"; // Düğme metnini "Duraklat" olarak güncelle
                    pictureBoxPlay.Visible = false;
                    pictureBoxPause.Visible = true;
                }

                waveOut.PlaybackStopped += (s, args) =>
                {
                    PlayButton.Invoke(new Action(() =>
                    {
                        PlayButton.Text = "Play"; // Düğme metnini "Oynat" olarak güncelle
                        pictureBoxPlay.Visible = true;
                        pictureBoxPause.Visible = false;
                    }));
                };
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedSoundItem = (SoundItem)selectedRow.Tag;

                // Çalma durumunu kontrol et
                if (waveOut != null && (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused))
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }

                if (audioFile != null)
                {
                    audioFile.Dispose();
                    audioFile = null;
                }

                // Dosyayı sil
                File.Delete(selectedSoundItem.FilePath);
                dataGridView1.Rows.Remove(selectedRow);
                soundItems.Remove(selectedSoundItem);
                SaveSoundsToFile(soundsFilePath);
            }
        }
        private void SaveSoundsToFile(string filePath)
        {
            var soundPaths = soundItems.Select(si => si.FilePath).ToList();

            string json = JsonConvert.SerializeObject(soundPaths);
            File.WriteAllText(filePath, json);
        }

        private void LoadSoundsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var soundPaths = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (string soundPath in soundPaths)
                {
                    var soundItem = new SoundItem
                    {
                        FileName = Path.GetFileName(soundPath),
                        FilePath = soundPath,
                        Duration = GetSoundDuration(soundPath)
                    };

                    soundItems.Add(soundItem);
                    AddSoundItemToDataGridView(soundItem);
                }
            }
        }
    }
}
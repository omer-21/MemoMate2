using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.IO;

namespace NoteTaker
{
    public partial class AlarmsForm : UserControl
    {

        private List<System.Windows.Forms.Timer> timers = new List<System.Windows.Forms.Timer>();
        private List<Not> notlar = new List<Not>();
        private string filePath = "notlar.json";
        public static bool home = true;
        private static AlarmsForm instance;
        public static AlarmsForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new AlarmsForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        public AlarmsForm()
        {
            InitializeComponent();
            LoadNotesFromFile(filePath);
            CreateAlarmsForNotes();
        }

        public class Not
        {
            public string Baslik { get; set; }
            public DateTime Tarih { get; set; }
            public string Saat { get; set; }
            public string Metin { get; set; }
        }

        int seciliNotIndeksi = -1;

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(9, 152, 234)), e.Bounds);
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(e.Bounds.Right - 1, e.Bounds.Top), new Point(e.Bounds.Right - 1, e.Bounds.Bottom));
            e.DrawText();
        }
        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Today;

            // ListView ayarları
            listView1.View = View.Details;
            listView1.Columns.Add("Note Name", 160);
            listView1.Columns.Add("Note", 308);
            listView1.Columns.Add("Date", 90);
            listView1.Columns.Add("Time", 91);
            buttonGuncelle.Visible = false;

            listView1.OwnerDraw = true;
            listView1.DrawColumnHeader += listView1_DrawColumnHeader;
            listView1.DrawSubItem += listView1_DrawSubItem;

            buttonKaydet.BackColor = Color.FromArgb(178, 8, 55);
            buttonGuncelle.BackColor = Color.FromArgb(178, 8, 55);
            buttonSil.BackColor = Color.FromArgb(178, 8, 55);

            LoadListView();
        }
        private void LoadListView()
        {
            listView1.Items.Clear();
            foreach (Not not in notlar)
            {
                string[] row = { not.Baslik, not.Metin, not.Tarih.ToShortDateString(), not.Saat };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string baslik = textBoxBaslik.Text;
            string metin = textBoxMetin.Text;
            DateTime tarih = monthCalendar1.SelectionStart.Date;

            if (int.TryParse(textBoxSaat.Text, out int saat) && int.TryParse(textBoxDakika.Text, out int dakika))
            {
                if (saat >= 0 && saat <= 23 && dakika >= 0 && dakika <= 59)
                {
                    Not yeniNot = new Not { Baslik = baslik, Tarih = tarih, Saat = saat.ToString("00") + ":" + dakika.ToString("00"), Metin = metin };
                    notlar.Add(yeniNot);
                    SaveNotesToFile(filePath);

                    string[] row = { baslik, metin, tarih.ToShortDateString(), saat.ToString("00") + ":" + dakika.ToString("00") };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);

                    HatirlaticiOlustur(tarih, new TimeSpan(saat, dakika, 0), baslik, metin);

                    MessageBox.Show("Hatırlatıcı oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Geçersiz saat veya dakika değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Saat ve dakika değeri sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                int indeks = listView1.Items.IndexOf(selectedRow);

                notlar.RemoveAt(indeks);
                listView1.Items.Remove(selectedRow);
                SaveNotesToFile(filePath);

                DurdurHatirlatici(indeks);
                ClearTextBoxes();
                // Güncelle butonunu gizle
                buttonGuncelle.Visible = false;
                buttonKaydet.Visible = true;
            }
        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int indeks = selectedItem.Index;
                string yeniBaslik = textBoxBaslik.Text;
                string yeniMetin = textBoxMetin.Text;
                DateTime yeniTarih = monthCalendar1.SelectionStart.Date;
                string yeniSaat = textBoxSaat.Text;
                string yeniDakika = textBoxDakika.Text;

                // Seçili notu güncelle
                notlar[indeks].Baslik = yeniBaslik;
                notlar[indeks].Metin = yeniMetin;
                notlar[indeks].Tarih = yeniTarih;
                notlar[indeks].Saat = yeniSaat + ":" + yeniDakika;
                SaveNotesToFile(filePath);

                // ListView'deki ilgili satırı güncelle
                selectedItem.SubItems[0].Text = yeniBaslik;
                selectedItem.SubItems[1].Text = yeniMetin;
                selectedItem.SubItems[2].Text = yeniTarih.ToShortDateString();
                selectedItem.SubItems[3].Text = yeniSaat + ":" + yeniDakika;

                MessageBox.Show("Hatırlatıcı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listView1.SelectedItems.Clear();
                ClearTextBoxes();

                DurdurHatirlatici(indeks);
                HatirlaticiOlustur(yeniTarih, new TimeSpan(int.Parse(yeniSaat), int.Parse(yeniDakika), 0), yeniBaslik, yeniMetin);

                // Güncelle butonunu gizle
                buttonGuncelle.Visible = false;
                buttonKaydet.Visible = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                int indeks = listView1.Items.IndexOf(selectedRow);
                seciliNotIndeksi = indeks;

                // Başlık ve metin bilgilerini TextBox'lara aktar
                textBoxBaslik.Text = notlar[seciliNotIndeksi].Baslik;
                textBoxMetin.Text = notlar[seciliNotIndeksi].Metin;

                if (notlar[seciliNotIndeksi].Tarih >= monthCalendar1.MinDate) // Tarih, MinDate'den büyük veya eşit olmalı
                    monthCalendar1.SelectionStart = notlar[seciliNotIndeksi].Tarih;
                else
                    monthCalendar1.SelectionStart = monthCalendar1.MinDate;
                string[] saatDakika = notlar[seciliNotIndeksi].Saat.Split(':');
                textBoxSaat.Text = saatDakika[0];
                textBoxDakika.Text = saatDakika[1];

                // Güncelle butonunu göster
                buttonGuncelle.Visible = true;
                buttonKaydet.Visible = false;
            }
        }
        private void HatirlaticiOlustur(DateTime tarih, TimeSpan saat, string baslik, string mesaj)
        {
            DateTime hatirlaticiTarihi = tarih.Date + saat;

            if (hatirlaticiTarihi > DateTime.Now)
            {
                TimeSpan gecikmeSure = hatirlaticiTarihi - DateTime.Now;

                System.Windows.Forms.Timer hatirlaticiTimer = new System.Windows.Forms.Timer();
                hatirlaticiTimer.Tick += (sender, e) =>
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\tahag\OneDrive\Masaüstü\DERSLER\6.DÖNEM\C#\remindermodern\bildirim_sesi.wav";
                    player.Play();

                    MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hatirlaticiTimer.Stop();
                    hatirlaticiTimer.Dispose();
                    timers.Remove(hatirlaticiTimer);
                };

                hatirlaticiTimer.Interval = (int)gecikmeSure.TotalMilliseconds;
                hatirlaticiTimer.Start();
                timers.Add(hatirlaticiTimer);
            }
        }

        private void DurdurHatirlatici(int indeks)
        {
            if (indeks >= 0 && indeks < timers.Count)
            {
                System.Windows.Forms.Timer hatirlaticiTimer = timers[indeks];
                hatirlaticiTimer.Stop();
                hatirlaticiTimer.Dispose();
                timers.RemoveAt(indeks);
            }
        }
        private void ClearTextBoxes()
        {
            textBoxSaat.Text = "";
            textBoxDakika.Text = "";
            textBoxBaslik.Text = "";
            textBoxMetin.Text = "";
            monthCalendar1.SelectionStart = DateTime.Today;
        }
        public void SaveNotesToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(notlar);
            File.WriteAllText(filePath, json);
        }
        public void LoadNotesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                notlar = JsonConvert.DeserializeObject<List<Not>>(json);
                LoadListView();
            }
        }

        private void CreateAlarmsForNotes()
        {
            foreach (Not not in notlar)
            {
                DateTime tarih = not.Tarih;
                TimeSpan saat = TimeSpan.Parse(not.Saat);
                string baslik = not.Baslik;
                string mesaj = not.Metin;

                HatirlaticiOlustur(tarih, saat, baslik, mesaj);
            }
        }
    }
}

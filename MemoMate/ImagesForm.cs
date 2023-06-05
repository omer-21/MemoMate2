using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class ImagesForm : UserControl
    {

        private Form screenshotForm;
        private PictureBox pictureBox;
        public static bool home = true;
        private static ImagesForm instance;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();// Bu liste, alınan tüm ekran görüntülerini saklar.
        private int currentPictureBoxIndex = -1; // listesinin hangi öğesinin şu anda aktif olduğunu belirtmek için kullanılır

        public static ImagesForm Instance  //Bu kod bloğun amacı, yalnızca bir kez oluşturulan ve gerektiğinde kullanılan bir ImagesForm nesnesi sağlamaktır.
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImagesForm();
                }
                return instance;
            }
        }

        public ImagesForm()
        {
            InitializeComponent();
        }

        public void CaptureScreenshot() //ekran görüntüsü almayı başlatır. Bu metod, ana formu gizler ve ekran görüntüsü alma formunu gösterir.
        {
            HideMainForm();
            if (screenshotForm == null)
            {
                screenshotForm = CreateScreenshotForm(); // Screenshot formu oluşturmak için metod çağırmak
                screenshotForm.Controls.Add(CreateCaptureButton()); // "Capture" Screenshot formuna eklemek 
                screenshotForm.Controls.Add(CreateSaveButton()); // "Save" Screenshot Formuna eklemek
            }
            screenshotForm.Show();
        }

        private Form CreateScreenshotForm() //  Screenshot formu oluşturma bu kod bloğu alınan ScreenShot görüntülemesi sağlar
        {
            Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(702, 453);
            pictureBox = CreatePictureBox(); // Screenshot görüntülemek için bir PictureBox oluşturma
            form.Controls.Add(pictureBox); // Screenshot Formuna PictureBox eklemek
            form.FormClosing += ScreenshotForm_FormClosing; // üst sağ form penceredeki X tıkladığında program sonlandıracak
            return form;
        }

        private PictureBox CreatePictureBox() // picture box oluşturma ve kendi özellikleri belirleme
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(660, 315);
            pictureBox.Click += PictureBox_Click;
            pictureBox.Cursor = Cursors.Hand;
            return pictureBox;
        }

        private Button CreateCaptureButton() // Capture buton ve kendi özelliği oluşturma
        {
            Button btn = new Button();
            btn.Location = new Point(538, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Capture";
            btn.Click += CaptureButton_Click;
            return btn;
        }

        private Button CreateSaveButton() // Save buton ve kendi özelliği oluşturma
        {
            Button btn = new Button();
            btn.Location = new Point(418, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Save";
            btn.Click += SaveButton_Click;
            return btn;
        }

        private async void CaptureButton_Click(object sender, EventArgs e)  // bu metod Ekran görüntüsü sağlar 
        {
            screenshotForm.Hide();
            await Task.Delay(1000); // Screenshot formunun tamamen gizlendiğinden emin olmak için kodun 1000 mili saniye yani bir saniye duraklamasını sağlar.
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); // ekranın tam boyutlarında yeni bir Bitmap oluşturur
            using (Graphics graphics = Graphics.FromImage(screenshot)) // Bitmap üzerinde çizim yapmayı sağlayacak Graphics nesnesini oluşturur. 
            {
                graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size); //ekranın tam bir görüntüsünü alır ve Bitmap üzerine çizer.

                pictureBox.Image = screenshot; // ekran görüntüsünü PictureBox kontrolünün Image özelliğine atar


            }
            screenshotForm.Show(); // ekran görüntüsü formunu tekrar gösterir.
        }

        private void SaveButton_Click(object sender, EventArgs e) // Save" düğmesine tıklandığında çalışacak şekilde ayarlanmıştır.
        {
            if (pictureBox.Image != null)
            {
                DialogResult result = MessageBox.Show("Do you want to save the screenshot to a file?", "Screenshot App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG Image|*.png";
                        saveFileDialog.Title = "Save Screenshot"; // Bu satır, dosya kaydetme diyalogunun pencere başlığını ayarlar
                        saveFileDialog.InitialDirectory = @"C:\Your\Specific\Folder\"; //Bu satır, dosya kaydetme diyalogunun açıldığında göstereceği başlangıç klasörünü belirler
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            ((Bitmap)pictureBox.Image).Save(filePath, ImageFormat.Png); // kullanıcının seçtiği dosya yolu alınır ve bu yola
                                                                                        // ekran görüntüsü PNG formatında kaydedilir.
                            MessageBox.Show("Screenshot saved successfully!", "Screenshot App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    PictureBox newPictureBox = new PictureBox();
                    newPictureBox.Image = pictureBox.Image; //  mevcut pictureBox'ın görüntüsü newPictureBox'a atanır.
                    newPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    newPictureBox.Size = new Size(660, 315);
                    pictureBoxes.Add(newPictureBox);
                    currentPictureBoxIndex = pictureBoxes.Count - 1; // değişkenine son eklenen öğenin indeks numarasını atar. Bu şekilde, son eklenen öğeye hızlıca referans verebiliriz.
                    UpdateGallery();
                    MessageBox.Show("Screenshot added to the gallery successfully!", "Screenshot App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            screenshotForm.Hide();
            ShowMainForm();
        }

        private void HideMainForm() // ana formu gizlenir
        {
            Form mainForm = FindForm();
            mainForm.Hide();
        }

        private void ShowMainForm() // ana formu gösterilir
        {
            Form mainForm = FindForm();
            mainForm.Show();
        }
        private Button CreatePreviousButton() // Previous Buton ve kendi özelliği oluşturma
        {
            Button btn = new Button();
            btn.Location = new Point(298, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Previous";
            btn.Click += PreviousButton_Click;
            return btn;
        }

        private Button CreateNextButton()   // Next Buton ve kendi özelliği oluşturma
        {
            Button btn = new Button();
            btn.Location = new Point(418, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Next";
            btn.Click += NextButton_Click;
            return btn;
        }

        private Button CreateDeleteButton() // Delete Buton ve kendi özelliği oluşturma
        {
            Button btn = new Button();
            btn.Location = new Point(538, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Delete";
            btn.Click += DeleteButton_Click;
            return btn;
        }
        private void UpdateGallery()
        {
            PictureBox currentPictureBox = null;

            if (currentPictureBoxIndex >= 0 && currentPictureBoxIndex < pictureBoxes.Count) // currentPictureBoxIndex değişkeninin geçerli bir indeks olup olmadığını kontrol eder.
            {
                currentPictureBox = pictureBoxes[currentPictureBoxIndex]; // mevcut resim 'currentPictureBox' değişkenine atanır
                currentPictureBox.Click += PictureBox_Click;
                currentPictureBox.Cursor = Cursors.Hand;
            }

            this.Controls.Clear(); // ImagesForm kontrol listesini temizler. Bu, form üzerindeki tüm kontrolleri kaldırır.

            if (currentPictureBox != null) // currentPictureBox'ın null olup olmadığını kontrol eder.
            {
                this.Controls.Add(currentPictureBox); // currentPictureBox'ı formun kontrol listesine ekler.
            }
            // Butonları her durumda ekle
            this.Controls.Add(CreateNextButton());
            this.Controls.Add(CreatePreviousButton());
            this.Controls.Add(CreateDeleteButton());
        }
        private void ImagesForm_Load(object sender, EventArgs e)
        {
            UpdateGallery();
        }
        private void PreviousButton_Click(object sender, EventArgs e) // önceki screenshot gösterir
        {
            if (currentPictureBoxIndex > 0)
            {
                currentPictureBoxIndex--;
                UpdateGallery();
            }
        }
        private void NextButton_Click(object sender, EventArgs e) // sonraki screenshot gösterir
        {
            if (currentPictureBoxIndex < pictureBoxes.Count - 1)
            {
                currentPictureBoxIndex++;
                UpdateGallery();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) // istediğimiz screenshot'un silinmesi sağlar 
        {
            if (currentPictureBoxIndex >= 0 && currentPictureBoxIndex < pictureBoxes.Count)
            {
                pictureBoxes.RemoveAt(currentPictureBoxIndex);
                if (currentPictureBoxIndex >= pictureBoxes.Count)
                {
                    currentPictureBoxIndex--;
                }
                UpdateGallery();
            }
        }
        private void PictureBox_Click(object sender, EventArgs e) // kullanıcının bir PictureBox'a tıkladığında resmi tam ekran olarak görüntülemesini sağlar.
        {
            // Picturebox'a tıklanıldığında çalışacak kod
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null && clickedPictureBox.Image != null)
            {
                // Yeni bir form oluşturup, bu formda resmi tam ekran göster
                Form fullScreenForm = new Form();
                fullScreenForm.WindowState = FormWindowState.Maximized;

                PictureBox fullScreenPictureBox = new PictureBox();
                fullScreenPictureBox.Dock = DockStyle.Fill;
                fullScreenPictureBox.Image = clickedPictureBox.Image;
                fullScreenPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                fullScreenForm.Controls.Add(fullScreenPictureBox);
                fullScreenForm.ShowDialog();
            }
        }
        private void ScreenshotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            screenshotForm.Hide();
            ShowMainForm();
        }
    }
}
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            //textNotesForm = null;
        }
        private void homepageB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
        }
        private void textNotesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = textNotsButton.Height;
            SidePanel.Top = textNotsButton.Top;
            active.Visible = true;
            active.Top = textNotsButton.Top;
            IndexForm.home = false;
            IndexForm instance = IndexForm.Instance;
            LoadUserControl(instance);
        }
        //Screenshot codes:
        //{
        private void imagesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = imagesButton.Height;
            SidePanel.Top = imagesButton.Top;
            active.Visible = true;
            active.Top = imagesButton.Top;
            ImagesForm.home = false;
            ImagesForm instance = ImagesForm.Instance;
            LoadUserControl(instance);
            instance.CaptureScreenshot();
        }
        private void videosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = videosButton.Height;
            SidePanel.Top = videosButton.Top;
            active.Visible = true;
            active.Top = videosButton.Top;
            VideosForm.home = false;
            VideosForm instance = VideosForm.Instance;
            LoadUserControl(instance);
        }
        private void alarmsB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = alarmsButton.Height;
            SidePanel.Top = alarmsButton.Top;
            active.Visible = true;
            active.Top = alarmsButton.Top;
            AlarmsForm.home = false;
            AlarmsForm instance = AlarmsForm.Instance;
            LoadUserControl(instance);
        }
        private void recycleBinB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = recycleBinButton.Height;
            SidePanel.Top = recycleBinButton.Top;
            active.Visible = true;
            active.Top = recycleBinButton.Top;
            RecycleBinForm.home = false;
            RecycleBinForm instance = RecycleBinForm.Instance;
            LoadUserControl(instance);
        }
        private void audiosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = audiosButton.Height;
            SidePanel.Top = audiosButton.Top;
            active.Visible = true;
            active.Top = audiosButton.Top;
            AudiosForm.home = false;
            AudiosForm instance = AudiosForm.Instance;
            LoadUserControl(instance);
        }
        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Loadform(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
                this.childPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            //f.TopLevel = false;
            //f.Dock = DockStyle.Fill;
            f.BringToFront();
            //f.Show();
        }
        public void LoadUserControl(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
                this.childPanel.Controls.RemoveAt(0);
            UserControl f = Form as UserControl;
            //f.TopLevel = false;
            //f.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(f);
            this.childPanel.Tag = f;
            f.Location = new Point(10, 10);
            f.BringToFront();
            //f.Show();
        }
    }
}

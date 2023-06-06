using System;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class HomePageForm : UserControl
    {
        public static bool home = true;
        private static HomePageForm instance;
        public static HomePageForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new HomePageForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

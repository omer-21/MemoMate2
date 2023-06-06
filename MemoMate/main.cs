using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class main : UserControl
    {
        public static bool home = true;
        private static main instance;
        public static main Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new main();
                }

                // Return the existing instance
                return instance;
            }
        }
        public main()
        {
            InitializeComponent();
        }
    }
}

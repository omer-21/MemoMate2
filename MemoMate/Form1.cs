﻿using NoteTaker;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            
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
            
        }
        private void imagesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = imagesButton.Height;
            SidePanel.Top = imagesButton.Top;
            
        }
        private void videosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = videosButton.Height;
            SidePanel.Top = videosButton.Top;

            Video2 vf = new Video2();
            vf.StartPosition = FormStartPosition.CenterScreen;
            vf.Show();
            this.Hide();

        }
        private void alarmsB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = alarmsButton.Height;
            SidePanel.Top = alarmsButton.Top;
            
        }
        private void recycleBinB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = recycleBinButton.Height;
            SidePanel.Top = recycleBinButton.Top;
            
        }
        private void audiosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = audiosButton.Height;
            SidePanel.Top = audiosButton.Top;
            
            AudiousForm af = new AudiousForm();
            af.StartPosition = FormStartPosition.CenterScreen;
            af.Show();
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

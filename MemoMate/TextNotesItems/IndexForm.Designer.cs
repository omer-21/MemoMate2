using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace NoteTaker
{
    partial class IndexForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newNoteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 12.5F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(140, 12);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(265, 35);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.GotFocus += new System.EventHandler(this.txtboxGFocus);
            this.textBoxSearch.LostFocus += new System.EventHandler(this.txtboxLFocus);
            //
            // clearSearchButton
            // 
            this.clearSearchButton.AutoEllipsis = true;
            this.clearSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.clearSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearSearchButton.ForeColor = System.Drawing.Color.White;
            this.clearSearchButton.Image = global::NoteTaker.Properties.Resources.icons8_clear_25;
            this.clearSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSearchButton.Location = new System.Drawing.Point(28, 12);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(107, 37);
            this.clearSearchButton.TabIndex = 2;
            this.clearSearchButton.Text = "      Clear";
            this.clearSearchButton.UseCompatibleTextRendering = true;
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clrSrchButtonButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 86);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(936, 495);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(757, 22);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(175, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "5/27/2023 9:58:45 PM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newNoteButton
            // 
            this.newNoteButton.AutoEllipsis = true;
            this.newNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.newNoteButton.FlatAppearance.BorderSize = 0;
            this.newNoteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.newNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newNoteButton.ForeColor = System.Drawing.Color.White;
            this.newNoteButton.Image = global::NoteTaker.Properties.Resources.icons8_note_24__1_;
            this.newNoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newNoteButton.Location = new System.Drawing.Point(583, 11);
            this.newNoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(156, 39);
            this.newNoteButton.TabIndex = 0;
            this.newNoteButton.Text = "     New Note";
            this.newNoteButton.UseCompatibleTextRendering = true;
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::NoteTaker.Properties.Resources.icons8_search_26;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(415, 12);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(136, 37);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "   Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IndexForm";
            this.Size = new System.Drawing.Size(980, 651);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxSearch;
        private Button searchButton;
        private Button newNoteButton;
        private Button clearSearchButton;
        private Label lblDate;

        private FlowLayoutPanel flowLayoutPanel1;
        private Timer timer1;
    }
}

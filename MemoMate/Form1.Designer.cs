using System.Windows.Forms;

namespace NoteTaker
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.active = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.childPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.recycleBinButton = new System.Windows.Forms.Button();
            this.audiosButton = new System.Windows.Forms.Button();
            this.alarmsButton = new System.Windows.Forms.Button();
            this.imagesButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.textNotsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.recycleBinButton);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.audiosButton);
            this.panel1.Controls.Add(this.alarmsButton);
            this.panel1.Controls.Add(this.imagesButton);
            this.panel1.Controls.Add(this.videosButton);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.textNotsButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 714);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(4, 672);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 42);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
            this.active.Location = new System.Drawing.Point(-1, 191);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(24, 69);
            this.active.TabIndex = 13;
            this.active.Visible = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Memo Mate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 12);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Multi Choice Note Taker";
            // 
            // childPanel
            // 
            this.childPanel.Location = new System.Drawing.Point(280, 66);
            this.childPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(1087, 640);
            this.childPanel.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = global::NoteTaker.Properties.Resources.icons8_off_24;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(1303, 23);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 43);
            this.closeButton.TabIndex = 4;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeB_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::NoteTaker.Properties.Resources.icons8_minus_24;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(1252, 24);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 43);
            this.button12.TabIndex = 4;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(1187, 23);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 43);
            this.button11.TabIndex = 4;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(1015, 25);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 42);
            this.button10.TabIndex = 4;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(959, 25);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 42);
            this.button9.TabIndex = 4;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(903, 25);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 42);
            this.button8.TabIndex = 4;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // recycleBinButton
            // 
            this.recycleBinButton.FlatAppearance.BorderSize = 0;
            this.recycleBinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recycleBinButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recycleBinButton.ForeColor = System.Drawing.Color.White;
            this.recycleBinButton.Image = ((System.Drawing.Image)(resources.GetObject("recycleBinButton.Image")));
            this.recycleBinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recycleBinButton.Location = new System.Drawing.Point(13, 494);
            this.recycleBinButton.Margin = new System.Windows.Forms.Padding(4);
            this.recycleBinButton.Name = "recycleBinButton";
            this.recycleBinButton.Size = new System.Drawing.Size(263, 66);
            this.recycleBinButton.TabIndex = 5;
            this.recycleBinButton.Text = "     Recycle Bin";
            this.recycleBinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recycleBinButton.UseVisualStyleBackColor = true;
            this.recycleBinButton.Click += new System.EventHandler(this.recycleBinB_Click);
            // 
            // audiosButton
            // 
            this.audiosButton.FlatAppearance.BorderSize = 0;
            this.audiosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audiosButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosButton.ForeColor = System.Drawing.Color.White;
            this.audiosButton.Image = ((System.Drawing.Image)(resources.GetObject("audiosButton.Image")));
            this.audiosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.audiosButton.Location = new System.Drawing.Point(13, 279);
            this.audiosButton.Margin = new System.Windows.Forms.Padding(4);
            this.audiosButton.Name = "audiosButton";
            this.audiosButton.Size = new System.Drawing.Size(263, 66);
            this.audiosButton.TabIndex = 4;
            this.audiosButton.Text = "        Audious";
            this.audiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.audiosButton.UseVisualStyleBackColor = true;
            this.audiosButton.Click += new System.EventHandler(this.audiosB_Click);
            // 
            // alarmsButton
            // 
            this.alarmsButton.FlatAppearance.BorderSize = 0;
            this.alarmsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmsButton.ForeColor = System.Drawing.Color.White;
            this.alarmsButton.Image = ((System.Drawing.Image)(resources.GetObject("alarmsButton.Image")));
            this.alarmsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alarmsButton.Location = new System.Drawing.Point(13, 425);
            this.alarmsButton.Margin = new System.Windows.Forms.Padding(4);
            this.alarmsButton.Name = "alarmsButton";
            this.alarmsButton.Size = new System.Drawing.Size(263, 66);
            this.alarmsButton.TabIndex = 4;
            this.alarmsButton.Text = "          Alarms";
            this.alarmsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alarmsButton.UseVisualStyleBackColor = true;
            this.alarmsButton.Click += new System.EventHandler(this.alarmsB_Click);
            // 
            // imagesButton
            // 
            this.imagesButton.FlatAppearance.BorderSize = 0;
            this.imagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesButton.ForeColor = System.Drawing.Color.White;
            this.imagesButton.Image = ((System.Drawing.Image)(resources.GetObject("imagesButton.Image")));
            this.imagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imagesButton.Location = new System.Drawing.Point(13, 351);
            this.imagesButton.Margin = new System.Windows.Forms.Padding(4);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(263, 70);
            this.imagesButton.TabIndex = 4;
            this.imagesButton.Text = "   Screenshots";
            this.imagesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imagesButton.UseVisualStyleBackColor = true;
            this.imagesButton.Click += new System.EventHandler(this.imagesB_Click);
            // 
            // videosButton
            // 
            this.videosButton.FlatAppearance.BorderSize = 0;
            this.videosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosButton.ForeColor = System.Drawing.Color.White;
            this.videosButton.Image = ((System.Drawing.Image)(resources.GetObject("videosButton.Image")));
            this.videosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videosButton.Location = new System.Drawing.Point(13, 209);
            this.videosButton.Margin = new System.Windows.Forms.Padding(4);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(263, 66);
            this.videosButton.TabIndex = 4;
            this.videosButton.Text = "        Videos";
            this.videosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.videosB_Click);
            // 
            // textNotsButton
            // 
            this.textNotsButton.FlatAppearance.BorderSize = 0;
            this.textNotsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textNotsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotsButton.ForeColor = System.Drawing.Color.White;
            this.textNotsButton.Image = ((System.Drawing.Image)(resources.GetObject("textNotsButton.Image")));
            this.textNotsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textNotsButton.Location = new System.Drawing.Point(16, 142);
            this.textNotsButton.Margin = new System.Windows.Forms.Padding(4);
            this.textNotsButton.Name = "textNotsButton";
            this.textNotsButton.Size = new System.Drawing.Size(263, 66);
            this.textNotsButton.TabIndex = 4;
            this.textNotsButton.Text = "       Text Notes";
            this.textNotsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.textNotsButton.UseVisualStyleBackColor = true;
            this.textNotsButton.Click += new System.EventHandler(this.textNotesB_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(13, 73);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(263, 66);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "        Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homepageB_Click);
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 714);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button alarmsButton;
        private System.Windows.Forms.Button textNotsButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button audiosButton;
        private System.Windows.Forms.Button imagesButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button recycleBinButton;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Panel active;
        private Panel childPanel;
        private Button button12;
    }
}


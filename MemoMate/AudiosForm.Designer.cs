namespace NoteTaker
{
    partial class AudiosForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxStopRec = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartRec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStopRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartRec)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn,
            this.DurationColumn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 372);
            this.dataGridView1.TabIndex = 19;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.HeaderText = "Name";
            this.FileNameColumn.MinimumWidth = 6;
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.Width = 125;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Record name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 17;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(406, 276);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(162, 46);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // PlayButton
            // 
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(406, 207);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(162, 46);
            this.PlayButton.TabIndex = 15;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click_1);
            // 
            // RecordButton
            // 
            this.RecordButton.FlatAppearance.BorderSize = 0;
            this.RecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordButton.Location = new System.Drawing.Point(406, 137);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(162, 46);
            this.RecordButton.TabIndex = 14;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click_1);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::NoteTaker.Properties.Resources.trash;
            this.pictureBoxDelete.Location = new System.Drawing.Point(575, 276);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(55, 46);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 24;
            this.pictureBoxDelete.TabStop = false;
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Image = global::NoteTaker.Properties.Resources.pause;
            this.pictureBoxPause.Location = new System.Drawing.Point(576, 207);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(55, 46);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPause.TabIndex = 23;
            this.pictureBoxPause.TabStop = false;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = global::NoteTaker.Properties.Resources.play_button;
            this.pictureBoxPlay.Location = new System.Drawing.Point(576, 207);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(54, 46);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlay.TabIndex = 22;
            this.pictureBoxPlay.TabStop = false;
            // 
            // pictureBoxStopRec
            // 
            this.pictureBoxStopRec.Image = global::NoteTaker.Properties.Resources.pause__1_;
            this.pictureBoxStopRec.Location = new System.Drawing.Point(575, 137);
            this.pictureBoxStopRec.Name = "pictureBoxStopRec";
            this.pictureBoxStopRec.Size = new System.Drawing.Size(55, 46);
            this.pictureBoxStopRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStopRec.TabIndex = 21;
            this.pictureBoxStopRec.TabStop = false;
            // 
            // pictureBoxStartRec
            // 
            this.pictureBoxStartRec.Image = global::NoteTaker.Properties.Resources.voice;
            this.pictureBoxStartRec.Location = new System.Drawing.Point(576, 137);
            this.pictureBoxStartRec.Name = "pictureBoxStartRec";
            this.pictureBoxStartRec.Size = new System.Drawing.Size(54, 46);
            this.pictureBoxStartRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartRec.TabIndex = 20;
            this.pictureBoxStartRec.TabStop = false;
            // 
            // AudiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxStopRec);
            this.Controls.Add(this.pictureBoxStartRec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.RecordButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AudiosForm";
            this.Size = new System.Drawing.Size(669, 422);
            this.Load += new System.EventHandler(this.AudiosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStopRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxStopRec;
        private System.Windows.Forms.PictureBox pictureBoxStartRec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button RecordButton;
    }
}


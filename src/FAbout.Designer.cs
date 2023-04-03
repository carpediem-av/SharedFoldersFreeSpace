namespace Common
{
    partial class FAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbout));
            pictureBox1 = new PictureBox();
            www = new LinkLabel();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = SharedFoldersFreeSpace.Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // www
            // 
            www.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            www.AutoSize = true;
            www.Location = new Point(12, 276);
            www.Name = "www";
            www.Size = new Size(125, 16);
            www.TabIndex = 1;
            www.TabStop = true;
            www.Text = "carpediem.0fees.us";
            www.LinkClicked += www_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.068965F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 254);
            label1.Name = "label1";
            label1.Size = new Size(397, 13);
            label1.TabIndex = 2;
            label1.Text = "Copyright (c) 2023 Carpe Diem Software Developing by Alex Versetty";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(14, 135);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(569, 102);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 303);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(www);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel www;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace NetShareFreeSpace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            submit = new Button();
            labelServer = new Label();
            tbServer = new TextBox();
            about = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(329, 45);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "Список папок";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 0;
            label3.Text = "     Свободно";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(248, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 0;
            label2.Text = "        Всего";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // submit
            // 
            submit.Location = new Point(84, 123);
            submit.Name = "submit";
            submit.Size = new Size(264, 31);
            submit.TabIndex = 3;
            submit.Text = "ОК";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(84, 52);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(178, 17);
            labelServer.TabIndex = 4;
            labelServer.Text = "Введите имя или IP сервера:";
            // 
            // tbServer
            // 
            tbServer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbServer.Location = new Point(84, 81);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(264, 25);
            tbServer.TabIndex = 5;
            // 
            // about
            // 
            about.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            about.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            about.Location = new Point(8, 210);
            about.Name = "about";
            about.Size = new Size(125, 23);
            about.TabIndex = 6;
            about.Text = "О программе...";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 241);
            Controls.Add(about);
            Controls.Add(tbServer);
            Controls.Add(labelServer);
            Controls.Add(submit);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button submit;
        private Label labelServer;
        private TextBox tbServer;
        private Button about;
    }
}
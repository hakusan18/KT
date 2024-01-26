namespace kt
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
            panel1 = new Panel();
            btnbctc = new Button();
            btndt = new Button();
            btnhd = new Button();
            btnbcdt = new Button();
            btnacc = new Button();
            thoat = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnbctc);
            panel1.Controls.Add(btndt);
            panel1.Controls.Add(btnhd);
            panel1.Controls.Add(btnbcdt);
            panel1.Controls.Add(btnacc);
            panel1.Controls.Add(thoat);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 41);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnbctc
            // 
            btnbctc.Location = new Point(306, 7);
            btnbctc.Name = "btnbctc";
            btnbctc.Size = new Size(75, 23);
            btnbctc.TabIndex = 9;
            btnbctc.Text = "bctc";
            btnbctc.UseVisualStyleBackColor = true;
            btnbctc.Click += btnbctc_Click;
            // 
            // btndt
            // 
            btndt.Location = new Point(749, 7);
            btndt.Name = "btndt";
            btndt.Size = new Size(75, 23);
            btndt.TabIndex = 8;
            btndt.Text = "DT";
            btndt.UseVisualStyleBackColor = true;
            btndt.Click += btndt_Click;
            // 
            // btnhd
            // 
            btnhd.Location = new Point(910, 7);
            btnhd.Name = "btnhd";
            btnhd.Size = new Size(75, 23);
            btnhd.TabIndex = 7;
            btnhd.Text = "HD";
            btnhd.UseVisualStyleBackColor = true;
            btnhd.Click += btnhd_Click;
            // 
            // btnbcdt
            // 
            btnbcdt.Location = new Point(516, 7);
            btnbcdt.Name = "btnbcdt";
            btnbcdt.Size = new Size(75, 23);
            btnbcdt.TabIndex = 6;
            btnbcdt.Text = "bcdt";
            btnbcdt.UseVisualStyleBackColor = true;
            btnbcdt.Click += btnbcdt_Click;
            // 
            // btnacc
            // 
            btnacc.Location = new Point(119, 7);
            btnacc.Name = "btnacc";
            btnacc.Size = new Size(75, 23);
            btnacc.TabIndex = 5;
            btnacc.Text = "accounting";
            btnacc.UseVisualStyleBackColor = true;
            btnacc.Click += btnacc_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(1094, 7);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 0;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 379);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button thoat;
        private Button btnbctc;
        private Button btndt;
        private Button btnhd;
        private Button btnbcdt;
        private Button btnacc;
    }
}

namespace kt2.clasas
{
    partial class frmacounting
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dataacc = new DataGridView();
            panel3 = new Panel();
            txtten = new TextBox();
            cboma = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataacc).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "accounting";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataacc);
            panel2.Location = new Point(14, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 452);
            panel2.TabIndex = 1;
            // 
            // dataacc
            // 
            dataacc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataacc.Location = new Point(3, 3);
            dataacc.Name = "dataacc";
            dataacc.Size = new Size(572, 449);
            dataacc.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtten);
            panel3.Controls.Add(cboma);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(621, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(553, 444);
            panel3.TabIndex = 1;
            // 
            // txtten
            // 
            txtten.Location = new Point(153, 44);
            txtten.Name = "txtten";
            txtten.Size = new Size(100, 23);
            txtten.TabIndex = 10;
            // 
            // cboma
            // 
            cboma.FormattingEnabled = true;
            cboma.Location = new Point(153, 12);
            cboma.Name = "cboma";
            cboma.Size = new Size(121, 23);
            cboma.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 281);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 8;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 208);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 7;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 244);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 176);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 141);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 115);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 85);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 52);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 20);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // frmacounting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 562);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmacounting";
            Text = "frmacounting";
            Load += frmacounting_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataacc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DataGridView dataacc;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtten;
        private ComboBox cboma;
    }
}
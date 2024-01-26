namespace kt2
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
            btnfile = new Button();
            btnvl = new Button();
            btnthoat = new Button();
            btnbctc = new Button();
            btnbcdt = new Button();
            btnncc = new Button();
            btnkh = new Button();
            btnacc = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnfile);
            panel1.Controls.Add(btnvl);
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(btnbctc);
            panel1.Controls.Add(btnbcdt);
            panel1.Controls.Add(btnncc);
            panel1.Controls.Add(btnkh);
            panel1.Controls.Add(btnacc);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 57);
            panel1.TabIndex = 0;
            // 
            // btnfile
            // 
            btnfile.Location = new Point(37, 14);
            btnfile.Name = "btnfile";
            btnfile.Size = new Size(75, 23);
            btnfile.TabIndex = 7;
            btnfile.Text = "File";
            btnfile.UseVisualStyleBackColor = true;
            btnfile.Click += btnfile_Click;
            // 
            // btnvl
            // 
            btnvl.Location = new Point(329, 14);
            btnvl.Name = "btnvl";
            btnvl.Size = new Size(75, 23);
            btnvl.TabIndex = 6;
            btnvl.Text = "Vật liệu";
            btnvl.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(964, 14);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnbctc
            // 
            btnbctc.Location = new Point(723, 14);
            btnbctc.Name = "btnbctc";
            btnbctc.Size = new Size(75, 23);
            btnbctc.TabIndex = 4;
            btnbctc.Text = "Báo cáo tài chính";
            btnbctc.UseVisualStyleBackColor = true;
            // 
            // btnbcdt
            // 
            btnbcdt.Location = new Point(858, 14);
            btnbcdt.Name = "btnbcdt";
            btnbcdt.Size = new Size(75, 23);
            btnbcdt.TabIndex = 3;
            btnbcdt.Text = "Báo cáo doanh thu";
            btnbcdt.UseVisualStyleBackColor = true;
            // 
            // btnncc
            // 
            btnncc.Location = new Point(585, 14);
            btnncc.Name = "btnncc";
            btnncc.Size = new Size(75, 23);
            btnncc.TabIndex = 2;
            btnncc.Text = "Nhà cung cấp";
            btnncc.UseVisualStyleBackColor = true;
            // 
            // btnkh
            // 
            btnkh.Location = new Point(456, 14);
            btnkh.Name = "btnkh";
            btnkh.Size = new Size(75, 23);
            btnkh.TabIndex = 1;
            btnkh.Text = "Khách hàng";
            btnkh.UseVisualStyleBackColor = true;
            // 
            // btnacc
            // 
            btnacc.Location = new Point(204, 14);
            btnacc.Name = "btnacc";
            btnacc.Size = new Size(75, 23);
            btnacc.TabIndex = 0;
            btnacc.Text = "accouting";
            btnacc.UseVisualStyleBackColor = true;
            btnacc.Click += btnacc_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 496);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1126, 467);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnvl;
        private Button btnthoat;
        private Button btnbctc;
        private Button btnbcdt;
        private Button btnncc;
        private Button btnkh;
        private Button btnacc;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnfile;
    }
}

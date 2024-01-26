namespace kt
{
    partial class bcdt
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
            panel4 = new Panel();
            dong = new Button();
            sua = new Button();
            xoa = new Button();
            timkiem = new Button();
            excel = new Button();
            them = new Button();
            panel3 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            cboxC = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            cboxb = new CheckBox();
            cboxkg = new CheckBox();
            theo = new Label();
            datebctc = new Label();
            panel2 = new Panel();
            databcdt = new DataGridView();
            panel1 = new Panel();
            bctc1 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databcdt).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(dong);
            panel4.Controls.Add(sua);
            panel4.Controls.Add(xoa);
            panel4.Controls.Add(timkiem);
            panel4.Controls.Add(excel);
            panel4.Controls.Add(them);
            panel4.Location = new Point(593, 355);
            panel4.Name = "panel4";
            panel4.Size = new Size(571, 54);
            panel4.TabIndex = 16;
            // 
            // dong
            // 
            dong.Location = new Point(483, 13);
            dong.Name = "dong";
            dong.Size = new Size(75, 23);
            dong.TabIndex = 5;
            dong.Text = "Đóng";
            dong.UseVisualStyleBackColor = true;
            dong.Click += dong_Click;
            // 
            // sua
            // 
            sua.Location = new Point(98, 13);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 4;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            xoa.Location = new Point(195, 13);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 3;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(387, 13);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 2;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            // 
            // excel
            // 
            excel.Location = new Point(290, 13);
            excel.Name = "excel";
            excel.Size = new Size(75, 23);
            excel.TabIndex = 1;
            excel.Text = "Excel";
            excel.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            them.Location = new Point(3, 13);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 0;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cboxC);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(cboxb);
            panel3.Controls.Add(cboxkg);
            panel3.Controls.Add(theo);
            panel3.Controls.Add(datebctc);
            panel3.Location = new Point(611, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 272);
            panel3.TabIndex = 15;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 134);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 23;
            label2.Text = "Theo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 101);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 21;
            label1.Text = "DN";
            // 
            // cboxC
            // 
            cboxC.AutoSize = true;
            cboxC.Location = new Point(313, 58);
            cboxC.Name = "cboxC";
            cboxC.Size = new Size(52, 19);
            cboxC.TabIndex = 20;
            cboxC.Text = "Năm";
            cboxC.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(177, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // cboxb
            // 
            cboxb.AutoSize = true;
            cboxb.Location = new Point(244, 58);
            cboxb.Name = "cboxb";
            cboxb.Size = new Size(48, 19);
            cboxb.TabIndex = 11;
            cboxb.Text = "Quý";
            cboxb.UseVisualStyleBackColor = true;
            // 
            // cboxkg
            // 
            cboxkg.AutoSize = true;
            cboxkg.Location = new Point(177, 58);
            cboxkg.Name = "cboxkg";
            cboxkg.Size = new Size(52, 19);
            cboxkg.TabIndex = 10;
            cboxkg.Text = "Tuần";
            cboxkg.UseVisualStyleBackColor = true;
            // 
            // theo
            // 
            theo.AutoSize = true;
            theo.Location = new Point(34, 58);
            theo.Name = "theo";
            theo.Size = new Size(33, 15);
            theo.TabIndex = 4;
            theo.Text = "Theo";
            // 
            // datebctc
            // 
            datebctc.AutoSize = true;
            datebctc.Location = new Point(34, 20);
            datebctc.Name = "datebctc";
            datebctc.Size = new Size(38, 15);
            datebctc.TabIndex = 3;
            datebctc.Text = "Ngày ";
            // 
            // panel2
            // 
            panel2.Controls.Add(databcdt);
            panel2.Location = new Point(2, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 357);
            panel2.TabIndex = 14;
            // 
            // databcdt
            // 
            databcdt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databcdt.Location = new Point(14, 20);
            databcdt.Name = "databcdt";
            databcdt.Size = new Size(549, 319);
            databcdt.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(bctc1);
            panel1.Location = new Point(25, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 37);
            panel1.TabIndex = 13;
            // 
            // bctc1
            // 
            bctc1.AutoSize = true;
            bctc1.Location = new Point(510, 11);
            bctc1.Name = "bctc1";
            bctc1.Size = new Size(107, 15);
            bctc1.TabIndex = 0;
            bctc1.Text = "Báo cáo doanh thu";
            // 
            // bcdt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 642);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "bcdt";
            Text = "bcdt";
            Load += bcdt_Load;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databcdt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button dong;
        private Button sua;
        private Button xoa;
        private Button timkiem;
        private Button excel;
        private Button them;
        private Panel panel3;
        private CheckBox cboxC;
        private DateTimePicker dateTimePicker1;
        private CheckBox cboxb;
        private CheckBox cboxkg;
        private TextBox tenvl1;
        private Label theo;
        private Label datebctc;
        private Label dvt;
        private Label tenvl;
        private Panel panel2;
        private DataGridView databcdt;
        private Panel panel1;
        private Label bctc1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
    }
}
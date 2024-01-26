namespace kt
{
    partial class kh
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
            khachhang = new Label();
            datakh = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            sdt1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            cboxnu = new CheckBox();
            cboxnam = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            ghichu = new Label();
            stk = new Label();
            nsinh = new Label();
            sex = new Label();
            tenkh = new Label();
            makh = new Label();
            panel4 = new Panel();
            dong = new Button();
            sua = new Button();
            xoa = new Button();
            timkiem = new Button();
            excel = new Button();
            them = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datakh).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(khachhang);
            panel1.Location = new Point(71, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 37);
            panel1.TabIndex = 0;
            // 
            // khachhang
            // 
            khachhang.AutoSize = true;
            khachhang.Location = new Point(523, 11);
            khachhang.Name = "khachhang";
            khachhang.Size = new Size(70, 15);
            khachhang.TabIndex = 0;
            khachhang.Text = "Khách hàng";
            khachhang.Click += label1_Click;
            // 
            // datakh
            // 
            datakh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datakh.Location = new Point(8, 13);
            datakh.Name = "datakh";
            datakh.Size = new Size(544, 334);
            datakh.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(datakh);
            panel2.Location = new Point(4, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 357);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(sdt1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(cboxnu);
            panel3.Controls.Add(cboxnam);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(ghichu);
            panel3.Controls.Add(stk);
            panel3.Controls.Add(nsinh);
            panel3.Controls.Add(sex);
            panel3.Controls.Add(tenkh);
            panel3.Controls.Add(makh);
            panel3.Location = new Point(616, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 278);
            panel3.TabIndex = 3;
            // 
            // sdt1
            // 
            sdt1.Location = new Point(179, 145);
            sdt1.Name = "sdt1";
            sdt1.Size = new Size(100, 23);
            sdt1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // cboxnu
            // 
            cboxnu.AutoSize = true;
            cboxnu.Location = new Point(252, 80);
            cboxnu.Name = "cboxnu";
            cboxnu.Size = new Size(42, 19);
            cboxnu.TabIndex = 11;
            cboxnu.Text = "Nữ";
            cboxnu.UseVisualStyleBackColor = true;
            // 
            // cboxnam
            // 
            cboxnam.AutoSize = true;
            cboxnam.Location = new Point(179, 80);
            cboxnam.Name = "cboxnam";
            cboxnam.Size = new Size(52, 19);
            cboxnam.TabIndex = 10;
            cboxnam.Text = "Nam";
            cboxnam.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 212);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // ghichu
            // 
            ghichu.AutoSize = true;
            ghichu.Location = new Point(34, 180);
            ghichu.Name = "ghichu";
            ghichu.Size = new Size(48, 15);
            ghichu.TabIndex = 5;
            ghichu.Text = "Ghi chú";
            // 
            // stk
            // 
            stk.AutoSize = true;
            stk.Location = new Point(34, 148);
            stk.Name = "stk";
            stk.Size = new Size(26, 15);
            stk.TabIndex = 4;
            stk.Text = "STK";
            stk.Click += label5_Click;
            // 
            // nsinh
            // 
            nsinh.AutoSize = true;
            nsinh.Location = new Point(34, 115);
            nsinh.Name = "nsinh";
            nsinh.Size = new Size(60, 15);
            nsinh.TabIndex = 3;
            nsinh.Text = "Ngày sinh";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Location = new Point(34, 80);
            sex.Name = "sex";
            sex.Size = new Size(52, 15);
            sex.TabIndex = 2;
            sex.Text = "Giới tính";
            // 
            // tenkh
            // 
            tenkh.AutoSize = true;
            tenkh.Location = new Point(34, 50);
            tenkh.Name = "tenkh";
            tenkh.Size = new Size(90, 15);
            tenkh.TabIndex = 1;
            tenkh.Text = "Tên khách hàng";
            // 
            // makh
            // 
            makh.AutoSize = true;
            makh.Location = new Point(34, 24);
            makh.Name = "makh";
            makh.Size = new Size(43, 15);
            makh.TabIndex = 0;
            makh.Text = "Mã KH";
            // 
            // panel4
            // 
            panel4.Controls.Add(dong);
            panel4.Controls.Add(sua);
            panel4.Controls.Add(xoa);
            panel4.Controls.Add(timkiem);
            panel4.Controls.Add(excel);
            panel4.Controls.Add(them);
            panel4.Location = new Point(616, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(594, 54);
            panel4.TabIndex = 4;
            // 
            // dong
            // 
            dong.Location = new Point(506, 13);
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
            xoa.Location = new Point(198, 13);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 3;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(407, 13);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 2;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            // 
            // excel
            // 
            excel.Location = new Point(298, 13);
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
            // kh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 414);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "kh";
            Text = "kh";
            Load += kh_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datakh).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label khachhang;
        private DataGridView datakh;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button sua;
        private Button xoa;
        private Button timkiem;
        private Button excel;
        private Button them;
        private Button dong;
        private Label label7;
        private Label ghichu;
        private Label stk;
        private Label nsinh;
        private Label sex;
        private Label tenkh;
        private Label makh;
        private DateTimePicker dateTimePicker1;
        private CheckBox cboxnu;
        private CheckBox cboxnam;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox sdt1;
    }
}
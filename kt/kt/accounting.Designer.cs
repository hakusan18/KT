namespace kt
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    partial class accounting
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
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
            dataACC = new DataGridView();
            panel2 = new Panel();
            tkiem = new Button();
            Excel = new Button();
            Dong = new Button();
            Xoa = new Button();
            Sua = new Button();
            Them = new Button();
            tenncc1 = new Panel();
            tk1 = new MaskedTextBox();
            email1 = new TextBox();
            sdt1 = new MaskedTextBox();
            diachi1 = new TextBox();
            tennccc = new TextBox();
            tk = new Label();
            email = new Label();
            sdt = new Label();
            cboquan = new ComboBox();
            cbohuyen = new ComboBox();
            cbotp = new ComboBox();
            dateNCC = new DateTimePicker();
            cbomacc = new ComboBox();
            diachi = new Label();
            ngay = new Label();
            Tenncc = new Label();
            mancc = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataACC).BeginInit();
            panel2.SuspendLayout();
            tenncc1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataACC);
            panel1.Location = new Point(18, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 402);
            panel1.TabIndex = 0;
            // 
            // dataACC
            // 
            dataACC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataACC.Location = new Point(21, 21);
            dataACC.Name = "dataACC";
            dataACC.Size = new Size(563, 363);
            dataACC.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tkiem);
            panel2.Controls.Add(Excel);
            panel2.Controls.Add(Dong);
            panel2.Controls.Add(Xoa);
            panel2.Controls.Add(Sua);
            panel2.Controls.Add(Them);
            panel2.Location = new Point(644, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 57);
            panel2.TabIndex = 1;
            // 
            // tkiem
            // 
            tkiem.Location = new Point(288, 30);
            tkiem.Name = "tkiem";
            tkiem.Size = new Size(75, 23);
            tkiem.TabIndex = 5;
            tkiem.Text = "Tìm kiếm";
            tkiem.UseVisualStyleBackColor = true;
            // 
            // Excel
            // 
            Excel.Location = new Point(388, 30);
            Excel.Name = "Excel";
            Excel.Size = new Size(75, 23);
            Excel.TabIndex = 4;
            Excel.Text = "Excel";
            Excel.UseVisualStyleBackColor = true;
            Excel.Click += button1_Click;
            // 
            // Dong
            // 
            Dong.Location = new Point(484, 30);
            Dong.Name = "Dong";
            Dong.Size = new Size(75, 23);
            Dong.TabIndex = 3;
            Dong.Text = "Đóng";
            Dong.UseVisualStyleBackColor = true;
            Dong.Click += Dong_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(192, 30);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(75, 23);
            Xoa.TabIndex = 2;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            Sua.Location = new Point(96, 30);
            Sua.Name = "Sua";
            Sua.Size = new Size(75, 23);
            Sua.TabIndex = 1;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // Them
            // 
            Them.Location = new Point(3, 30);
            Them.Name = "Them";
            Them.Size = new Size(75, 23);
            Them.TabIndex = 0;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // tenncc1
            // 
            tenncc1.Controls.Add(tk1);
            tenncc1.Controls.Add(email1);
            tenncc1.Controls.Add(sdt1);
            tenncc1.Controls.Add(diachi1);
            tenncc1.Controls.Add(tennccc);
            tenncc1.Controls.Add(tk);
            tenncc1.Controls.Add(email);
            tenncc1.Controls.Add(sdt);
            tenncc1.Controls.Add(cboquan);
            tenncc1.Controls.Add(cbohuyen);
            tenncc1.Controls.Add(cbotp);
            tenncc1.Controls.Add(dateNCC);
            tenncc1.Controls.Add(cbomacc);
            tenncc1.Controls.Add(diachi);
            tenncc1.Controls.Add(ngay);
            tenncc1.Controls.Add(Tenncc);
            tenncc1.Controls.Add(mancc);
            tenncc1.Location = new Point(644, 26);
            tenncc1.Name = "tenncc1";
            tenncc1.Size = new Size(559, 316);
            tenncc1.TabIndex = 2;
            // 
            // tk1
            // 
            tk1.Location = new Point(419, 84);
            tk1.Name = "tk1";
            tk1.Size = new Size(100, 23);
            tk1.TabIndex = 19;
            // 
            // email1
            // 
            email1.Location = new Point(419, 52);
            email1.Name = "email1";
            email1.Size = new Size(100, 23);
            email1.TabIndex = 18;
            // 
            // sdt1
            // 
            sdt1.Location = new Point(419, 20);
            sdt1.Name = "sdt1";
            sdt1.Size = new Size(100, 23);
            sdt1.TabIndex = 17;
            // 
            // diachi1
            // 
            diachi1.ForeColor = SystemColors.ScrollBar;
            diachi1.Location = new Point(127, 109);
            diachi1.Name = "diachi1";
            diachi1.Size = new Size(100, 23);
            diachi1.TabIndex = 16;
            diachi1.Text = "Số nhà, đường";
            // 
            // tennccc
            // 
            tennccc.Location = new Point(127, 49);
            tennccc.Name = "tennccc";
            tennccc.Size = new Size(100, 23);
            tennccc.TabIndex = 15;
            tennccc.TextChanged += textBox1_TextChanged;
            // 
            // tk
            // 
            tk.AutoSize = true;
            tk.Location = new Point(360, 89);
            tk.Name = "tk";
            tk.Size = new Size(58, 15);
            tk.TabIndex = 14;
            tk.Text = "Tài Khoản";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(360, 60);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 13;
            email.Text = "Email";
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(360, 28);
            sdt.Name = "sdt";
            sdt.Size = new Size(26, 15);
            sdt.TabIndex = 12;
            sdt.Text = "SDT";
            // 
            // cboquan
            // 
            cboquan.ForeColor = SystemColors.ScrollBar;
            cboquan.FormattingEnabled = true;
            cboquan.Location = new Point(127, 139);
            cboquan.Name = "cboquan";
            cboquan.RightToLeft = RightToLeft.No;
            cboquan.Size = new Size(121, 23);
            cboquan.TabIndex = 11;
            cboquan.Text = "Quận";
            cboquan.UseWaitCursor = true;
            // 
            // cbohuyen
            // 
            cbohuyen.ForeColor = SystemColors.ScrollBar;
            cbohuyen.FormattingEnabled = true;
            cbohuyen.Location = new Point(127, 168);
            cbohuyen.Name = "cbohuyen";
            cbohuyen.Size = new Size(121, 23);
            cbohuyen.TabIndex = 10;
            cbohuyen.Text = "Huyện";
            // 
            // cbotp
            // 
            cbotp.ForeColor = SystemColors.ScrollBar;
            cbotp.FormattingEnabled = true;
            cbotp.Location = new Point(127, 197);
            cbotp.Name = "cbotp";
            cbotp.Size = new Size(121, 23);
            cbotp.TabIndex = 9;
            cbotp.Text = "Thành Phố";
            cbotp.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateNCC
            // 
            dateNCC.Location = new Point(127, 81);
            dateNCC.Name = "dateNCC";
            dateNCC.Size = new Size(200, 23);
            dateNCC.TabIndex = 7;
            // 
            // cbomacc
            // 
            cbomacc.FormattingEnabled = true;
            cbomacc.Location = new Point(127, 20);
            cbomacc.Name = "cbomacc";
            cbomacc.Size = new Size(121, 23);
            cbomacc.TabIndex = 4;
            // 
            // diachi
            // 
            diachi.AutoSize = true;
            diachi.Location = new Point(28, 117);
            diachi.Name = "diachi";
            diachi.Size = new Size(42, 15);
            diachi.TabIndex = 3;
            diachi.Text = "DiaChi";
            // 
            // ngay
            // 
            ngay.AutoSize = true;
            ngay.Location = new Point(28, 82);
            ngay.Name = "ngay";
            ngay.Size = new Size(35, 15);
            ngay.TabIndex = 2;
            ngay.Text = "Ngay";
            ngay.Click += label2_Click;
            // 
            // Tenncc
            // 
            Tenncc.AutoSize = true;
            Tenncc.Location = new Point(28, 52);
            Tenncc.Name = "Tenncc";
            Tenncc.Size = new Size(50, 15);
            Tenncc.TabIndex = 1;
            Tenncc.Text = "TenNCC";
            // 
            // mancc
            // 
            mancc.AutoSize = true;
            mancc.Location = new Point(28, 22);
            mancc.Name = "mancc";
            mancc.Size = new Size(49, 15);
            mancc.TabIndex = 0;
            mancc.Text = "MaNCC";
            // 
            // accounting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 450);
            Controls.Add(tenncc1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "accounting";
            Text = "accounting";
            Load += accounting_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataACC).EndInit();
            panel2.ResumeLayout(false);
            tenncc1.ResumeLayout(false);
            tenncc1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Dong;
        private Button Xoa;
        private Button Sua;
        private Button Them;
        private Panel tenncc1;
        private Button Excel;
        private DataGridView dataACC;
        private Label ngay;
        private Label Tenncc;
        private Label mancc;
        private ComboBox cbomacc;
        private Label diachi;
        private DateTimePicker dateNCC;
        private ComboBox cboquan;
        private ComboBox cbohuyen;
        private ComboBox cbotp;
        private Label sdt;
        private Label tk;
        private Label email;
        private TextBox diachi1;
        private TextBox tennccc;
        private MaskedTextBox tk1;
        private TextBox email1;
        private MaskedTextBox sdt1;
        private Button tkiem;
    }
}
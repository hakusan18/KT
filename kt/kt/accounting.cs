using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kt
{
    public partial class accounting : Form
    {
        public accounting()
        {
            InitializeComponent();
        }

        private void accounting_Load(object sender, EventArgs e)
        {
            cbomacc.Items.Clear();
            Xoa.Enabled = true;
            Dong.Enabled = true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (cbomacc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomacc = null;
                return;
            }
            if (tennccc.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tennccc = null;
                return;
            }
            if (sdt1.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                sdt1 = null;
                return;
            }
            if (email1.Text == "")
            {
                MessageBox.Show("Chưa nhập email", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                email1 = null;
                return;
            }
            if (tk1.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản ngân hàng", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tk1 = null;
                return;
            }
            cbomacc.Text = "";
            Xoa.Enabled = true;
            Dong.Enabled = true;
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (cbomacc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomacc = null;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

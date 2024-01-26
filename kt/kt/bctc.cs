using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt
{
    public partial class bctc : Form
    {
        public bctc()
        {
            InitializeComponent();
        }

        private void bctc_Load(object sender, EventArgs e)
        {
            thoat.Enabled = true;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

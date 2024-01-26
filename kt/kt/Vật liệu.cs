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
    public partial class Vật_liệu : Form
    {
        public Vật_liệu()
        {
            InitializeComponent();
        }

        private void bctc1_Click(object sender, EventArgs e)
        {
            dong.Enabled = false;
        }

        private void dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

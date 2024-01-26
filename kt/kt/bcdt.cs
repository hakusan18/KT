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
    public partial class bcdt : Form
    {
        public bcdt()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bcdt_Load(object sender, EventArgs e)
        {
            dong.Enabled = true;
        }
    }
}

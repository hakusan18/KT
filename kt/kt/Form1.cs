namespace kt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thoat.Enabled = true;
        }

        private void btnacc_Click(object sender, EventArgs e)
        {
            accounting frmaccounting = new accounting();
            frmaccounting.Show();
        }

        private void btnbctc_Click(object sender, EventArgs e)
        {
            bctc frmbctc = new bctc();
            frmbctc.Show();
        }
        private void btnbcdt_Click(object sender, EventArgs e)
        {
            bcdt frmbcdt = new bcdt();
            frmbcdt.Show();
        }

        private void btndt_Click(object sender, EventArgs e)
        {
            //dt frmdt = new dt();
            //frmdt.Show();
        }

        private void btnhd_Click(object sender, EventArgs e)
        {
            hopdong frmhopdong = new hopdong();
            frmhopdong.Show();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

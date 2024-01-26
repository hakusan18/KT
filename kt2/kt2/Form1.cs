namespace kt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnthoat.Enabled = true;
        }

        private void btnfile_Click(object sender, EventArgs e)
        {

        }

        private void btnacc_Click(object sender, EventArgs e)
        {
            forms.accounting frmaccounting = new forms.accounting();
            frmaccounting.Show();
        }
    }
}

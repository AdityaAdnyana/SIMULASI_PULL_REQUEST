namespace tpModul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            tbOutput.Text = "Halo " + nama;
            tbNama.Clear();
            tbNama.SelectedText = "masukan nama anda";
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, bilet, su, toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblToplam.Text = toplam.ToString() + "TL";

            tutar = tutar + toplam;

            lblKasa.Text = tutar.ToString() + "TL";

        }

        private void lblKasa_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtSu.Text = "";
            txtMisir.Text = "";


        }
    }
}
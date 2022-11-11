namespace UserForms
{
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {
            if (txtNick.Text=="") {
                MessageBox.Show("NickName girilmeden hesap olusturulamaz.");
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("isim girilmeden hesap olusturulamaz.");
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyisim girilmeden hesap olusturulamaz.");
            }
        }

      
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("E-meil  girilmeden hesap olusturulamaz.");
            }
        }

        private void txtEmailTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailTekrar !=txtEmail) {
                MessageBox.Show("girmis oldugunuz E-mail adresi uyusmuyor!!!");
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length<=8) {
                MessageBox.Show("girmis oldugunuz sifre 8 karakterden k�c�k!!!");
            }
        }

        private void txt�zelCevap_TextChanged(object sender, EventArgs e)
        {
            if (txt�zelCevap.Text=="") {
                MessageBox.Show("L�tfen �zel sorunuzun cevabini olusturun!!!");
            }
        }
    } 
}
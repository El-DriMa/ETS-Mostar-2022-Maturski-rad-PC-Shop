using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSHOPFINAL.OstaleForme;
using PCSHOPFINAL.KategorijePrikaz;
using PCShop_servis;
using PCShop_servis.Data;
using PCSHOPFINAL;

namespace PCSHOPFINAL.OstaleForme
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            zaposlenici zaposlenik = new zaposlenici();
            zaposlenik = DAZaposlenici.getLogin(txtime.Text, txtLozinka.Text);
            if (zaposlenik != null)
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Pogrešni podaci", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

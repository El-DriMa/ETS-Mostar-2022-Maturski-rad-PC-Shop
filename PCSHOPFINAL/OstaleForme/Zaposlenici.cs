using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop_servis.Data;
using PCShop_servis;

namespace PCSHOPFINAL.OstaleForme
{
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            dgZaposlenici.AutoGenerateColumns = false;
            ucitajGrid();
            ucitajGrad();
        }

        private void ucitajGrad()
        {
            cmbxGrad.DataSource = DAZaposlenici.gradCmbx();
            cmbxGrad.DisplayMember = "naziv";
            cmbxGrad.ValueMember = "gradID";
        }

        private void ucitajGrid()
        {
            dgZaposlenici.DataSource = DAZaposlenici.prikazZaposlenika();
        }

       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            zaposlenici zaposlenik = new zaposlenici();
            zaposlenik.ime = txtIme.Text;
            zaposlenik.prezime = txtPrezime.Text;
            zaposlenik.datumRodjenja = dtpDatum.Value;
            zaposlenik.adresaID = Convert.ToInt32(cmbxGrad.SelectedValue);
            zaposlenik.korisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.lozinka = txtLozinka.Text;
            zaposlenik.brojTelefona = txtBrTelefona.Text;
            zaposlenik.mail = txtMail.Text;
            DAZaposlenici.insertZaposlenika(zaposlenik);
            ucitajGrid();
            ocistiFormu();

        }

        private void ocistiFormu()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            dtpDatum.Value =DateTime.Now;
            cmbxGrad.SelectedIndex = 0;
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            txtBrTelefona.Text = "";
            txtMail.Text = "";
        }
        zaposlenici zaposlenik = new zaposlenici();
        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (dgZaposlenici.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
                zaposlenik = DAZaposlenici.zaposleniciByID(id);
                ucitajPodatke();
            }

        }

        private void ucitajPodatke()
        {

            txtIme.Text = zaposlenik.ime;
            txtPrezime.Text = zaposlenik.prezime;
            dtpDatum.Value =Convert.ToDateTime(zaposlenik.datumRodjenja);
            txtKorisnickoIme.Text = zaposlenik.korisnickoIme;
            txtLozinka.Text = zaposlenik.lozinka;
            txtBrTelefona.Text = zaposlenik.brojTelefona;
            txtMail.Text = zaposlenik.mail;
            cmbxGrad.SelectedValue = zaposlenik.adresaID;

        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            zaposlenik.ime = txtIme.Text;
            zaposlenik.prezime = txtPrezime.Text;
            zaposlenik.datumRodjenja = dtpDatum.Value;
            zaposlenik.adresaID = Convert.ToInt32(cmbxGrad.SelectedValue);
            zaposlenik.korisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.lozinka = txtLozinka.Text;
            zaposlenik.brojTelefona = txtBrTelefona.Text;
            zaposlenik.mail = txtMail.Text;
            DAZaposlenici.updateZaposlenika(zaposlenik);
            ucitajGrid();
            ocistiFormu();
            zaposlenik = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgZaposlenici.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
                DAZaposlenici.deleteZaposlenika(id);
                MessageBox.Show("Zaposlenik je uspješno obrisan.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucitajGrid();
            }
            else
                MessageBox.Show("Ne postoje podaci za brisanje.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
    }


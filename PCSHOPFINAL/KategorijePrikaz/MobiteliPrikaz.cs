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

namespace PCSHOPFINAL.KategorijePrikaz
{
    public partial class MobiteliPrikaz : Form
    {
        public MobiteliPrikaz()
        {
            InitializeComponent();
        }

        private void MobiteliPrikaz_Load(object sender, EventArgs e)
        {
            dgMobiteli.DataSource = KategorijeProizvodaDA.prikazMobitelaGrid();
            ucitajProizvodjace();
        }
        private void ucitajProizvodjace()
        {
            cmbxProizvodjac.DataSource = DAProizvodjaci.proizvodjaciCmbx();
            cmbxProizvodjac.DisplayMember = "naziv";
            cmbxProizvodjac.ValueMember = "proizvodjaciID";
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if (txtPretraga.Text.Trim() != "")
            {
                dgMobiteli.DataSource = PretrageDA.pretragaPoNazivuMobiteli(txtPretraga.Text);
            }
            else
            {
                dgMobiteli.DataSource = KategorijeProizvodaDA.prikazMobitelaGrid();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            proizvodi proizvod = new proizvodi();
            proizvod.naziv = txtNaziv.Text;
            proizvod.opis = txtOpis.Text;
            proizvod.cijena = Convert.ToDecimal(txtCijena.Text);
            proizvod.kolicina = Convert.ToInt32(txtKolicina.Text);
            proizvod.proizvodjacID = Convert.ToInt32(cmbxProizvodjac.SelectedValue);
            proizvod.kategorijaID = 8;
            proizvod.sifra = txtSifra.Text;
            DAProizvodii.insertProizvoda(proizvod);
            ocistiFormu();
            dgMobiteli.DataSource = KategorijeProizvodaDA.prikazMobitelaGrid();

        }

        private void ocistiFormu()
        {
            txtCijena.Text = "";
            txtKolicina.Text = "";
            txtNaziv.Text = "";
            txtOpis.Text = "";
            txtSifra.Text = "";
            cmbxProizvodjac.SelectedIndex = 0;

        }

        proizvodi proizvod = new proizvodi();

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (dgMobiteli.Rows.Count != 0)
            {
                int proizvodID = Convert.ToInt32(dgMobiteli.SelectedRows[0].Cells[0].Value);
                proizvod = DAProizvodii.proizvodiByID(proizvodID);
                ucitajPodatke();
            }
        }

        private void ucitajPodatke()
        {
            txtNaziv.Text = proizvod.naziv;
            txtCijena.Text = proizvod.cijena.ToString();
            txtKolicina.Text = proizvod.kolicina.ToString();
            txtOpis.Text = proizvod.opis;
            txtSifra.Text = proizvod.sifra;
            cmbxProizvodjac.SelectedValue = proizvod.proizvodjacID;
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            proizvod.naziv = txtNaziv.Text;
            proizvod.opis = txtOpis.Text;
            proizvod.cijena = Convert.ToDecimal(txtCijena.Text);
            proizvod.kolicina = Convert.ToInt32(txtKolicina.Text);
            proizvod.proizvodjacID = Convert.ToInt32(cmbxProizvodjac.SelectedValue);
            proizvod.kategorijaID = 8;
            proizvod.sifra = txtSifra.Text;
            DAProizvodii.updateProizvoda(proizvod);

            dgMobiteli.DataSource = KategorijeProizvodaDA.prikazMobitelaGrid();
            ocistiFormu();
            proizvod = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgMobiteli.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dgMobiteli.SelectedRows[0].Cells[0].Value.ToString());
                DAProizvodii.deleteProizvoda(id);
                MessageBox.Show("Proizvod je uspješno obrisan.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgMobiteli.DataSource = KategorijeProizvodaDA.prikazMobitelaGrid();
            }
            else
                MessageBox.Show("Ne postoje podaci za brisanje.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}


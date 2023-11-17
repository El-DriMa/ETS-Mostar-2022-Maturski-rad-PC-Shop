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
    public partial class ProcesoriPrikaz : Form
    {
        public ProcesoriPrikaz()
        {
            InitializeComponent();
        }

        private void ProcesoriPrikaz_Load(object sender, EventArgs e)
        {
            dgProcesori.DataSource = KategorijeProizvodaDA.prikazProcesoraGrid();
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
                dgProcesori.DataSource = PretrageDA.pretragaPoNazivuProcesori(txtPretraga.Text);
            }
            else
            {
                dgProcesori.DataSource = KategorijeProizvodaDA.prikazProcesoraGrid();
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
            proizvod.kategorijaID = 14;
            proizvod.sifra = txtSifra.Text;
            DAProizvodii.insertProizvoda(proizvod);
            ocistiFormu();
            dgProcesori.DataSource = KategorijeProizvodaDA.prikazProcesoraGrid();

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
            if (dgProcesori.Rows.Count != 0)
            {
                int proizvodID = Convert.ToInt32(dgProcesori.SelectedRows[0].Cells[0].Value);
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
            proizvod.kategorijaID = 14;
            proizvod.sifra = txtSifra.Text;
            DAProizvodii.updateProizvoda(proizvod);

            dgProcesori.DataSource = KategorijeProizvodaDA.prikazProcesoraGrid();
            ocistiFormu();
            proizvod = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgProcesori.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dgProcesori.SelectedRows[0].Cells[0].Value.ToString());
                DAProizvodii.deleteProizvoda(id);
                MessageBox.Show("Proizvod je uspješno obrisan.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgProcesori.DataSource = KategorijeProizvodaDA.prikazProcesoraGrid();
            }
            else
                MessageBox.Show("Ne postoje podaci za brisanje.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
    }


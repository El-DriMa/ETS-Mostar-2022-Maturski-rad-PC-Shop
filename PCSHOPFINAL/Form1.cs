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
using PCSHOPFINAL.KategorijePrikaz;
using PCSHOPFINAL.OstaleForme;


namespace PCSHOPFINAL
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sviracunariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RacunariPrikaz frm = new RacunariPrikaz();
            frm.Show();
        }

        private void rAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAMPrikaz frm = new RAMPrikaz();
            frm.Show();
        }

        private void monitoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitoriPrikaz frm = new MonitoriPrikaz();
            frm.Show();
        }

        private void tastatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TastaturePrikaz frm = new TastaturePrikaz();
            frm.Show();
        }

        private void miševiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiseviPrikaz frm = new MiseviPrikaz();
            frm.Show();
        }

        private void zvučniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZvucniciPrikaz frm = new ZvucniciPrikaz();
            frm.Show();
        }

        private void mikrofoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MikrofoniPrikaz frm = new MikrofoniPrikaz();
            frm.Show();
        }

        private void slušsaliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlusalicePrikaz frm = new SlusalicePrikaz();
            frm.Show();
        }

        private void matičnePločeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaticnePrikaz frm = new MaticnePrikaz();
            frm.Show();
        }

        private void grafičkeKarticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrafickePrikaz frm = new GrafickePrikaz();
            frm.Show();
        }

        private void cPUCooleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPUCooleriPrikaz frm = new CPUCooleriPrikaz();
            frm.Show();
        }

        private void procesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesoriPrikaz frm = new ProcesoriPrikaz();
            frm.Show();
        }

        private void hDDSSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDDSSDPrikaz frm = new HDDSSDPrikaz();
            frm.Show();
        }

        private void kućištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KucistaPrikaz frm = new KucistaPrikaz();
            frm.Show();
        }

        private void napojneJediniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NapojnePrikaz frm = new NapojnePrikaz();
            frm.Show();
        }

        private void kabloviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KabloviPrikaz frm = new KabloviPrikaz();
            frm.Show();
        }

        private void mobiteliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MobiteliPrikaz frm = new MobiteliPrikaz();
            frm.Show();
        }

        private void televizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelevizoriPrikaz frm = new TelevizoriPrikaz();
            frm.Show();
        }

        private void informacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ONamaForma frm = new ONamaForma();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.AntiqueWhite;
            menuStrip1.BackColor = Color.Transparent;
                       
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfil_Click(object sender, EventArgs e)
        {
            Zaposlenici frm = new Zaposlenici();
            frm.Show();
        }
    }
}

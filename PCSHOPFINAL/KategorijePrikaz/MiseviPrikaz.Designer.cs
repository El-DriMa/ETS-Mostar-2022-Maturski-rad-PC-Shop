﻿namespace PCSHOPFINAL.KategorijePrikaz
{
    partial class MiseviPrikaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMisevi = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Šifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvođač = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.cmbxProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaziv2 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMisevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMisevi
            // 
            this.dgMisevi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMisevi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgMisevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMisevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.Opis,
            this.Cijena,
            this.Količina,
            this.Šifra,
            this.Kategorija,
            this.Proizvođač});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMisevi.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgMisevi.Location = new System.Drawing.Point(12, 348);
            this.dgMisevi.Name = "dgMisevi";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMisevi.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgMisevi.RowHeadersWidth = 51;
            this.dgMisevi.RowTemplate.Height = 24;
            this.dgMisevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMisevi.Size = new System.Drawing.Size(1147, 323);
            this.dgMisevi.TabIndex = 2;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "proizvodiID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.MinimumWidth = 6;
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            this.ProizvodID.Width = 110;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "naziv";
            this.Naziv.HeaderText = "Naziv proizvoda";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 110;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.Width = 110;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 110;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "kolicina";
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 6;
            this.Količina.Name = "Količina";
            this.Količina.Width = 110;
            // 
            // Šifra
            // 
            this.Šifra.DataPropertyName = "sifra";
            this.Šifra.HeaderText = "Šifra";
            this.Šifra.MinimumWidth = 6;
            this.Šifra.Name = "Šifra";
            this.Šifra.Width = 110;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Width = 110;
            // 
            // Proizvođač
            // 
            this.Proizvođač.DataPropertyName = "Proizvodjac";
            this.Proizvođač.HeaderText = "Proizvođač";
            this.Proizvođač.MinimumWidth = 6;
            this.Proizvođač.Name = "Proizvođač";
            this.Proizvođač.Width = 110;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(410, 261);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(131, 28);
            this.btnDodaj.TabIndex = 41;
            this.btnDodaj.Text = "Dodaj ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(121, 261);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(144, 22);
            this.txtKategorija.TabIndex = 40;
            this.txtKategorija.Text = "Miševi";
            // 
            // cmbxProizvodjac
            // 
            this.cmbxProizvodjac.FormattingEnabled = true;
            this.cmbxProizvodjac.Location = new System.Drawing.Point(410, 192);
            this.cmbxProizvodjac.Name = "cmbxProizvodjac";
            this.cmbxProizvodjac.Size = new System.Drawing.Size(144, 24);
            this.cmbxProizvodjac.TabIndex = 39;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(410, 122);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(144, 22);
            this.txtKolicina.TabIndex = 38;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(410, 60);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(144, 22);
            this.txtSifra.TabIndex = 37;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(121, 192);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(144, 22);
            this.txtCijena.TabIndex = 36;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(121, 122);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(144, 22);
            this.txtOpis.TabIndex = 35;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(121, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(144, 22);
            this.txtNaziv.TabIndex = 34;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(37, 261);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(72, 17);
            this.lblKategorija.TabIndex = 33;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(312, 192);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(78, 17);
            this.lblProizvodjac.TabIndex = 32;
            this.lblProizvodjac.Text = "Proizvođač";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(312, 122);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(57, 17);
            this.lblKolicina.TabIndex = 31;
            this.lblKolicina.Text = "Količina";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(312, 63);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(37, 17);
            this.lblSifra.TabIndex = 30;
            this.lblSifra.Text = "Šifra";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(37, 192);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(47, 17);
            this.lblCijena.TabIndex = 29;
            this.lblCijena.Text = "Cijena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(37, 122);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(37, 17);
            this.lblOpis.TabIndex = 28;
            this.lblOpis.Text = "Opis";
            // 
            // lblNaziv2
            // 
            this.lblNaziv2.AutoSize = true;
            this.lblNaziv2.Location = new System.Drawing.Point(37, 63);
            this.lblNaziv2.Name = "lblNaziv2";
            this.lblNaziv2.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv2.TabIndex = 27;
            this.lblNaziv2.Text = "Naziv";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(933, 113);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(131, 28);
            this.btnPretraga.TabIndex = 26;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(882, 60);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(229, 22);
            this.txtPretraga.TabIndex = 25;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(815, 63);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 24;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(603, 211);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(131, 28);
            this.btnObrisi.TabIndex = 44;
            this.btnObrisi.Text = "Obrisi podatke";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(603, 151);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(131, 28);
            this.btnIzmjeni.TabIndex = 43;
            this.btnIzmjeni.Text = "Izmjeni podatke";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(603, 97);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(131, 28);
            this.btnUcitaj.TabIndex = 42;
            this.btnUcitaj.Text = "Ucitaj podatke";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // MiseviPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 683);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.cmbxProizvodjac);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dgMisevi);
            this.Name = "MiseviPrikaz";
            this.Text = "MiseviPrikaz";
            this.Load += new System.EventHandler(this.MiseviPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMisevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMisevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Šifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvođač;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.ComboBox cmbxProizvodjac;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNaziv2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnUcitaj;
    }
}
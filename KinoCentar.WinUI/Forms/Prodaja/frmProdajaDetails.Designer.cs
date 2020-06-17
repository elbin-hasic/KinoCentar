namespace KinoCentar.WinUI.Forms.Prodaja
{
    partial class frmProdajaDetails
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
            this.components = new System.ComponentModel.Container();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbProjekcija = new System.Windows.Forms.GroupBox();
            this.txtCijenaRezervacije = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArtikliCijenaUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.txtCijenaUkupno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikalNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikalSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojSjedista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumProjekcije = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbProjekcija.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(1051, 556);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Zatvori";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbProjekcija
            // 
            this.gbProjekcija.Controls.Add(this.txtKorisnik);
            this.gbProjekcija.Controls.Add(this.label10);
            this.gbProjekcija.Controls.Add(this.dtpDatumProjekcije);
            this.gbProjekcija.Controls.Add(this.label9);
            this.gbProjekcija.Controls.Add(this.txtCijena);
            this.gbProjekcija.Controls.Add(this.label5);
            this.gbProjekcija.Controls.Add(this.txtBrojSjedista);
            this.gbProjekcija.Controls.Add(this.label4);
            this.gbProjekcija.Controls.Add(this.txtSala);
            this.gbProjekcija.Controls.Add(this.label3);
            this.gbProjekcija.Controls.Add(this.txtNaslov);
            this.gbProjekcija.Controls.Add(this.label2);
            this.gbProjekcija.Controls.Add(this.txtCijenaRezervacije);
            this.gbProjekcija.Controls.Add(this.label6);
            this.gbProjekcija.Location = new System.Drawing.Point(22, 78);
            this.gbProjekcija.Name = "gbProjekcija";
            this.gbProjekcija.Size = new System.Drawing.Size(440, 462);
            this.gbProjekcija.TabIndex = 55;
            this.gbProjekcija.TabStop = false;
            this.gbProjekcija.Text = "Projekcija";
            // 
            // txtCijenaRezervacije
            // 
            this.txtCijenaRezervacije.Location = new System.Drawing.Point(325, 425);
            this.txtCijenaRezervacije.Name = "txtCijenaRezervacije";
            this.txtCijenaRezervacije.ReadOnly = true;
            this.txtCijenaRezervacije.Size = new System.Drawing.Size(100, 22);
            this.txtCijenaRezervacije.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(222, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cijena (KM):";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtArtikliCijenaUkupno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvArtikli);
            this.groupBox2.Location = new System.Drawing.Point(478, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 520);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikli";
            // 
            // txtArtikliCijenaUkupno
            // 
            this.txtArtikliCijenaUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtikliCijenaUkupno.Location = new System.Drawing.Point(567, 483);
            this.txtArtikliCijenaUkupno.Name = "txtArtikliCijenaUkupno";
            this.txtArtikliCijenaUkupno.ReadOnly = true;
            this.txtArtikliCijenaUkupno.Size = new System.Drawing.Size(100, 22);
            this.txtArtikliCijenaUkupno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(410, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikli ukupno (KM):";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AllowUserToResizeRows = false;
            this.dgvArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ArtikalNaziv,
            this.ArtikalSifra,
            this.Cijena,
            this.Kolicina});
            this.dgvArtikli.Location = new System.Drawing.Point(7, 22);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.RowTemplate.Height = 24;
            this.dgvArtikli.Size = new System.Drawing.Size(660, 445);
            this.dgvArtikli.TabIndex = 0;
            // 
            // txtCijenaUkupno
            // 
            this.txtCijenaUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCijenaUkupno.Location = new System.Drawing.Point(598, 560);
            this.txtCijenaUkupno.Name = "txtCijenaUkupno";
            this.txtCijenaUkupno.ReadOnly = true;
            this.txtCijenaUkupno.Size = new System.Drawing.Size(100, 22);
            this.txtCijenaUkupno.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(475, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "UKUPNO (KM):";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(142, 42);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.ReadOnly = true;
            this.txtBrojRacuna.Size = new System.Drawing.Size(305, 22);
            this.txtBrojRacuna.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Broj računa:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // ArtikalNaziv
            // 
            this.ArtikalNaziv.DataPropertyName = "ArtikalNaziv";
            this.ArtikalNaziv.HeaderText = "Naziv";
            this.ArtikalNaziv.MinimumWidth = 6;
            this.ArtikalNaziv.Name = "ArtikalNaziv";
            this.ArtikalNaziv.ReadOnly = true;
            this.ArtikalNaziv.Width = 140;
            // 
            // ArtikalSifra
            // 
            this.ArtikalSifra.DataPropertyName = "ArtikalSifra";
            this.ArtikalSifra.HeaderText = "Šifra";
            this.ArtikalSifra.MinimumWidth = 6;
            this.ArtikalSifra.Name = "ArtikalSifra";
            this.ArtikalSifra.ReadOnly = true;
            this.ArtikalSifra.Width = 80;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 80;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 80;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(120, 27);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(305, 22);
            this.txtNaslov.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Naslov:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(120, 60);
            this.txtSala.Name = "txtSala";
            this.txtSala.ReadOnly = true;
            this.txtSala.Size = new System.Drawing.Size(305, 22);
            this.txtSala.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sala:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBrojSjedista
            // 
            this.txtBrojSjedista.Location = new System.Drawing.Point(120, 93);
            this.txtBrojSjedista.Name = "txtBrojSjedista";
            this.txtBrojSjedista.ReadOnly = true;
            this.txtBrojSjedista.Size = new System.Drawing.Size(305, 22);
            this.txtBrojSjedista.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Broj sjedišta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(120, 126);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(305, 22);
            this.txtCijena.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Cijena (KM):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDatumProjekcije
            // 
            this.dtpDatumProjekcije.Enabled = false;
            this.dtpDatumProjekcije.Location = new System.Drawing.Point(120, 159);
            this.dtpDatumProjekcije.Name = "dtpDatumProjekcije";
            this.dtpDatumProjekcije.Size = new System.Drawing.Size(305, 22);
            this.dtpDatumProjekcije.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Datum gledanja:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(120, 192);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(305, 22);
            this.txtKorisnik.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 82;
            this.label10.Text = "Korisnik:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmProdajaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 613);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCijenaUkupno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProjekcija);
            this.Controls.Add(this.btnOdustani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProdajaDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodaja prikaz";
            this.Load += new System.EventHandler(this.frmProdajaDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbProjekcija.ResumeLayout(false);
            this.gbProjekcija.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbProjekcija;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox txtArtikliCijenaUkupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijenaRezervacije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijenaUkupno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojSjedista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumProjekcije;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label10;
    }
}
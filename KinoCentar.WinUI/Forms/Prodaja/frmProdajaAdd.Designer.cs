namespace KinoCentar.WinUI.Forms.Prodaja
{
    partial class frmProdajaAdd
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBezRezervacije = new System.Windows.Forms.RadioButton();
            this.txtCijenaRezervacije = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrojSjedista = new System.Windows.Forms.ComboBox();
            this.btnProjekcijaInfo = new System.Windows.Forms.Button();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbProjekcija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbKreirajRezervaciju = new System.Windows.Forms.RadioButton();
            this.btnRezervacijaInfo = new System.Windows.Forms.Button();
            this.cmbRezervacija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbIzaberiRezervaciju = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArtikliCijenaUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izaberi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCijenaUkupno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumProjekcije = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnimi.Location = new System.Drawing.Point(1051, 556);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 20;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(945, 556);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatumProjekcije);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbBezRezervacije);
            this.groupBox1.Controls.Add(this.txtCijenaRezervacije);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbBrojSjedista);
            this.groupBox1.Controls.Add(this.btnProjekcijaInfo);
            this.groupBox1.Controls.Add(this.cmbKorisnik);
            this.groupBox1.Controls.Add(this.cmbProjekcija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbKreirajRezervaciju);
            this.groupBox1.Controls.Add(this.btnRezervacijaInfo);
            this.groupBox1.Controls.Add(this.cmbRezervacija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbIzaberiRezervaciju);
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 462);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekcija";
            // 
            // rbBezRezervacije
            // 
            this.rbBezRezervacije.AutoSize = true;
            this.rbBezRezervacije.Location = new System.Drawing.Point(9, 262);
            this.rbBezRezervacije.Name = "rbBezRezervacije";
            this.rbBezRezervacije.Size = new System.Drawing.Size(126, 21);
            this.rbBezRezervacije.TabIndex = 67;
            this.rbBezRezervacije.Text = "Bez rezervacije";
            this.rbBezRezervacije.UseVisualStyleBackColor = true;
            this.rbBezRezervacije.CheckedChanged += new System.EventHandler(this.rbBezRezervacije_CheckedChanged);
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
            // cmbBrojSjedista
            // 
            this.cmbBrojSjedista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojSjedista.Enabled = false;
            this.cmbBrojSjedista.FormattingEnabled = true;
            this.cmbBrojSjedista.Location = new System.Drawing.Point(120, 191);
            this.cmbBrojSjedista.Name = "cmbBrojSjedista";
            this.cmbBrojSjedista.Size = new System.Drawing.Size(305, 24);
            this.cmbBrojSjedista.TabIndex = 64;
            // 
            // btnProjekcijaInfo
            // 
            this.btnProjekcijaInfo.Enabled = false;
            this.btnProjekcijaInfo.Location = new System.Drawing.Point(395, 122);
            this.btnProjekcijaInfo.Name = "btnProjekcijaInfo";
            this.btnProjekcijaInfo.Size = new System.Drawing.Size(30, 26);
            this.btnProjekcijaInfo.TabIndex = 63;
            this.btnProjekcijaInfo.Text = "i";
            this.btnProjekcijaInfo.UseVisualStyleBackColor = true;
            this.btnProjekcijaInfo.Click += new System.EventHandler(this.btnProjekcijaInfo_Click);
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnik.Enabled = false;
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(120, 156);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(305, 24);
            this.cmbKorisnik.TabIndex = 61;
            // 
            // cmbProjekcija
            // 
            this.cmbProjekcija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjekcija.Enabled = false;
            this.cmbProjekcija.FormattingEnabled = true;
            this.cmbProjekcija.Location = new System.Drawing.Point(120, 123);
            this.cmbProjekcija.Name = "cmbProjekcija";
            this.cmbProjekcija.Size = new System.Drawing.Size(269, 24);
            this.cmbProjekcija.TabIndex = 59;
            this.cmbProjekcija.SelectedIndexChanged += new System.EventHandler(this.cmbProjekcija_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Broj sjedišta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Korisnik:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Projekcija:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbKreirajRezervaciju
            // 
            this.rbKreirajRezervaciju.AutoSize = true;
            this.rbKreirajRezervaciju.Location = new System.Drawing.Point(9, 93);
            this.rbKreirajRezervaciju.Name = "rbKreirajRezervaciju";
            this.rbKreirajRezervaciju.Size = new System.Drawing.Size(143, 21);
            this.rbKreirajRezervaciju.TabIndex = 57;
            this.rbKreirajRezervaciju.Text = "Kreiraj rezervaciju";
            this.rbKreirajRezervaciju.UseVisualStyleBackColor = true;
            this.rbKreirajRezervaciju.CheckedChanged += new System.EventHandler(this.rbKreirajRezervaciju_CheckedChanged);
            // 
            // btnRezervacijaInfo
            // 
            this.btnRezervacijaInfo.Location = new System.Drawing.Point(395, 52);
            this.btnRezervacijaInfo.Name = "btnRezervacijaInfo";
            this.btnRezervacijaInfo.Size = new System.Drawing.Size(30, 26);
            this.btnRezervacijaInfo.TabIndex = 56;
            this.btnRezervacijaInfo.Text = "i";
            this.btnRezervacijaInfo.UseVisualStyleBackColor = true;
            this.btnRezervacijaInfo.Click += new System.EventHandler(this.btnRezervacijaInfo_Click);
            // 
            // cmbRezervacija
            // 
            this.cmbRezervacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezervacija.FormattingEnabled = true;
            this.cmbRezervacija.Location = new System.Drawing.Point(120, 53);
            this.cmbRezervacija.Name = "cmbRezervacija";
            this.cmbRezervacija.Size = new System.Drawing.Size(269, 24);
            this.cmbRezervacija.TabIndex = 55;
            this.cmbRezervacija.SelectedIndexChanged += new System.EventHandler(this.cmbRezervacija_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Rezervacija:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbIzaberiRezervaciju
            // 
            this.rbIzaberiRezervaciju.AutoSize = true;
            this.rbIzaberiRezervaciju.Checked = true;
            this.rbIzaberiRezervaciju.Location = new System.Drawing.Point(9, 24);
            this.rbIzaberiRezervaciju.Name = "rbIzaberiRezervaciju";
            this.rbIzaberiRezervaciju.Size = new System.Drawing.Size(144, 21);
            this.rbIzaberiRezervaciju.TabIndex = 0;
            this.rbIzaberiRezervaciju.TabStop = true;
            this.rbIzaberiRezervaciju.Text = "Izaberi rezervaciju";
            this.rbIzaberiRezervaciju.UseVisualStyleBackColor = true;
            this.rbIzaberiRezervaciju.CheckedChanged += new System.EventHandler(this.rbIzaberiRezervaciju_CheckedChanged);
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
            this.Izaberi,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Kolicina});
            this.dgvArtikli.Location = new System.Drawing.Point(7, 22);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.RowTemplate.Height = 24;
            this.dgvArtikli.Size = new System.Drawing.Size(660, 445);
            this.dgvArtikli.TabIndex = 0;
            this.dgvArtikli.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellValueChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Izaberi
            // 
            this.Izaberi.DataPropertyName = "Izaberi";
            this.Izaberi.HeaderText = "";
            this.Izaberi.MinimumWidth = 6;
            this.Izaberi.Name = "Izaberi";
            this.Izaberi.Width = 30;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 140;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.MinimumWidth = 6;
            this.Sifra.Name = "Sifra";
            this.Sifra.Width = 80;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 80;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 80;
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
            // dtpDatumProjekcije
            // 
            this.dtpDatumProjekcije.Location = new System.Drawing.Point(120, 226);
            this.dtpDatumProjekcije.Name = "dtpDatumProjekcije";
            this.dtpDatumProjekcije.Size = new System.Drawing.Size(305, 22);
            this.dtpDatumProjekcije.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Datum gledanja:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmProdajaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 613);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCijenaUkupno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProdajaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova prodaja";
            this.Load += new System.EventHandler(this.frmProdajaAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox txtArtikliCijenaUkupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbIzaberiRezervaciju;
        private System.Windows.Forms.RadioButton rbKreirajRezervaciju;
        private System.Windows.Forms.Button btnRezervacijaInfo;
        private System.Windows.Forms.ComboBox cmbRezervacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijenaRezervacije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBrojSjedista;
        private System.Windows.Forms.Button btnProjekcijaInfo;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbProjekcija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbBezRezervacije;
        private System.Windows.Forms.TextBox txtCijenaUkupno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izaberi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumProjekcije;
        private System.Windows.Forms.Label label9;
    }
}
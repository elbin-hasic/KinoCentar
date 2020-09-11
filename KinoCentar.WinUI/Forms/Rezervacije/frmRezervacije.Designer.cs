namespace KinoCentar.WinUI.Forms.Rezervacije
{
    partial class frmRezervacije
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtNaslovPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmNaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijediOdDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumProjekcijeShortDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsProdano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumProdano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOtkazano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumOtkazano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.Location = new System.Drawing.Point(858, 25);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 26);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovi.Location = new System.Drawing.Point(752, 25);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(100, 26);
            this.btnNovi.TabIndex = 3;
            this.btnNovi.Text = "Nova";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrisi.Location = new System.Drawing.Point(1070, 25);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(100, 26);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmNaslov,
            this.SalaNaziv,
            this.BrojSjedista,
            this.Cijena,
            this.VrijediOdDo,
            this.DatumProjekcijeShortDate,
            this.KorisnikImePrezime,
            this.IsProdano,
            this.DatumProdano,
            this.IsOtkazano,
            this.DatumOtkazano});
            this.dgvRezervacije.Location = new System.Drawing.Point(0, 75);
            this.dgvRezervacije.MultiSelect = false;
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(1182, 677);
            this.dgvRezervacije.TabIndex = 10;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(399, 25);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(100, 26);
            this.btnTrazi.TabIndex = 9;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtNaslovPretraga
            // 
            this.txtNaslovPretraga.Location = new System.Drawing.Point(73, 27);
            this.txtNaslovPretraga.Name = "txtNaslovPretraga";
            this.txtNaslovPretraga.Size = new System.Drawing.Size(320, 22);
            this.txtNaslovPretraga.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naslov:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtkazi.Location = new System.Drawing.Point(964, 25);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 26);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 6;
            // 
            // FilmNaslov
            // 
            this.FilmNaslov.DataPropertyName = "FilmNaslov";
            this.FilmNaslov.HeaderText = "Film";
            this.FilmNaslov.MinimumWidth = 6;
            this.FilmNaslov.Name = "FilmNaslov";
            this.FilmNaslov.ReadOnly = true;
            this.FilmNaslov.Width = 220;
            // 
            // SalaNaziv
            // 
            this.SalaNaziv.DataPropertyName = "SalaNaziv";
            this.SalaNaziv.HeaderText = "Sala";
            this.SalaNaziv.MinimumWidth = 6;
            this.SalaNaziv.Name = "SalaNaziv";
            this.SalaNaziv.ReadOnly = true;
            this.SalaNaziv.Width = 160;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedišta";
            this.BrojSjedista.MinimumWidth = 6;
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // VrijediOdDo
            // 
            this.VrijediOdDo.DataPropertyName = "VrijediOdDoShortDate";
            this.VrijediOdDo.HeaderText = "Vrijedi [od - do]";
            this.VrijediOdDo.MinimumWidth = 6;
            this.VrijediOdDo.Name = "VrijediOdDo";
            this.VrijediOdDo.ReadOnly = true;
            this.VrijediOdDo.Width = 150;
            // 
            // DatumProjekcijeShortDate
            // 
            this.DatumProjekcijeShortDate.DataPropertyName = "DatumProjekcijeShortDate";
            this.DatumProjekcijeShortDate.HeaderText = "Rezervisani termin";
            this.DatumProjekcijeShortDate.MinimumWidth = 6;
            this.DatumProjekcijeShortDate.Name = "DatumProjekcijeShortDate";
            this.DatumProjekcijeShortDate.ReadOnly = true;
            this.DatumProjekcijeShortDate.Width = 150;
            // 
            // KorisnikImePrezime
            // 
            this.KorisnikImePrezime.DataPropertyName = "KorisnikImePrezime";
            this.KorisnikImePrezime.HeaderText = "Korisnik";
            this.KorisnikImePrezime.MinimumWidth = 6;
            this.KorisnikImePrezime.Name = "KorisnikImePrezime";
            this.KorisnikImePrezime.ReadOnly = true;
            this.KorisnikImePrezime.Width = 120;
            // 
            // IsProdano
            // 
            this.IsProdano.DataPropertyName = "IsProdano";
            this.IsProdano.HeaderText = "Prodano?";
            this.IsProdano.MinimumWidth = 6;
            this.IsProdano.Name = "IsProdano";
            this.IsProdano.ReadOnly = true;
            // 
            // DatumProdano
            // 
            this.DatumProdano.DataPropertyName = "DatumProdano";
            this.DatumProdano.HeaderText = "Datum prodaje";
            this.DatumProdano.MinimumWidth = 6;
            this.DatumProdano.Name = "DatumProdano";
            this.DatumProdano.ReadOnly = true;
            this.DatumProdano.Width = 120;
            // 
            // IsOtkazano
            // 
            this.IsOtkazano.DataPropertyName = "IsOtkazano";
            this.IsOtkazano.HeaderText = "Otkazano?";
            this.IsOtkazano.MinimumWidth = 6;
            this.IsOtkazano.Name = "IsOtkazano";
            this.IsOtkazano.ReadOnly = true;
            // 
            // DatumOtkazano
            // 
            this.DatumOtkazano.DataPropertyName = "DatumOtkazano";
            this.DatumOtkazano.HeaderText = "Datum otkazivanja";
            this.DatumOtkazano.MinimumWidth = 6;
            this.DatumOtkazano.Name = "DatumOtkazano";
            this.DatumOtkazano.ReadOnly = true;
            this.DatumOtkazano.Width = 120;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNaslovPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtNaslovPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmNaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijediOdDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProjekcijeShortDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikImePrezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsProdano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProdano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOtkazano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOtkazano;
    }
}
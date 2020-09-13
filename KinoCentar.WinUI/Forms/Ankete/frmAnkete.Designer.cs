namespace KinoCentar.WinUI.Forms.Ankete
{
    partial class frmAnkete
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslovPretraga = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvAnkete = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakljucenoDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZakljucaj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnkete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // txtNaslovPretraga
            // 
            this.txtNaslovPretraga.Location = new System.Drawing.Point(73, 27);
            this.txtNaslovPretraga.Name = "txtNaslovPretraga";
            this.txtNaslovPretraga.Size = new System.Drawing.Size(320, 22);
            this.txtNaslovPretraga.TabIndex = 1;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(399, 25);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(100, 26);
            this.btnTrazi.TabIndex = 2;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.Location = new System.Drawing.Point(858, 25);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 26);
            this.btnUredi.TabIndex = 5;
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
            this.btnNovi.TabIndex = 4;
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
            this.btnBrisi.TabIndex = 7;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvAnkete
            // 
            this.dgvAnkete.AllowUserToAddRows = false;
            this.dgvAnkete.AllowUserToDeleteRows = false;
            this.dgvAnkete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnkete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnkete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.KorisnikImePrezime,
            this.Datum,
            this.ZakljucenoDatum});
            this.dgvAnkete.Location = new System.Drawing.Point(0, 75);
            this.dgvAnkete.MultiSelect = false;
            this.dgvAnkete.Name = "dgvAnkete";
            this.dgvAnkete.ReadOnly = true;
            this.dgvAnkete.RowHeadersWidth = 51;
            this.dgvAnkete.RowTemplate.Height = 24;
            this.dgvAnkete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnkete.Size = new System.Drawing.Size(1182, 677);
            this.dgvAnkete.TabIndex = 6;
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
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 240;
            // 
            // KorisnikImePrezime
            // 
            this.KorisnikImePrezime.DataPropertyName = "KorisnikImePrezime";
            this.KorisnikImePrezime.HeaderText = "Objavio";
            this.KorisnikImePrezime.MinimumWidth = 6;
            this.KorisnikImePrezime.Name = "KorisnikImePrezime";
            this.KorisnikImePrezime.ReadOnly = true;
            this.KorisnikImePrezime.Width = 200;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Objavljeno";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 140;
            // 
            // ZakljucenoDatum
            // 
            this.ZakljucenoDatum.DataPropertyName = "ZakljucenoDatum";
            this.ZakljucenoDatum.HeaderText = "Zaključeno";
            this.ZakljucenoDatum.MinimumWidth = 6;
            this.ZakljucenoDatum.Name = "ZakljucenoDatum";
            this.ZakljucenoDatum.ReadOnly = true;
            this.ZakljucenoDatum.Width = 140;
            // 
            // btnZakljucaj
            // 
            this.btnZakljucaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZakljucaj.Location = new System.Drawing.Point(964, 25);
            this.btnZakljucaj.Name = "btnZakljucaj";
            this.btnZakljucaj.Size = new System.Drawing.Size(100, 26);
            this.btnZakljucaj.TabIndex = 6;
            this.btnZakljucaj.Text = "Zaključaj";
            this.btnZakljucaj.UseVisualStyleBackColor = true;
            this.btnZakljucaj.Click += new System.EventHandler(this.btnZakljucaj_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikazi.Location = new System.Drawing.Point(646, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 26);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmAnkete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnZakljucaj);
            this.Controls.Add(this.dgvAnkete);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNaslovPretraga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnkete";
            this.Text = "Ankete";
            this.Load += new System.EventHandler(this.frmAnkete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnkete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslovPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvAnkete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakljucenoDatum;
        private System.Windows.Forms.Button btnZakljucaj;
        private System.Windows.Forms.Button btnPrikazi;
    }
}
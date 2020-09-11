namespace KinoCentar.WinUI.Forms.Projekcije
{
    partial class frmProjekcije
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
            this.dgvProjekcije = new System.Windows.Forms.DataGridView();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtNaslovPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmNaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijediOdShortDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijediDoShortDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminiPrikaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.Location = new System.Drawing.Point(964, 25);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 26);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovi.Location = new System.Drawing.Point(858, 25);
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
            this.btnBrisi.TabIndex = 5;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvProjekcije
            // 
            this.dgvProjekcije.AllowUserToAddRows = false;
            this.dgvProjekcije.AllowUserToDeleteRows = false;
            this.dgvProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmNaslov,
            this.SalaNaziv,
            this.Cijena,
            this.VrijediOdShortDate,
            this.VrijediDoShortDate,
            this.TerminiPrikaz});
            this.dgvProjekcije.Location = new System.Drawing.Point(0, 75);
            this.dgvProjekcije.MultiSelect = false;
            this.dgvProjekcije.Name = "dgvProjekcije";
            this.dgvProjekcije.ReadOnly = true;
            this.dgvProjekcije.RowHeadersWidth = 51;
            this.dgvProjekcije.RowTemplate.Height = 24;
            this.dgvProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekcije.Size = new System.Drawing.Size(1182, 677);
            this.dgvProjekcije.TabIndex = 6;
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
            this.FilmNaslov.Width = 240;
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
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 140;
            // 
            // VrijediOdShortDate
            // 
            this.VrijediOdShortDate.DataPropertyName = "VrijediOdShortDate";
            this.VrijediOdShortDate.HeaderText = "Vrijedi od";
            this.VrijediOdShortDate.MinimumWidth = 6;
            this.VrijediOdShortDate.Name = "VrijediOdShortDate";
            this.VrijediOdShortDate.ReadOnly = true;
            this.VrijediOdShortDate.Width = 140;
            // 
            // VrijediDoShortDate
            // 
            this.VrijediDoShortDate.DataPropertyName = "VrijediDoShortDate";
            this.VrijediDoShortDate.HeaderText = "Vrijedi do";
            this.VrijediDoShortDate.MinimumWidth = 6;
            this.VrijediDoShortDate.Name = "VrijediDoShortDate";
            this.VrijediDoShortDate.ReadOnly = true;
            this.VrijediDoShortDate.Width = 140;
            // 
            // TerminiPrikaz
            // 
            this.TerminiPrikaz.DataPropertyName = "TerminiPrikaz";
            this.TerminiPrikaz.HeaderText = "Termini";
            this.TerminiPrikaz.MinimumWidth = 6;
            this.TerminiPrikaz.Name = "TerminiPrikaz";
            this.TerminiPrikaz.ReadOnly = true;
            this.TerminiPrikaz.Width = 125;
            // 
            // frmProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNaslovPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProjekcije);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProjekcije";
            this.Text = "Projekcije";
            this.Load += new System.EventHandler(this.frmProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvProjekcije;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtNaslovPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmNaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijediOdShortDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijediDoShortDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminiPrikaz;
    }
}
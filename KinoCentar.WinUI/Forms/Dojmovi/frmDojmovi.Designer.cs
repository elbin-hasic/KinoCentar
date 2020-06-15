namespace KinoCentar.WinUI.Forms.Dojmovi
{
    partial class frmDojmovi
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
            this.txtNazivPretraga = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvDojmovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjekcijaNaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojmovi)).BeginInit();
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
            // txtNazivPretraga
            // 
            this.txtNazivPretraga.Location = new System.Drawing.Point(73, 27);
            this.txtNazivPretraga.Name = "txtNazivPretraga";
            this.txtNazivPretraga.Size = new System.Drawing.Size(320, 22);
            this.txtNazivPretraga.TabIndex = 1;
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
            // dgvDojmovi
            // 
            this.dgvDojmovi.AllowUserToAddRows = false;
            this.dgvDojmovi.AllowUserToDeleteRows = false;
            this.dgvDojmovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDojmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDojmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProjekcijaNaslov,
            this.KorisnikImePrezime,
            this.Ocjena,
            this.Tekst,
            this.Datum});
            this.dgvDojmovi.Location = new System.Drawing.Point(0, 75);
            this.dgvDojmovi.MultiSelect = false;
            this.dgvDojmovi.Name = "dgvDojmovi";
            this.dgvDojmovi.ReadOnly = true;
            this.dgvDojmovi.RowHeadersWidth = 51;
            this.dgvDojmovi.RowTemplate.Height = 24;
            this.dgvDojmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDojmovi.Size = new System.Drawing.Size(1182, 677);
            this.dgvDojmovi.TabIndex = 6;
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
            // ProjekcijaNaslov
            // 
            this.ProjekcijaNaslov.DataPropertyName = "ProjekcijaNaslov";
            this.ProjekcijaNaslov.HeaderText = "Naslov";
            this.ProjekcijaNaslov.MinimumWidth = 6;
            this.ProjekcijaNaslov.Name = "ProjekcijaNaslov";
            this.ProjekcijaNaslov.ReadOnly = true;
            this.ProjekcijaNaslov.Width = 300;
            // 
            // KorisnikImePrezime
            // 
            this.KorisnikImePrezime.DataPropertyName = "KorisnikImePrezime";
            this.KorisnikImePrezime.HeaderText = "Korisnik";
            this.KorisnikImePrezime.MinimumWidth = 6;
            this.KorisnikImePrezime.Name = "KorisnikImePrezime";
            this.KorisnikImePrezime.ReadOnly = true;
            this.KorisnikImePrezime.Width = 140;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 140;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.MinimumWidth = 6;
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            this.Tekst.Width = 440;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 140;
            // 
            // frmDojmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvDojmovi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNazivPretraga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDojmovi";
            this.Text = "Dojmovi";
            this.Load += new System.EventHandler(this.frmDojmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvDojmovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjekcijaNaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}
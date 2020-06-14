namespace KinoCentar.WinUI.Forms.FilmskeLicnosti
{
    partial class frmFilmskeLicnosti
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
            this.dgvFilmskeLicnosti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsGlumac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsReziser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPrezimePretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtImePretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmskeLicnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.Location = new System.Drawing.Point(964, 25);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 26);
            this.btnUredi.TabIndex = 6;
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
            this.btnNovi.TabIndex = 5;
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
            // dgvFilmskeLicnosti
            // 
            this.dgvFilmskeLicnosti.AllowUserToAddRows = false;
            this.dgvFilmskeLicnosti.AllowUserToDeleteRows = false;
            this.dgvFilmskeLicnosti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmskeLicnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmskeLicnosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.IsGlumac,
            this.IsReziser});
            this.dgvFilmskeLicnosti.Location = new System.Drawing.Point(0, 75);
            this.dgvFilmskeLicnosti.MultiSelect = false;
            this.dgvFilmskeLicnosti.Name = "dgvFilmskeLicnosti";
            this.dgvFilmskeLicnosti.ReadOnly = true;
            this.dgvFilmskeLicnosti.RowHeadersWidth = 51;
            this.dgvFilmskeLicnosti.RowTemplate.Height = 24;
            this.dgvFilmskeLicnosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmskeLicnosti.Size = new System.Drawing.Size(1182, 677);
            this.dgvFilmskeLicnosti.TabIndex = 10;
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
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 320;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 320;
            // 
            // IsGlumac
            // 
            this.IsGlumac.DataPropertyName = "IsGlumac";
            this.IsGlumac.HeaderText = "Glumac?";
            this.IsGlumac.MinimumWidth = 6;
            this.IsGlumac.Name = "IsGlumac";
            this.IsGlumac.ReadOnly = true;
            this.IsGlumac.Width = 125;
            // 
            // IsReziser
            // 
            this.IsReziser.DataPropertyName = "IsReziser";
            this.IsReziser.HeaderText = "Režiser?";
            this.IsReziser.MinimumWidth = 6;
            this.IsReziser.Name = "IsReziser";
            this.IsReziser.ReadOnly = true;
            this.IsReziser.Width = 125;
            // 
            // txtPrezimePretraga
            // 
            this.txtPrezimePretraga.Location = new System.Drawing.Point(327, 27);
            this.txtPrezimePretraga.Name = "txtPrezimePretraga";
            this.txtPrezimePretraga.Size = new System.Drawing.Size(200, 22);
            this.txtPrezimePretraga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(533, 25);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(100, 26);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtImePretraga
            // 
            this.txtImePretraga.Location = new System.Drawing.Point(52, 27);
            this.txtImePretraga.Name = "txtImePretraga";
            this.txtImePretraga.Size = new System.Drawing.Size(200, 22);
            this.txtImePretraga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // frmFilmskeLicnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.txtPrezimePretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtImePretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFilmskeLicnosti);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFilmskeLicnosti";
            this.Text = "Filmske ličnosti";
            this.Load += new System.EventHandler(this.frmFilmskeLicnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmskeLicnosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvFilmskeLicnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsGlumac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReziser;
        private System.Windows.Forms.TextBox txtPrezimePretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtImePretraga;
        private System.Windows.Forms.Label label1;
    }
}
namespace KinoCentar.WinUI.Forms.Filmovi
{
    partial class frmFilmovi
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
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtNaslovPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RediteljImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaSnimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
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
            this.btnNovi.Text = "Novi";
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
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.RediteljImePrezime,
            this.Trajanje,
            this.GodinaSnimanja});
            this.dgvFilmovi.Location = new System.Drawing.Point(0, 75);
            this.dgvFilmovi.MultiSelect = false;
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowHeadersWidth = 51;
            this.dgvFilmovi.RowTemplate.Height = 24;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.Size = new System.Drawing.Size(1182, 677);
            this.dgvFilmovi.TabIndex = 6;
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
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 220;
            // 
            // RediteljImePrezime
            // 
            this.RediteljImePrezime.DataPropertyName = "RediteljImePrezime";
            this.RediteljImePrezime.HeaderText = "Reditelj";
            this.RediteljImePrezime.MinimumWidth = 6;
            this.RediteljImePrezime.Name = "RediteljImePrezime";
            this.RediteljImePrezime.ReadOnly = true;
            this.RediteljImePrezime.Width = 160;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.HeaderText = "Trajanje";
            this.Trajanje.MinimumWidth = 6;
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            this.Trajanje.Width = 120;
            // 
            // GodinaSnimanja
            // 
            this.GodinaSnimanja.DataPropertyName = "GodinaSnimanja";
            this.GodinaSnimanja.HeaderText = "Godina snimanja";
            this.GodinaSnimanja.MinimumWidth = 6;
            this.GodinaSnimanja.Name = "GodinaSnimanja";
            this.GodinaSnimanja.ReadOnly = true;
            this.GodinaSnimanja.Width = 160;
            // 
            // frmFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNaslovPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFilmovi";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.frmFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtNaslovPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn RediteljImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaSnimanja;
    }
}
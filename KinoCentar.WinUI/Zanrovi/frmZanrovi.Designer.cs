namespace KinoCentar.WinUI.Zanrovi
{
    partial class frmZanrovi
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvZanrovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // txtNazivPretraga
            // 
            this.txtNazivPretraga.Location = new System.Drawing.Point(65, 27);
            this.txtNazivPretraga.Name = "txtNazivPretraga";
            this.txtNazivPretraga.Size = new System.Drawing.Size(320, 22);
            this.txtNazivPretraga.TabIndex = 1;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(391, 25);
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
            // dgvZanrovi
            // 
            this.dgvZanrovi.AllowUserToAddRows = false;
            this.dgvZanrovi.AllowUserToDeleteRows = false;
            this.dgvZanrovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanrovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Opis});
            this.dgvZanrovi.Location = new System.Drawing.Point(0, 75);
            this.dgvZanrovi.MultiSelect = false;
            this.dgvZanrovi.Name = "dgvZanrovi";
            this.dgvZanrovi.ReadOnly = true;
            this.dgvZanrovi.RowHeadersWidth = 51;
            this.dgvZanrovi.RowTemplate.Height = 24;
            this.dgvZanrovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZanrovi.Size = new System.Drawing.Size(1182, 677);
            this.dgvZanrovi.TabIndex = 6;
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
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 240;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 480;
            // 
            // frmZanrovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvZanrovi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNazivPretraga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZanrovi";
            this.Text = "Žanrovi";
            this.Load += new System.EventHandler(this.frmZanrovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvZanrovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}
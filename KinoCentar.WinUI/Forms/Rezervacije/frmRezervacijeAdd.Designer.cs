namespace KinoCentar.WinUI.Forms.Rezervacije
{
    partial class frmRezervacijeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProjekcija = new System.Windows.Forms.ComboBox();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.dtpDatumProjekcije = new System.Windows.Forms.DateTimePicker();
            this.btnProjekcijaInfo = new System.Windows.Forms.Button();
            this.cmbBrojSjedista = new System.Windows.Forms.ComboBox();
            this.brnNoviKorisnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekcija:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(335, 195);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 20;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(229, 195);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korisnik:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj sjedišta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum gledanja:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbProjekcija
            // 
            this.cmbProjekcija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjekcija.FormattingEnabled = true;
            this.cmbProjekcija.Location = new System.Drawing.Point(153, 35);
            this.cmbProjekcija.Name = "cmbProjekcija";
            this.cmbProjekcija.Size = new System.Drawing.Size(246, 24);
            this.cmbProjekcija.TabIndex = 1;
            this.cmbProjekcija.SelectedIndexChanged += new System.EventHandler(this.cmbProjekcija_SelectedIndexChanged);
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(153, 68);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(246, 24);
            this.cmbKorisnik.TabIndex = 4;
            // 
            // dtpDatumProjekcije
            // 
            this.dtpDatumProjekcije.Location = new System.Drawing.Point(153, 138);
            this.dtpDatumProjekcije.Name = "dtpDatumProjekcije";
            this.dtpDatumProjekcije.Size = new System.Drawing.Size(282, 22);
            this.dtpDatumProjekcije.TabIndex = 9;
            // 
            // btnProjekcijaInfo
            // 
            this.btnProjekcijaInfo.Location = new System.Drawing.Point(405, 34);
            this.btnProjekcijaInfo.Name = "btnProjekcijaInfo";
            this.btnProjekcijaInfo.Size = new System.Drawing.Size(30, 26);
            this.btnProjekcijaInfo.TabIndex = 2;
            this.btnProjekcijaInfo.Text = "i";
            this.btnProjekcijaInfo.UseVisualStyleBackColor = true;
            this.btnProjekcijaInfo.Click += new System.EventHandler(this.btnProjekcijaInfo_Click);
            // 
            // cmbBrojSjedista
            // 
            this.cmbBrojSjedista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojSjedista.FormattingEnabled = true;
            this.cmbBrojSjedista.Location = new System.Drawing.Point(153, 103);
            this.cmbBrojSjedista.Name = "cmbBrojSjedista";
            this.cmbBrojSjedista.Size = new System.Drawing.Size(282, 24);
            this.cmbBrojSjedista.TabIndex = 7;
            // 
            // brnNoviKorisnik
            // 
            this.brnNoviKorisnik.Location = new System.Drawing.Point(405, 66);
            this.brnNoviKorisnik.Name = "brnNoviKorisnik";
            this.brnNoviKorisnik.Size = new System.Drawing.Size(30, 26);
            this.brnNoviKorisnik.TabIndex = 5;
            this.brnNoviKorisnik.Text = "+";
            this.brnNoviKorisnik.UseVisualStyleBackColor = true;
            this.brnNoviKorisnik.Click += new System.EventHandler(this.brnNoviKorisnik_Click);
            // 
            // frmRezervacijeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 257);
            this.Controls.Add(this.brnNoviKorisnik);
            this.Controls.Add(this.cmbBrojSjedista);
            this.Controls.Add(this.btnProjekcijaInfo);
            this.Controls.Add(this.dtpDatumProjekcije);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.cmbProjekcija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRezervacijeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova rezervacija";
            this.Load += new System.EventHandler(this.frmRezervacijeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProjekcija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.DateTimePicker dtpDatumProjekcije;
        private System.Windows.Forms.Button btnProjekcijaInfo;
        private System.Windows.Forms.ComboBox cmbBrojSjedista;
        private System.Windows.Forms.Button brnNoviKorisnik;
    }
}
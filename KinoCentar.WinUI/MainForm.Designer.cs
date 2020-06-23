namespace KinoCentar.WinUI
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zanroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jediniceMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmskeLicnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmoviNoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmoviListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekcijeNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekcijeListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artilkiNoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiProdajaPoDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dojmoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dojmoviListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUserToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.anketeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anketeNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anketeListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.UserStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem,
            this.filmoviToolStripMenuItem,
            this.projekcijeToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.prodajaToolStripMenuItem,
            this.izvjestajiToolStripMenuItem,
            this.obavijestiToolStripMenuItem,
            this.dojmoviToolStripMenuItem,
            this.anketeToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1364, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.tipoviKorisnikaToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.zanroviToolStripMenuItem,
            this.jediniceMjereToolStripMenuItem,
            this.filmskeLicnostiToolStripMenuItem});
            this.administracijaToolStripMenuItem.Enabled = false;
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // tipoviKorisnikaToolStripMenuItem
            // 
            this.tipoviKorisnikaToolStripMenuItem.Name = "tipoviKorisnikaToolStripMenuItem";
            this.tipoviKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.tipoviKorisnikaToolStripMenuItem.Text = "Tipovi korisnika";
            this.tipoviKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.tipoviKorisnikaToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // zanroviToolStripMenuItem
            // 
            this.zanroviToolStripMenuItem.Name = "zanroviToolStripMenuItem";
            this.zanroviToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.zanroviToolStripMenuItem.Text = "Žanrovi";
            this.zanroviToolStripMenuItem.Click += new System.EventHandler(this.zanroviToolStripMenuItem_Click);
            // 
            // jediniceMjereToolStripMenuItem
            // 
            this.jediniceMjereToolStripMenuItem.Name = "jediniceMjereToolStripMenuItem";
            this.jediniceMjereToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.jediniceMjereToolStripMenuItem.Text = "Jedinice mjere";
            this.jediniceMjereToolStripMenuItem.Click += new System.EventHandler(this.jediniceMjereToolStripMenuItem_Click);
            // 
            // filmskeLicnostiToolStripMenuItem
            // 
            this.filmskeLicnostiToolStripMenuItem.Name = "filmskeLicnostiToolStripMenuItem";
            this.filmskeLicnostiToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.filmskeLicnostiToolStripMenuItem.Text = "Filmske ličnosti";
            this.filmskeLicnostiToolStripMenuItem.Click += new System.EventHandler(this.filmskeLicnostiToolStripMenuItem_Click);
            // 
            // filmoviToolStripMenuItem
            // 
            this.filmoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmoviNoviToolStripMenuItem,
            this.filmoviListaToolStripMenuItem});
            this.filmoviToolStripMenuItem.Enabled = false;
            this.filmoviToolStripMenuItem.Name = "filmoviToolStripMenuItem";
            this.filmoviToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.filmoviToolStripMenuItem.Text = "Filmovi";
            // 
            // filmoviNoviToolStripMenuItem
            // 
            this.filmoviNoviToolStripMenuItem.Name = "filmoviNoviToolStripMenuItem";
            this.filmoviNoviToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.filmoviNoviToolStripMenuItem.Text = "Novi";
            this.filmoviNoviToolStripMenuItem.Click += new System.EventHandler(this.filmoviNoviToolStripMenuItem_Click);
            // 
            // filmoviListaToolStripMenuItem
            // 
            this.filmoviListaToolStripMenuItem.Name = "filmoviListaToolStripMenuItem";
            this.filmoviListaToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.filmoviListaToolStripMenuItem.Text = "Lista";
            this.filmoviListaToolStripMenuItem.Click += new System.EventHandler(this.filmoviListaToolStripMenuItem_Click);
            // 
            // projekcijeToolStripMenuItem
            // 
            this.projekcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekcijeNovaToolStripMenuItem,
            this.projekcijeListaToolStripMenuItem});
            this.projekcijeToolStripMenuItem.Enabled = false;
            this.projekcijeToolStripMenuItem.Name = "projekcijeToolStripMenuItem";
            this.projekcijeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.projekcijeToolStripMenuItem.Text = "Projekcije";
            // 
            // projekcijeNovaToolStripMenuItem
            // 
            this.projekcijeNovaToolStripMenuItem.Name = "projekcijeNovaToolStripMenuItem";
            this.projekcijeNovaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.projekcijeNovaToolStripMenuItem.Text = "Nova";
            this.projekcijeNovaToolStripMenuItem.Click += new System.EventHandler(this.projekcijeNovaToolStripMenuItem_Click);
            // 
            // projekcijeListaToolStripMenuItem
            // 
            this.projekcijeListaToolStripMenuItem.Name = "projekcijeListaToolStripMenuItem";
            this.projekcijeListaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.projekcijeListaToolStripMenuItem.Text = "Lista";
            this.projekcijeListaToolStripMenuItem.Click += new System.EventHandler(this.projekcijeListaToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artilkiNoviToolStripMenuItem,
            this.artikliListaToolStripMenuItem});
            this.artikliToolStripMenuItem.Enabled = false;
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // artilkiNoviToolStripMenuItem
            // 
            this.artilkiNoviToolStripMenuItem.Name = "artilkiNoviToolStripMenuItem";
            this.artilkiNoviToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.artilkiNoviToolStripMenuItem.Text = "Novi";
            this.artilkiNoviToolStripMenuItem.Click += new System.EventHandler(this.artilkiNoviToolStripMenuItem_Click);
            // 
            // artikliListaToolStripMenuItem
            // 
            this.artikliListaToolStripMenuItem.Name = "artikliListaToolStripMenuItem";
            this.artikliListaToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.artikliListaToolStripMenuItem.Text = "Lista";
            this.artikliListaToolStripMenuItem.Click += new System.EventHandler(this.artikliListaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervacijeNovaToolStripMenuItem,
            this.rezervacijeListaToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Enabled = false;
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // rezervacijeNovaToolStripMenuItem
            // 
            this.rezervacijeNovaToolStripMenuItem.Name = "rezervacijeNovaToolStripMenuItem";
            this.rezervacijeNovaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.rezervacijeNovaToolStripMenuItem.Text = "Nova";
            this.rezervacijeNovaToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeNovaToolStripMenuItem_Click);
            // 
            // rezervacijeListaToolStripMenuItem
            // 
            this.rezervacijeListaToolStripMenuItem.Name = "rezervacijeListaToolStripMenuItem";
            this.rezervacijeListaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.rezervacijeListaToolStripMenuItem.Text = "Lista";
            this.rezervacijeListaToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeListaToolStripMenuItem_Click);
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodajaNovaToolStripMenuItem,
            this.prodajaListaToolStripMenuItem});
            this.prodajaToolStripMenuItem.Enabled = false;
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.prodajaToolStripMenuItem.Text = "Prodaja";
            // 
            // prodajaNovaToolStripMenuItem
            // 
            this.prodajaNovaToolStripMenuItem.Name = "prodajaNovaToolStripMenuItem";
            this.prodajaNovaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.prodajaNovaToolStripMenuItem.Text = "Nova";
            this.prodajaNovaToolStripMenuItem.Click += new System.EventHandler(this.prodajaNovaToolStripMenuItem_Click);
            // 
            // prodajaListaToolStripMenuItem
            // 
            this.prodajaListaToolStripMenuItem.Name = "prodajaListaToolStripMenuItem";
            this.prodajaListaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.prodajaListaToolStripMenuItem.Text = "Lista";
            this.prodajaListaToolStripMenuItem.Click += new System.EventHandler(this.prodajaListaToolStripMenuItem_Click);
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvjestajiProdajaPoDatumuToolStripMenuItem});
            this.izvjestajiToolStripMenuItem.Enabled = false;
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.izvjestajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // izvjestajiProdajaPoDatumuToolStripMenuItem
            // 
            this.izvjestajiProdajaPoDatumuToolStripMenuItem.Name = "izvjestajiProdajaPoDatumuToolStripMenuItem";
            this.izvjestajiProdajaPoDatumuToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.izvjestajiProdajaPoDatumuToolStripMenuItem.Text = "Prodaja po datumu";
            this.izvjestajiProdajaPoDatumuToolStripMenuItem.Click += new System.EventHandler(this.izvjestajiProdajaPoDatumuToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obavijestiNovaToolStripMenuItem,
            this.obavijestiListaToolStripMenuItem});
            this.obavijestiToolStripMenuItem.Enabled = false;
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            // 
            // obavijestiNovaToolStripMenuItem
            // 
            this.obavijestiNovaToolStripMenuItem.Name = "obavijestiNovaToolStripMenuItem";
            this.obavijestiNovaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.obavijestiNovaToolStripMenuItem.Text = "Nova";
            this.obavijestiNovaToolStripMenuItem.Click += new System.EventHandler(this.obavijestiNovaToolStripMenuItem_Click);
            // 
            // obavijestiListaToolStripMenuItem
            // 
            this.obavijestiListaToolStripMenuItem.Name = "obavijestiListaToolStripMenuItem";
            this.obavijestiListaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.obavijestiListaToolStripMenuItem.Text = "Lista";
            this.obavijestiListaToolStripMenuItem.Click += new System.EventHandler(this.obavijestiListaToolStripMenuItem_Click);
            // 
            // dojmoviToolStripMenuItem
            // 
            this.dojmoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dojmoviListaToolStripMenuItem});
            this.dojmoviToolStripMenuItem.Enabled = false;
            this.dojmoviToolStripMenuItem.Name = "dojmoviToolStripMenuItem";
            this.dojmoviToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.dojmoviToolStripMenuItem.Text = "Dojmovi";
            // 
            // dojmoviListaToolStripMenuItem
            // 
            this.dojmoviListaToolStripMenuItem.Name = "dojmoviListaToolStripMenuItem";
            this.dojmoviListaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dojmoviListaToolStripMenuItem.Text = "Lista";
            this.dojmoviListaToolStripMenuItem.Click += new System.EventHandler(this.dojmoviListaToolStripMenuItem_Click);
            // 
            // UserStatusStrip
            // 
            this.UserStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserToolStripStatus});
            this.UserStatusStrip.Location = new System.Drawing.Point(0, 865);
            this.UserStatusStrip.Name = "UserStatusStrip";
            this.UserStatusStrip.Size = new System.Drawing.Size(1364, 26);
            this.UserStatusStrip.TabIndex = 2;
            this.UserStatusStrip.Text = "statusStrip1";
            // 
            // lblUserToolStripStatus
            // 
            this.lblUserToolStripStatus.Name = "lblUserToolStripStatus";
            this.lblUserToolStripStatus.Size = new System.Drawing.Size(68, 20);
            this.lblUserToolStripStatus.Text = "Korisnik: ";
            // 
            // anketeToolStripMenuItem
            // 
            this.anketeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anketeNovaToolStripMenuItem,
            this.anketeListaToolStripMenuItem});
            this.anketeToolStripMenuItem.Name = "anketeToolStripMenuItem";
            this.anketeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.anketeToolStripMenuItem.Text = "Ankete";
            // 
            // anketeNovaToolStripMenuItem
            // 
            this.anketeNovaToolStripMenuItem.Name = "anketeNovaToolStripMenuItem";
            this.anketeNovaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.anketeNovaToolStripMenuItem.Text = "Nova";
            this.anketeNovaToolStripMenuItem.Click += new System.EventHandler(this.anketeNovaToolStripMenuItem_Click);
            // 
            // anketeListaToolStripMenuItem
            // 
            this.anketeListaToolStripMenuItem.Name = "anketeListaToolStripMenuItem";
            this.anketeListaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.anketeListaToolStripMenuItem.Text = "Lista";
            this.anketeListaToolStripMenuItem.Click += new System.EventHandler(this.anketeListaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 891);
            this.Controls.Add(this.UserStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KinoCentar :: Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.UserStatusStrip.ResumeLayout(false);
            this.UserStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artilkiNoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmoviNoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmoviListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekcijeNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekcijeListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zanroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jediniceMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmskeLicnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dojmoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dojmoviListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaListaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip UserStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUserToolStripStatus;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiProdajaPoDatumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anketeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anketeNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anketeListaToolStripMenuItem;
    }
}


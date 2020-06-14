namespace KinoCentar.WinUI.Forms.FilmskeLicnosti
{
    partial class frmFilmskeLicnostiAdd
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.ckbIsGlumac = new System.Windows.Forms.CheckBox();
            this.ckbIsReziser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(106, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(302, 22);
            this.txtIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(308, 152);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(202, 152);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(106, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(302, 22);
            this.txtPrezime.TabIndex = 3;
            // 
            // ckbIsGlumac
            // 
            this.ckbIsGlumac.AutoSize = true;
            this.ckbIsGlumac.Location = new System.Drawing.Point(106, 102);
            this.ckbIsGlumac.Name = "ckbIsGlumac";
            this.ckbIsGlumac.Size = new System.Drawing.Size(86, 21);
            this.ckbIsGlumac.TabIndex = 4;
            this.ckbIsGlumac.Text = "Glumac?";
            this.ckbIsGlumac.UseVisualStyleBackColor = true;
            // 
            // ckbIsReziser
            // 
            this.ckbIsReziser.AutoSize = true;
            this.ckbIsReziser.Location = new System.Drawing.Point(202, 102);
            this.ckbIsReziser.Name = "ckbIsReziser";
            this.ckbIsReziser.Size = new System.Drawing.Size(86, 21);
            this.ckbIsReziser.TabIndex = 5;
            this.ckbIsReziser.Text = "Režiser?";
            this.ckbIsReziser.UseVisualStyleBackColor = true;
            // 
            // frmFilmskeLicnostiAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 213);
            this.Controls.Add(this.ckbIsReziser);
            this.Controls.Add(this.ckbIsGlumac);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFilmskeLicnostiAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova filmska ličnost";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.CheckBox ckbIsReziser;
        private System.Windows.Forms.CheckBox ckbIsGlumac;
    }
}
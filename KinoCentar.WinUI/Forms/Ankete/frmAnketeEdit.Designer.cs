namespace KinoCentar.WinUI.Forms.Ankete
{
    partial class frmAnketeEdit
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOdgovor5 = new System.Windows.Forms.TextBox();
            this.cbOdgovor5 = new System.Windows.Forms.CheckBox();
            this.txtOdgovor4 = new System.Windows.Forms.TextBox();
            this.cbOdgovor4 = new System.Windows.Forms.CheckBox();
            this.txtOdgovor3 = new System.Windows.Forms.TextBox();
            this.cbOdgovor3 = new System.Windows.Forms.CheckBox();
            this.txtOdgovor2 = new System.Windows.Forms.TextBox();
            this.cbOdgovor2 = new System.Windows.Forms.CheckBox();
            this.txtOdgovor1 = new System.Windows.Forms.TextBox();
            this.cbOdgovor1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(202, 297);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(308, 297);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(86, 36);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(322, 22);
            this.txtNaslov.TabIndex = 7;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOdgovor5);
            this.groupBox1.Controls.Add(this.cbOdgovor5);
            this.groupBox1.Controls.Add(this.txtOdgovor4);
            this.groupBox1.Controls.Add(this.cbOdgovor4);
            this.groupBox1.Controls.Add(this.txtOdgovor3);
            this.groupBox1.Controls.Add(this.cbOdgovor3);
            this.groupBox1.Controls.Add(this.txtOdgovor2);
            this.groupBox1.Controls.Add(this.cbOdgovor2);
            this.groupBox1.Controls.Add(this.txtOdgovor1);
            this.groupBox1.Controls.Add(this.cbOdgovor1);
            this.groupBox1.Location = new System.Drawing.Point(28, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odgovori";
            // 
            // txtOdgovor5
            // 
            this.txtOdgovor5.Location = new System.Drawing.Point(35, 155);
            this.txtOdgovor5.Name = "txtOdgovor5";
            this.txtOdgovor5.ReadOnly = true;
            this.txtOdgovor5.Size = new System.Drawing.Size(330, 22);
            this.txtOdgovor5.TabIndex = 9;
            // 
            // cbOdgovor5
            // 
            this.cbOdgovor5.AutoSize = true;
            this.cbOdgovor5.Location = new System.Drawing.Point(10, 158);
            this.cbOdgovor5.Name = "cbOdgovor5";
            this.cbOdgovor5.Size = new System.Drawing.Size(18, 17);
            this.cbOdgovor5.TabIndex = 8;
            this.cbOdgovor5.UseVisualStyleBackColor = true;
            this.cbOdgovor5.CheckedChanged += new System.EventHandler(this.cbOdgovor5_CheckedChanged);
            // 
            // txtOdgovor4
            // 
            this.txtOdgovor4.Location = new System.Drawing.Point(35, 122);
            this.txtOdgovor4.Name = "txtOdgovor4";
            this.txtOdgovor4.ReadOnly = true;
            this.txtOdgovor4.Size = new System.Drawing.Size(330, 22);
            this.txtOdgovor4.TabIndex = 7;
            // 
            // cbOdgovor4
            // 
            this.cbOdgovor4.AutoSize = true;
            this.cbOdgovor4.Location = new System.Drawing.Point(10, 125);
            this.cbOdgovor4.Name = "cbOdgovor4";
            this.cbOdgovor4.Size = new System.Drawing.Size(18, 17);
            this.cbOdgovor4.TabIndex = 6;
            this.cbOdgovor4.UseVisualStyleBackColor = true;
            this.cbOdgovor4.CheckedChanged += new System.EventHandler(this.cbOdgovor4_CheckedChanged);
            // 
            // txtOdgovor3
            // 
            this.txtOdgovor3.Location = new System.Drawing.Point(35, 89);
            this.txtOdgovor3.Name = "txtOdgovor3";
            this.txtOdgovor3.ReadOnly = true;
            this.txtOdgovor3.Size = new System.Drawing.Size(330, 22);
            this.txtOdgovor3.TabIndex = 5;
            // 
            // cbOdgovor3
            // 
            this.cbOdgovor3.AutoSize = true;
            this.cbOdgovor3.Location = new System.Drawing.Point(10, 92);
            this.cbOdgovor3.Name = "cbOdgovor3";
            this.cbOdgovor3.Size = new System.Drawing.Size(18, 17);
            this.cbOdgovor3.TabIndex = 4;
            this.cbOdgovor3.UseVisualStyleBackColor = true;
            this.cbOdgovor3.CheckedChanged += new System.EventHandler(this.cbOdgovor3_CheckedChanged);
            // 
            // txtOdgovor2
            // 
            this.txtOdgovor2.Location = new System.Drawing.Point(35, 56);
            this.txtOdgovor2.Name = "txtOdgovor2";
            this.txtOdgovor2.ReadOnly = true;
            this.txtOdgovor2.Size = new System.Drawing.Size(330, 22);
            this.txtOdgovor2.TabIndex = 3;
            // 
            // cbOdgovor2
            // 
            this.cbOdgovor2.AutoSize = true;
            this.cbOdgovor2.Location = new System.Drawing.Point(10, 59);
            this.cbOdgovor2.Name = "cbOdgovor2";
            this.cbOdgovor2.Size = new System.Drawing.Size(18, 17);
            this.cbOdgovor2.TabIndex = 2;
            this.cbOdgovor2.UseVisualStyleBackColor = true;
            this.cbOdgovor2.CheckedChanged += new System.EventHandler(this.cbOdgovor2_CheckedChanged);
            // 
            // txtOdgovor1
            // 
            this.txtOdgovor1.Location = new System.Drawing.Point(35, 23);
            this.txtOdgovor1.Name = "txtOdgovor1";
            this.txtOdgovor1.Size = new System.Drawing.Size(330, 22);
            this.txtOdgovor1.TabIndex = 1;
            // 
            // cbOdgovor1
            // 
            this.cbOdgovor1.AutoSize = true;
            this.cbOdgovor1.Checked = true;
            this.cbOdgovor1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOdgovor1.Location = new System.Drawing.Point(10, 26);
            this.cbOdgovor1.Name = "cbOdgovor1";
            this.cbOdgovor1.Size = new System.Drawing.Size(18, 17);
            this.cbOdgovor1.TabIndex = 0;
            this.cbOdgovor1.UseVisualStyleBackColor = true;
            this.cbOdgovor1.CheckedChanged += new System.EventHandler(this.cbOdgovor1_CheckedChanged);
            // 
            // frmAnketeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnketeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi anketu";
            this.Load += new System.EventHandler(this.frmObavijestiEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOdgovor5;
        private System.Windows.Forms.CheckBox cbOdgovor5;
        private System.Windows.Forms.TextBox txtOdgovor4;
        private System.Windows.Forms.CheckBox cbOdgovor4;
        private System.Windows.Forms.TextBox txtOdgovor3;
        private System.Windows.Forms.CheckBox cbOdgovor3;
        private System.Windows.Forms.TextBox txtOdgovor2;
        private System.Windows.Forms.CheckBox cbOdgovor2;
        private System.Windows.Forms.TextBox txtOdgovor1;
        private System.Windows.Forms.CheckBox cbOdgovor1;
    }
}
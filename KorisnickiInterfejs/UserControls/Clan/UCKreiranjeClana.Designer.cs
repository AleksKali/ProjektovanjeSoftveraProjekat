
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCKreiranjeClana
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbKontakt = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblBrojUlice = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbDodajClana = new System.Windows.Forms.GroupBox();
            this.gbDodajClana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(269, 485);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(115, 38);
            this.btnSacuvaj.TabIndex = 46;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // tbBroj
            // 
            this.tbBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBroj.Location = new System.Drawing.Point(179, 351);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(242, 22);
            this.tbBroj.TabIndex = 45;
            // 
            // tbUlica
            // 
            this.tbUlica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUlica.Location = new System.Drawing.Point(179, 298);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(242, 22);
            this.tbUlica.TabIndex = 44;
            // 
            // tbMail
            // 
            this.tbMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMail.Location = new System.Drawing.Point(179, 247);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(242, 22);
            this.tbMail.TabIndex = 43;
            // 
            // tbKontakt
            // 
            this.tbKontakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKontakt.Location = new System.Drawing.Point(179, 199);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(242, 22);
            this.tbKontakt.TabIndex = 42;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbJMBG.Location = new System.Drawing.Point(179, 150);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(242, 22);
            this.tbJMBG.TabIndex = 41;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrezime.Location = new System.Drawing.Point(179, 97);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(242, 22);
            this.tbPrezime.TabIndex = 40;
            // 
            // tbIme
            // 
            this.tbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIme.Location = new System.Drawing.Point(179, 44);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(242, 22);
            this.tbIme.TabIndex = 39;
            // 
            // lblBrojUlice
            // 
            this.lblBrojUlice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojUlice.AutoSize = true;
            this.lblBrojUlice.Location = new System.Drawing.Point(43, 356);
            this.lblBrojUlice.Name = "lblBrojUlice";
            this.lblBrojUlice.Size = new System.Drawing.Size(37, 17);
            this.lblBrojUlice.TabIndex = 36;
            this.lblBrojUlice.Text = "Broj:";
            // 
            // lblUlica
            // 
            this.lblUlica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(43, 298);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(43, 17);
            this.lblUlica.TabIndex = 35;
            this.lblUlica.Text = "Ulica:";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(43, 247);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 17);
            this.lblMail.TabIndex = 34;
            this.lblMail.Text = "Mail:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(43, 199);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(60, 17);
            this.lblKontakt.TabIndex = 33;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // lblJMBG
            // 
            this.lblJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(43, 150);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(50, 17);
            this.lblJMBG.TabIndex = 32;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(43, 97);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 31;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(43, 44);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 30;
            this.lblIme.Text = "Ime:";
            // 
            // gbDodajClana
            // 
            this.gbDodajClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDodajClana.Controls.Add(this.tbBroj);
            this.gbDodajClana.Controls.Add(this.tbUlica);
            this.gbDodajClana.Controls.Add(this.tbMail);
            this.gbDodajClana.Controls.Add(this.tbKontakt);
            this.gbDodajClana.Controls.Add(this.tbJMBG);
            this.gbDodajClana.Controls.Add(this.tbPrezime);
            this.gbDodajClana.Controls.Add(this.tbIme);
            this.gbDodajClana.Controls.Add(this.lblBrojUlice);
            this.gbDodajClana.Controls.Add(this.lblUlica);
            this.gbDodajClana.Controls.Add(this.lblMail);
            this.gbDodajClana.Controls.Add(this.lblKontakt);
            this.gbDodajClana.Controls.Add(this.lblJMBG);
            this.gbDodajClana.Controls.Add(this.lblPrezime);
            this.gbDodajClana.Controls.Add(this.lblIme);
            this.gbDodajClana.Location = new System.Drawing.Point(19, 60);
            this.gbDodajClana.Name = "gbDodajClana";
            this.gbDodajClana.Size = new System.Drawing.Size(484, 407);
            this.gbDodajClana.TabIndex = 47;
            this.gbDodajClana.TabStop = false;
            this.gbDodajClana.Text = "Unesite podatke za člana";
            // 
            // UCKreiranjeClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDodajClana);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "UCKreiranjeClana";
            this.Size = new System.Drawing.Size(531, 594);
            this.gbDodajClana.ResumeLayout(false);
            this.gbDodajClana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblBrojUlice;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.GroupBox gbDodajClana;

        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public TextBox TbBroj { get => tbBroj; set => tbBroj = value; }
        public TextBox TbUlica { get => tbUlica; set => tbUlica = value; }
        public TextBox TbMail { get => tbMail; set => tbMail = value; }
        public TextBox TbKontakt { get => tbKontakt; set => tbKontakt = value; }
        public TextBox TbJMBG { get => tbJMBG; set => tbJMBG = value; }
        public TextBox TbPrezime { get => tbPrezime; set => tbPrezime = value; }
        public TextBox TbIme { get => tbIme; set => tbIme = value; }
        public Label LblBrojUlice { get => lblBrojUlice; set => lblBrojUlice = value; }
        public Label LblUlica { get => lblUlica; set => lblUlica = value; }
        public Label LblMail { get => lblMail; set => lblMail = value; }
        public Label LblKontakt { get => lblKontakt; set => lblKontakt = value; }
        public Label LblJMBG { get => lblJMBG; set => lblJMBG = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public GroupBox GbDodajClana { get => gbDodajClana; set => gbDodajClana = value; }
    }
}

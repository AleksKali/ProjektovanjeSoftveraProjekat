
namespace KorisnickiInterfejs
{
    partial class FrmDetaljiClana
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
            this.lblClanskiBroj = new System.Windows.Forms.Label();
            this.lblDatumUclanjenja = new System.Windows.Forms.Label();
            this.lblTrenutnaZaduzenja = new System.Windows.Forms.Label();
            this.lblClanarina = new System.Windows.Forms.Label();
            this.dgvTrenutnaZaduzenja = new System.Windows.Forms.DataGridView();
            this.gbUnosClana = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
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
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbClanskiBroj = new System.Windows.Forms.TextBox();
            this.tbDatumUclanjenja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutnaZaduzenja)).BeginInit();
            this.gbUnosClana.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(40, 43);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(85, 17);
            this.lblClanskiBroj.TabIndex = 0;
            this.lblClanskiBroj.Text = "Članski broj:";
            // 
            // lblDatumUclanjenja
            // 
            this.lblDatumUclanjenja.AutoSize = true;
            this.lblDatumUclanjenja.Location = new System.Drawing.Point(40, 80);
            this.lblDatumUclanjenja.Name = "lblDatumUclanjenja";
            this.lblDatumUclanjenja.Size = new System.Drawing.Size(121, 17);
            this.lblDatumUclanjenja.TabIndex = 1;
            this.lblDatumUclanjenja.Text = "Datum učlanjenja:";
            // 
            // lblTrenutnaZaduzenja
            // 
            this.lblTrenutnaZaduzenja.AutoSize = true;
            this.lblTrenutnaZaduzenja.Location = new System.Drawing.Point(40, 146);
            this.lblTrenutnaZaduzenja.Name = "lblTrenutnaZaduzenja";
            this.lblTrenutnaZaduzenja.Size = new System.Drawing.Size(173, 17);
            this.lblTrenutnaZaduzenja.TabIndex = 2;
            this.lblTrenutnaZaduzenja.Text = "Trenutna zaduženja člana";
            // 
            // lblClanarina
            // 
            this.lblClanarina.AutoSize = true;
            this.lblClanarina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanarina.Location = new System.Drawing.Point(455, 75);
            this.lblClanarina.Name = "lblClanarina";
            this.lblClanarina.Size = new System.Drawing.Size(258, 24);
            this.lblClanarina.TabIndex = 3;
            this.lblClanarina.Text = "Članarina nije evidentirana";
            this.lblClanarina.Visible = false;
            // 
            // dgvTrenutnaZaduzenja
            // 
            this.dgvTrenutnaZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenutnaZaduzenja.Location = new System.Drawing.Point(43, 178);
            this.dgvTrenutnaZaduzenja.Name = "dgvTrenutnaZaduzenja";
            this.dgvTrenutnaZaduzenja.RowHeadersWidth = 51;
            this.dgvTrenutnaZaduzenja.RowTemplate.Height = 24;
            this.dgvTrenutnaZaduzenja.Size = new System.Drawing.Size(729, 150);
            this.dgvTrenutnaZaduzenja.TabIndex = 4;
            // 
            // gbUnosClana
            // 
            this.gbUnosClana.Controls.Add(this.btnIzmeni);
            this.gbUnosClana.Controls.Add(this.tbBroj);
            this.gbUnosClana.Controls.Add(this.tbUlica);
            this.gbUnosClana.Controls.Add(this.tbMail);
            this.gbUnosClana.Controls.Add(this.tbKontakt);
            this.gbUnosClana.Controls.Add(this.tbJMBG);
            this.gbUnosClana.Controls.Add(this.tbPrezime);
            this.gbUnosClana.Controls.Add(this.tbIme);
            this.gbUnosClana.Controls.Add(this.lblBrojUlice);
            this.gbUnosClana.Controls.Add(this.lblUlica);
            this.gbUnosClana.Controls.Add(this.lblMail);
            this.gbUnosClana.Controls.Add(this.lblJMBG);
            this.gbUnosClana.Controls.Add(this.lblKontakt);
            this.gbUnosClana.Controls.Add(this.lblPrezime);
            this.gbUnosClana.Controls.Add(this.lblIme);
            this.gbUnosClana.Location = new System.Drawing.Point(51, 334);
            this.gbUnosClana.Name = "gbUnosClana";
            this.gbUnosClana.Size = new System.Drawing.Size(721, 391);
            this.gbUnosClana.TabIndex = 5;
            this.gbUnosClana.TabStop = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(224, 342);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(93, 28);
            this.btnIzmeni.TabIndex = 20;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(136, 299);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(265, 22);
            this.tbBroj.TabIndex = 19;
            // 
            // tbUlica
            // 
            this.tbUlica.Location = new System.Drawing.Point(136, 254);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(265, 22);
            this.tbUlica.TabIndex = 18;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(136, 210);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(265, 22);
            this.tbMail.TabIndex = 17;
            // 
            // tbKontakt
            // 
            this.tbKontakt.Location = new System.Drawing.Point(136, 170);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(265, 22);
            this.tbKontakt.TabIndex = 16;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(136, 127);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(265, 22);
            this.tbJMBG.TabIndex = 15;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(136, 82);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(265, 22);
            this.tbPrezime.TabIndex = 14;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(136, 41);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(265, 22);
            this.tbIme.TabIndex = 13;
            // 
            // lblBrojUlice
            // 
            this.lblBrojUlice.AutoSize = true;
            this.lblBrojUlice.Location = new System.Drawing.Point(24, 299);
            this.lblBrojUlice.Name = "lblBrojUlice";
            this.lblBrojUlice.Size = new System.Drawing.Size(37, 17);
            this.lblBrojUlice.TabIndex = 12;
            this.lblBrojUlice.Text = "Broj:";
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(24, 259);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(43, 17);
            this.lblUlica.TabIndex = 11;
            this.lblUlica.Text = "Ulica:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(24, 215);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 17);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail:";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(24, 127);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(50, 17);
            this.lblJMBG.TabIndex = 9;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(24, 170);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(60, 17);
            this.lblKontakt.TabIndex = 8;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(24, 82);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(24, 41);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime:";
            // 
            // tbClanskiBroj
            // 
            this.tbClanskiBroj.Location = new System.Drawing.Point(187, 43);
            this.tbClanskiBroj.Name = "tbClanskiBroj";
            this.tbClanskiBroj.Size = new System.Drawing.Size(151, 22);
            this.tbClanskiBroj.TabIndex = 6;
            // 
            // tbDatumUclanjenja
            // 
            this.tbDatumUclanjenja.Location = new System.Drawing.Point(187, 80);
            this.tbDatumUclanjenja.Name = "tbDatumUclanjenja";
            this.tbDatumUclanjenja.Size = new System.Drawing.Size(151, 22);
            this.tbDatumUclanjenja.TabIndex = 7;
            // 
            // DetaljiClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 737);
            this.Controls.Add(this.tbDatumUclanjenja);
            this.Controls.Add(this.tbClanskiBroj);
            this.Controls.Add(this.gbUnosClana);
            this.Controls.Add(this.dgvTrenutnaZaduzenja);
            this.Controls.Add(this.lblClanarina);
            this.Controls.Add(this.lblTrenutnaZaduzenja);
            this.Controls.Add(this.lblDatumUclanjenja);
            this.Controls.Add(this.lblClanskiBroj);
            this.Name = "FrmDetaljiClana";
            this.Text = "FrmDetaljiClana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutnaZaduzenja)).EndInit();
            this.gbUnosClana.ResumeLayout(false);
            this.gbUnosClana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClanskiBroj;
        private System.Windows.Forms.Label lblDatumUclanjenja;
        private System.Windows.Forms.Label lblTrenutnaZaduzenja;
        private System.Windows.Forms.Label lblClanarina;
        private System.Windows.Forms.DataGridView dgvTrenutnaZaduzenja;
        private System.Windows.Forms.GroupBox gbUnosClana;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojUlice;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbClanskiBroj;
        private System.Windows.Forms.TextBox tbDatumUclanjenja;
        private System.Windows.Forms.Button btnIzmeni;
    }
}
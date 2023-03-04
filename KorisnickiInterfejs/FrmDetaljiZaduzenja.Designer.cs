
namespace KorisnickiInterfejs
{
    partial class FrmDetaljiZaduzenja
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
            this.tbDatumZaduzenja = new System.Windows.Forms.TextBox();
            this.tbZaduzenjeID = new System.Windows.Forms.TextBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.lblDatumZaduzenja = new System.Windows.Forms.Label();
            this.lblZaduzenjeID = new System.Windows.Forms.Label();
            this.dgvSviPrimerci = new System.Windows.Forms.DataGridView();
            this.lblSviPrimerci = new System.Windows.Forms.Label();
            this.btnDetaljiPrimerka = new System.Windows.Forms.Button();
            this.btnIzbrisiPrimerak = new System.Windows.Forms.Button();
            this.gbIzmenaIgrica = new System.Windows.Forms.GroupBox();
            this.cbIgrica = new System.Windows.Forms.ComboBox();
            this.cbPrimerak = new System.Windows.Forms.ComboBox();
            this.lblPrimerak = new System.Windows.Forms.Label();
            this.lblIgrica = new System.Windows.Forms.Label();
            this.btnSacuvajIgricu = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPrimerci)).BeginInit();
            this.gbIzmenaIgrica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDatumZaduzenja
            // 
            this.tbDatumZaduzenja.Location = new System.Drawing.Point(249, 94);
            this.tbDatumZaduzenja.Name = "tbDatumZaduzenja";
            this.tbDatumZaduzenja.Size = new System.Drawing.Size(189, 22);
            this.tbDatumZaduzenja.TabIndex = 11;
            // 
            // tbZaduzenjeID
            // 
            this.tbZaduzenjeID.Location = new System.Drawing.Point(249, 57);
            this.tbZaduzenjeID.Name = "tbZaduzenjeID";
            this.tbZaduzenjeID.Size = new System.Drawing.Size(189, 22);
            this.tbZaduzenjeID.TabIndex = 10;
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(96, 128);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(40, 17);
            this.lblClan.TabIndex = 9;
            this.lblClan.Text = "Član:";
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(249, 128);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(189, 24);
            this.cbClan.TabIndex = 8;
            // 
            // lblDatumZaduzenja
            // 
            this.lblDatumZaduzenja.AutoSize = true;
            this.lblDatumZaduzenja.Location = new System.Drawing.Point(96, 94);
            this.lblDatumZaduzenja.Name = "lblDatumZaduzenja";
            this.lblDatumZaduzenja.Size = new System.Drawing.Size(124, 17);
            this.lblDatumZaduzenja.TabIndex = 7;
            this.lblDatumZaduzenja.Text = "Datum Zaduženja:";
            // 
            // lblZaduzenjeID
            // 
            this.lblZaduzenjeID.AutoSize = true;
            this.lblZaduzenjeID.Location = new System.Drawing.Point(96, 57);
            this.lblZaduzenjeID.Name = "lblZaduzenjeID";
            this.lblZaduzenjeID.Size = new System.Drawing.Size(92, 17);
            this.lblZaduzenjeID.TabIndex = 6;
            this.lblZaduzenjeID.Text = "ZaduzenjeID:";
            // 
            // dgvSviPrimerci
            // 
            this.dgvSviPrimerci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviPrimerci.Location = new System.Drawing.Point(52, 205);
            this.dgvSviPrimerci.Name = "dgvSviPrimerci";
            this.dgvSviPrimerci.RowHeadersWidth = 51;
            this.dgvSviPrimerci.RowTemplate.Height = 24;
            this.dgvSviPrimerci.Size = new System.Drawing.Size(574, 248);
            this.dgvSviPrimerci.TabIndex = 12;
            // 
            // lblSviPrimerci
            // 
            this.lblSviPrimerci.AutoSize = true;
            this.lblSviPrimerci.Location = new System.Drawing.Point(49, 185);
            this.lblSviPrimerci.Name = "lblSviPrimerci";
            this.lblSviPrimerci.Size = new System.Drawing.Size(81, 17);
            this.lblSviPrimerci.TabIndex = 13;
            this.lblSviPrimerci.Text = "Svi primerci";
            // 
            // btnDetaljiPrimerka
            // 
            this.btnDetaljiPrimerka.Location = new System.Drawing.Point(667, 262);
            this.btnDetaljiPrimerka.Name = "btnDetaljiPrimerka";
            this.btnDetaljiPrimerka.Size = new System.Drawing.Size(97, 26);
            this.btnDetaljiPrimerka.TabIndex = 14;
            this.btnDetaljiPrimerka.Text = "Detalji";
            this.btnDetaljiPrimerka.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiPrimerak
            // 
            this.btnIzbrisiPrimerak.Location = new System.Drawing.Point(667, 307);
            this.btnIzbrisiPrimerak.Name = "btnIzbrisiPrimerak";
            this.btnIzbrisiPrimerak.Size = new System.Drawing.Size(97, 26);
            this.btnIzbrisiPrimerak.TabIndex = 15;
            this.btnIzbrisiPrimerak.Text = "Izbrisi";
            this.btnIzbrisiPrimerak.UseVisualStyleBackColor = true;
            // 
            // gbIzmenaIgrica
            // 
            this.gbIzmenaIgrica.Controls.Add(this.cbIgrica);
            this.gbIzmenaIgrica.Controls.Add(this.cbPrimerak);
            this.gbIzmenaIgrica.Controls.Add(this.lblPrimerak);
            this.gbIzmenaIgrica.Controls.Add(this.lblIgrica);
            this.gbIzmenaIgrica.Controls.Add(this.btnSacuvajIgricu);
            this.gbIzmenaIgrica.Location = new System.Drawing.Point(99, 472);
            this.gbIzmenaIgrica.Name = "gbIzmenaIgrica";
            this.gbIzmenaIgrica.Size = new System.Drawing.Size(420, 215);
            this.gbIzmenaIgrica.TabIndex = 16;
            this.gbIzmenaIgrica.TabStop = false;
            this.gbIzmenaIgrica.Text = "Izmena igrica";
            // 
            // cbIgrica
            // 
            this.cbIgrica.FormattingEnabled = true;
            this.cbIgrica.Location = new System.Drawing.Point(165, 44);
            this.cbIgrica.Name = "cbIgrica";
            this.cbIgrica.Size = new System.Drawing.Size(189, 24);
            this.cbIgrica.TabIndex = 7;
            // 
            // cbPrimerak
            // 
            this.cbPrimerak.FormattingEnabled = true;
            this.cbPrimerak.Location = new System.Drawing.Point(165, 93);
            this.cbPrimerak.Name = "cbPrimerak";
            this.cbPrimerak.Size = new System.Drawing.Size(189, 24);
            this.cbPrimerak.TabIndex = 8;
            // 
            // lblPrimerak
            // 
            this.lblPrimerak.AutoSize = true;
            this.lblPrimerak.Location = new System.Drawing.Point(44, 96);
            this.lblPrimerak.Name = "lblPrimerak";
            this.lblPrimerak.Size = new System.Drawing.Size(113, 17);
            this.lblPrimerak.TabIndex = 2;
            this.lblPrimerak.Text = "Izaberi primerak:";
            // 
            // lblIgrica
            // 
            this.lblIgrica.AutoSize = true;
            this.lblIgrica.Location = new System.Drawing.Point(44, 44);
            this.lblIgrica.Name = "lblIgrica";
            this.lblIgrica.Size = new System.Drawing.Size(92, 17);
            this.lblIgrica.TabIndex = 1;
            this.lblIgrica.Text = "Izaberi igricu:";
            // 
            // btnSacuvajIgricu
            // 
            this.btnSacuvajIgricu.Location = new System.Drawing.Point(217, 156);
            this.btnSacuvajIgricu.Name = "btnSacuvajIgricu";
            this.btnSacuvajIgricu.Size = new System.Drawing.Size(75, 28);
            this.btnSacuvajIgricu.TabIndex = 0;
            this.btnSacuvajIgricu.Text = "OK";
            this.btnSacuvajIgricu.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(348, 736);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(135, 29);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj izmene";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // FrmDetaljiZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 812);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbIzmenaIgrica);
            this.Controls.Add(this.btnIzbrisiPrimerak);
            this.Controls.Add(this.btnDetaljiPrimerka);
            this.Controls.Add(this.lblSviPrimerci);
            this.Controls.Add(this.dgvSviPrimerci);
            this.Controls.Add(this.tbDatumZaduzenja);
            this.Controls.Add(this.tbZaduzenjeID);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.lblDatumZaduzenja);
            this.Controls.Add(this.lblZaduzenjeID);
            this.Name = "FrmDetaljiZaduzenja";
            this.Text = "FrmDetaljiZaduzenja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPrimerci)).EndInit();
            this.gbIzmenaIgrica.ResumeLayout(false);
            this.gbIzmenaIgrica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatumZaduzenja;
        private System.Windows.Forms.TextBox tbZaduzenjeID;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.Label lblDatumZaduzenja;
        private System.Windows.Forms.Label lblZaduzenjeID;
        private System.Windows.Forms.DataGridView dgvSviPrimerci;
        private System.Windows.Forms.Label lblSviPrimerci;
        private System.Windows.Forms.Button btnDetaljiPrimerka;
        private System.Windows.Forms.Button btnIzbrisiPrimerak;
        private System.Windows.Forms.GroupBox gbIzmenaIgrica;
        private System.Windows.Forms.ComboBox cbIgrica;
        private System.Windows.Forms.ComboBox cbPrimerak;
        private System.Windows.Forms.Label lblPrimerak;
        private System.Windows.Forms.Label lblIgrica;
        private System.Windows.Forms.Button btnSacuvajIgricu;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
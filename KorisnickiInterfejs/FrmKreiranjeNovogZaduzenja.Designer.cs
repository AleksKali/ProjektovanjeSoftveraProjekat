
namespace KorisnickiInterfejs
{
    partial class FrmKreiranjeNovogZaduzenja
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
            this.lblZaduzenjeID = new System.Windows.Forms.Label();
            this.lblDatumZaduzenja = new System.Windows.Forms.Label();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.tbZaduzenjeID = new System.Windows.Forms.TextBox();
            this.tbDatumZaduzenja = new System.Windows.Forms.TextBox();
            this.gbIgrica = new System.Windows.Forms.GroupBox();
            this.btnSacuvajIgricu = new System.Windows.Forms.Button();
            this.btnSacuvajZaduzenje = new System.Windows.Forms.Button();
            this.lblIgrica = new System.Windows.Forms.Label();
            this.lblPrimerak = new System.Windows.Forms.Label();
            this.cbIgrica = new System.Windows.Forms.ComboBox();
            this.cbPrimerak = new System.Windows.Forms.ComboBox();
            this.gbIgrica.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZaduzenjeID
            // 
            this.lblZaduzenjeID.AutoSize = true;
            this.lblZaduzenjeID.Location = new System.Drawing.Point(66, 50);
            this.lblZaduzenjeID.Name = "lblZaduzenjeID";
            this.lblZaduzenjeID.Size = new System.Drawing.Size(92, 17);
            this.lblZaduzenjeID.TabIndex = 0;
            this.lblZaduzenjeID.Text = "ZaduzenjeID:";
            // 
            // lblDatumZaduzenja
            // 
            this.lblDatumZaduzenja.AutoSize = true;
            this.lblDatumZaduzenja.Location = new System.Drawing.Point(66, 87);
            this.lblDatumZaduzenja.Name = "lblDatumZaduzenja";
            this.lblDatumZaduzenja.Size = new System.Drawing.Size(124, 17);
            this.lblDatumZaduzenja.TabIndex = 1;
            this.lblDatumZaduzenja.Text = "Datum Zaduženja:";
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(219, 118);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(189, 24);
            this.cbClan.TabIndex = 2;
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(66, 118);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(92, 17);
            this.lblClan.TabIndex = 3;
            this.lblClan.Text = "Izaberi člana:";
            // 
            // tbZaduzenjeID
            // 
            this.tbZaduzenjeID.Location = new System.Drawing.Point(219, 50);
            this.tbZaduzenjeID.Name = "tbZaduzenjeID";
            this.tbZaduzenjeID.Size = new System.Drawing.Size(189, 22);
            this.tbZaduzenjeID.TabIndex = 4;
            // 
            // tbDatumZaduzenja
            // 
            this.tbDatumZaduzenja.Location = new System.Drawing.Point(219, 87);
            this.tbDatumZaduzenja.Name = "tbDatumZaduzenja";
            this.tbDatumZaduzenja.Size = new System.Drawing.Size(189, 22);
            this.tbDatumZaduzenja.TabIndex = 5;
            // 
            // gbIgrica
            // 
            this.gbIgrica.Controls.Add(this.cbIgrica);
            this.gbIgrica.Controls.Add(this.cbPrimerak);
            this.gbIgrica.Controls.Add(this.lblPrimerak);
            this.gbIgrica.Controls.Add(this.lblIgrica);
            this.gbIgrica.Controls.Add(this.btnSacuvajIgricu);
            this.gbIgrica.Location = new System.Drawing.Point(55, 188);
            this.gbIgrica.Name = "gbIgrica";
            this.gbIgrica.Size = new System.Drawing.Size(446, 252);
            this.gbIgrica.TabIndex = 6;
            this.gbIgrica.TabStop = false;
            this.gbIgrica.Text = "Unos igrice";
            // 
            // btnSacuvajIgricu
            // 
            this.btnSacuvajIgricu.Location = new System.Drawing.Point(216, 187);
            this.btnSacuvajIgricu.Name = "btnSacuvajIgricu";
            this.btnSacuvajIgricu.Size = new System.Drawing.Size(75, 28);
            this.btnSacuvajIgricu.TabIndex = 0;
            this.btnSacuvajIgricu.Text = "OK";
            this.btnSacuvajIgricu.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajZaduzenje
            // 
            this.btnSacuvajZaduzenje.Location = new System.Drawing.Point(219, 460);
            this.btnSacuvajZaduzenje.Name = "btnSacuvajZaduzenje";
            this.btnSacuvajZaduzenje.Size = new System.Drawing.Size(75, 29);
            this.btnSacuvajZaduzenje.TabIndex = 1;
            this.btnSacuvajZaduzenje.Text = "Sačuvaj";
            this.btnSacuvajZaduzenje.UseVisualStyleBackColor = true;
            // 
            // lblIgrica
            // 
            this.lblIgrica.AutoSize = true;
            this.lblIgrica.Location = new System.Drawing.Point(43, 75);
            this.lblIgrica.Name = "lblIgrica";
            this.lblIgrica.Size = new System.Drawing.Size(92, 17);
            this.lblIgrica.TabIndex = 1;
            this.lblIgrica.Text = "Izaberi igricu:";
            // 
            // lblPrimerak
            // 
            this.lblPrimerak.AutoSize = true;
            this.lblPrimerak.Location = new System.Drawing.Point(43, 127);
            this.lblPrimerak.Name = "lblPrimerak";
            this.lblPrimerak.Size = new System.Drawing.Size(113, 17);
            this.lblPrimerak.TabIndex = 2;
            this.lblPrimerak.Text = "Izaberi primerak:";
            // 
            // cbIgrica
            // 
            this.cbIgrica.FormattingEnabled = true;
            this.cbIgrica.Location = new System.Drawing.Point(164, 75);
            this.cbIgrica.Name = "cbIgrica";
            this.cbIgrica.Size = new System.Drawing.Size(189, 24);
            this.cbIgrica.TabIndex = 7;
            // 
            // cbPrimerak
            // 
            this.cbPrimerak.FormattingEnabled = true;
            this.cbPrimerak.Location = new System.Drawing.Point(164, 124);
            this.cbPrimerak.Name = "cbPrimerak";
            this.cbPrimerak.Size = new System.Drawing.Size(189, 24);
            this.cbPrimerak.TabIndex = 8;
            // 
            // FrmKreiranjeNovogZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 549);
            this.Controls.Add(this.btnSacuvajZaduzenje);
            this.Controls.Add(this.gbIgrica);
            this.Controls.Add(this.tbDatumZaduzenja);
            this.Controls.Add(this.tbZaduzenjeID);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.lblDatumZaduzenja);
            this.Controls.Add(this.lblZaduzenjeID);
            this.Name = "FrmKreiranjeNovogZaduzenja";
            this.Text = "Zaduzenja";
            this.gbIgrica.ResumeLayout(false);
            this.gbIgrica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZaduzenjeID;
        private System.Windows.Forms.Label lblDatumZaduzenja;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.TextBox tbZaduzenjeID;
        private System.Windows.Forms.TextBox tbDatumZaduzenja;
        private System.Windows.Forms.GroupBox gbIgrica;
        private System.Windows.Forms.ComboBox cbIgrica;
        private System.Windows.Forms.ComboBox cbPrimerak;
        private System.Windows.Forms.Label lblPrimerak;
        private System.Windows.Forms.Label lblIgrica;
        private System.Windows.Forms.Button btnSacuvajIgricu;
        private System.Windows.Forms.Button btnSacuvajZaduzenje;
    }
}
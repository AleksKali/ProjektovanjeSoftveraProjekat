
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Zaduzenje
{
    partial class UCKreiranjeZaduzenja
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
            this.btnSacuvajZaduzenje = new System.Windows.Forms.Button();
            this.gbIgrica = new System.Windows.Forms.GroupBox();
            this.cbIgrica = new System.Windows.Forms.ComboBox();
            this.cbPrimerak = new System.Windows.Forms.ComboBox();
            this.lblPrimerak = new System.Windows.Forms.Label();
            this.lblIgrica = new System.Windows.Forms.Label();
            this.btnSacuvajIgricu = new System.Windows.Forms.Button();
            this.lblClan = new System.Windows.Forms.Label();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIzbrisiRed = new System.Windows.Forms.Button();
            this.dgvPrimerci = new System.Windows.Forms.DataGridView();
            this.lblGreska = new System.Windows.Forms.Label();
            this.gbIgrica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajZaduzenje
            // 
            this.btnSacuvajZaduzenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajZaduzenje.Location = new System.Drawing.Point(295, 611);
            this.btnSacuvajZaduzenje.Name = "btnSacuvajZaduzenje";
            this.btnSacuvajZaduzenje.Size = new System.Drawing.Size(88, 34);
            this.btnSacuvajZaduzenje.TabIndex = 8;
            this.btnSacuvajZaduzenje.Text = "Sačuvaj";
            this.btnSacuvajZaduzenje.UseVisualStyleBackColor = true;
            // 
            // gbIgrica
            // 
            this.gbIgrica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbIgrica.Controls.Add(this.cbIgrica);
            this.gbIgrica.Controls.Add(this.cbPrimerak);
            this.gbIgrica.Controls.Add(this.lblPrimerak);
            this.gbIgrica.Controls.Add(this.lblIgrica);
            this.gbIgrica.Controls.Add(this.btnSacuvajIgricu);
            this.gbIgrica.Location = new System.Drawing.Point(104, 156);
            this.gbIgrica.Name = "gbIgrica";
            this.gbIgrica.Size = new System.Drawing.Size(446, 252);
            this.gbIgrica.TabIndex = 14;
            this.gbIgrica.TabStop = false;
            this.gbIgrica.Text = "Unos igrice";
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
            // lblPrimerak
            // 
            this.lblPrimerak.AutoSize = true;
            this.lblPrimerak.Location = new System.Drawing.Point(43, 127);
            this.lblPrimerak.Name = "lblPrimerak";
            this.lblPrimerak.Size = new System.Drawing.Size(113, 17);
            this.lblPrimerak.TabIndex = 2;
            this.lblPrimerak.Text = "Izaberi primerak:";
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
            // btnSacuvajIgricu
            // 
            this.btnSacuvajIgricu.Location = new System.Drawing.Point(216, 187);
            this.btnSacuvajIgricu.Name = "btnSacuvajIgricu";
            this.btnSacuvajIgricu.Size = new System.Drawing.Size(75, 28);
            this.btnSacuvajIgricu.TabIndex = 0;
            this.btnSacuvajIgricu.Text = "OK";
            this.btnSacuvajIgricu.UseVisualStyleBackColor = true;
            // 
            // lblClan
            // 
            this.lblClan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(109, 100);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(92, 17);
            this.lblClan.TabIndex = 11;
            this.lblClan.Text = "Izaberi člana:";
            // 
            // cbClan
            // 
            this.cbClan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(262, 100);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(242, 24);
            this.cbClan.TabIndex = 10;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(81, 210);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 18;
            // 
            // btnIzbrisiRed
            // 
            this.btnIzbrisiRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbrisiRed.Location = new System.Drawing.Point(558, 443);
            this.btnIzbrisiRed.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisiRed.Name = "btnIzbrisiRed";
            this.btnIzbrisiRed.Size = new System.Drawing.Size(99, 29);
            this.btnIzbrisiRed.TabIndex = 17;
            this.btnIzbrisiRed.Text = "Izbrisi red";
            this.btnIzbrisiRed.UseVisualStyleBackColor = true;
            // 
            // dgvPrimerci
            // 
            this.dgvPrimerci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrimerci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerci.Location = new System.Drawing.Point(104, 419);
            this.dgvPrimerci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrimerci.Name = "dgvPrimerci";
            this.dgvPrimerci.RowHeadersWidth = 51;
            this.dgvPrimerci.Size = new System.Drawing.Size(446, 174);
            this.dgvPrimerci.TabIndex = 16;
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Location = new System.Drawing.Point(81, 620);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(0, 17);
            this.lblGreska.TabIndex = 19;
            this.lblGreska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCKreiranjeZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIzbrisiRed);
            this.Controls.Add(this.dgvPrimerci);
            this.Controls.Add(this.btnSacuvajZaduzenje);
            this.Controls.Add(this.gbIgrica);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.cbClan);
            this.Name = "UCKreiranjeZaduzenja";
            this.Size = new System.Drawing.Size(677, 748);
            this.gbIgrica.ResumeLayout(false);
            this.gbIgrica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajZaduzenje;
        private System.Windows.Forms.GroupBox gbIgrica;
        private System.Windows.Forms.ComboBox cbIgrica;
        private System.Windows.Forms.ComboBox cbPrimerak;
        private System.Windows.Forms.Label lblPrimerak;
        private System.Windows.Forms.Label lblIgrica;
        private System.Windows.Forms.Button btnSacuvajIgricu;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIzbrisiRed;
        private System.Windows.Forms.DataGridView dgvPrimerci;
        private System.Windows.Forms.Label lblGreska;

        public Button BtnSacuvajZaduzenje { get => btnSacuvajZaduzenje; set => btnSacuvajZaduzenje = value; }
        public GroupBox GbIgrica { get => gbIgrica; set => gbIgrica = value; }
        public ComboBox CbIgrica { get => cbIgrica; set => cbIgrica = value; }
        public ComboBox CbPrimerak { get => cbPrimerak; set => cbPrimerak = value; }
        public Label LblPrimerak { get => lblPrimerak; set => lblPrimerak = value; }
        public Label LblIgrica { get => lblIgrica; set => lblIgrica = value; }
        public Button BtnSacuvajIgricu { get => btnSacuvajIgricu; set => btnSacuvajIgricu = value; }
        public Label LblClan { get => lblClan; set => lblClan = value; }
        public ComboBox CbClan { get => cbClan; set => cbClan = value; }
        public Label LblError { get => lblError; set => lblError = value; }
        public Button BtnIzbrisiRed { get => btnIzbrisiRed; set => btnIzbrisiRed = value; }
        public DataGridView DgvPrimerci { get => dgvPrimerci; set => dgvPrimerci = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
    }
}


using System.Windows.Forms;

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
            this.lblDatumZaduzenja = new System.Windows.Forms.Label();
            this.lblZaduzenjeID = new System.Windows.Forms.Label();
            this.dgvSviPrimerci = new System.Windows.Forms.DataGridView();
            this.lblSviPrimerci = new System.Windows.Forms.Label();
            this.btnRazduziSve = new System.Windows.Forms.Button();
            this.btnRazduziIgricu = new System.Windows.Forms.Button();
            this.tbClan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPrimerci)).BeginInit();
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
            // btnRazduziSve
            // 
            this.btnRazduziSve.Location = new System.Drawing.Point(281, 491);
            this.btnRazduziSve.Name = "btnRazduziSve";
            this.btnRazduziSve.Size = new System.Drawing.Size(117, 40);
            this.btnRazduziSve.TabIndex = 14;
            this.btnRazduziSve.Text = "Razduži sve";
            this.btnRazduziSve.UseVisualStyleBackColor = true;
            // 
            // btnRazduziIgricu
            // 
            this.btnRazduziIgricu.Location = new System.Drawing.Point(645, 228);
            this.btnRazduziIgricu.Name = "btnRazduziIgricu";
            this.btnRazduziIgricu.Size = new System.Drawing.Size(148, 30);
            this.btnRazduziIgricu.TabIndex = 18;
            this.btnRazduziIgricu.Text = "Razduži primerak";
            this.btnRazduziIgricu.UseVisualStyleBackColor = true;
            // 
            // tbClan
            // 
            this.tbClan.Location = new System.Drawing.Point(249, 128);
            this.tbClan.Name = "tbClan";
            this.tbClan.Size = new System.Drawing.Size(189, 22);
            this.tbClan.TabIndex = 19;
            // 
            // FrmDetaljiZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 812);
            this.Controls.Add(this.tbClan);
            this.Controls.Add(this.btnRazduziIgricu);
            this.Controls.Add(this.btnRazduziSve);
            this.Controls.Add(this.lblSviPrimerci);
            this.Controls.Add(this.dgvSviPrimerci);
            this.Controls.Add(this.tbDatumZaduzenja);
            this.Controls.Add(this.tbZaduzenjeID);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.lblDatumZaduzenja);
            this.Controls.Add(this.lblZaduzenjeID);
            this.Name = "FrmDetaljiZaduzenja";
            this.Text = "FrmDetaljiZaduzenja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPrimerci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatumZaduzenja;
        private System.Windows.Forms.TextBox tbZaduzenjeID;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Label lblDatumZaduzenja;
        private System.Windows.Forms.Label lblZaduzenjeID;
        private System.Windows.Forms.DataGridView dgvSviPrimerci;
        private System.Windows.Forms.Label lblSviPrimerci;
        private System.Windows.Forms.Button btnRazduziSve;
        private System.Windows.Forms.Button btnRazduziIgricu;
        private System.Windows.Forms.TextBox tbClan;

        public TextBox TbDatumZaduzenja { get => tbDatumZaduzenja; set => tbDatumZaduzenja = value; }
        public TextBox TbZaduzenjeID { get => tbZaduzenjeID; set => tbZaduzenjeID = value; }
        public Label LblClan { get => lblClan; set => lblClan = value; }
        public Label LblDatumZaduzenja { get => lblDatumZaduzenja; set => lblDatumZaduzenja = value; }
        public Label LblZaduzenjeID { get => lblZaduzenjeID; set => lblZaduzenjeID = value; }
        public DataGridView DgvSviPrimerci { get => dgvSviPrimerci; set => dgvSviPrimerci = value; }
        public Label LblSviPrimerci { get => lblSviPrimerci; set => lblSviPrimerci = value; }
        public Button BtnRazduziSve { get => btnRazduziSve; set => btnRazduziSve = value; }
        public Button BtnRazduziIgricu { get => btnRazduziIgricu; set => btnRazduziIgricu = value; }
        public TextBox TbClan { get => tbClan; set => tbClan = value; }
    }
}
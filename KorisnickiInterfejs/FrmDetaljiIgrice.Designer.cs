
namespace KorisnickiInterfejs
{
    partial class FrmDetaljiIgrice
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
            this.lblIgricaID = new System.Windows.Forms.Label();
            this.lblNazivIgrice = new System.Windows.Forms.Label();
            this.lblNazivProizvodjaca = new System.Windows.Forms.Label();
            this.lblPrimerci = new System.Windows.Forms.Label();
            this.dgvPrimerci = new System.Windows.Forms.DataGridView();
            this.tbIgricaID = new System.Windows.Forms.TextBox();
            this.tbNazivIgrice = new System.Windows.Forms.TextBox();
            this.tbNazivProizvodjaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIgricaID
            // 
            this.lblIgricaID.AutoSize = true;
            this.lblIgricaID.Location = new System.Drawing.Point(82, 42);
            this.lblIgricaID.Name = "lblIgricaID";
            this.lblIgricaID.Size = new System.Drawing.Size(59, 17);
            this.lblIgricaID.TabIndex = 0;
            this.lblIgricaID.Text = "IgricaID:";
            // 
            // lblNazivIgrice
            // 
            this.lblNazivIgrice.AutoSize = true;
            this.lblNazivIgrice.Location = new System.Drawing.Point(82, 82);
            this.lblNazivIgrice.Name = "lblNazivIgrice";
            this.lblNazivIgrice.Size = new System.Drawing.Size(85, 17);
            this.lblNazivIgrice.TabIndex = 1;
            this.lblNazivIgrice.Text = "Naziv igrice:";
            // 
            // lblNazivProizvodjaca
            // 
            this.lblNazivProizvodjaca.AutoSize = true;
            this.lblNazivProizvodjaca.Location = new System.Drawing.Point(82, 124);
            this.lblNazivProizvodjaca.Name = "lblNazivProizvodjaca";
            this.lblNazivProizvodjaca.Size = new System.Drawing.Size(128, 17);
            this.lblNazivProizvodjaca.TabIndex = 2;
            this.lblNazivProizvodjaca.Text = "Naziv proizvođača:";
            // 
            // lblPrimerci
            // 
            this.lblPrimerci.AutoSize = true;
            this.lblPrimerci.Location = new System.Drawing.Point(35, 187);
            this.lblPrimerci.Name = "lblPrimerci";
            this.lblPrimerci.Size = new System.Drawing.Size(59, 17);
            this.lblPrimerci.TabIndex = 3;
            this.lblPrimerci.Text = "Primerci";
            // 
            // dgvPrimerci
            // 
            this.dgvPrimerci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerci.Location = new System.Drawing.Point(38, 218);
            this.dgvPrimerci.Name = "dgvPrimerci";
            this.dgvPrimerci.RowHeadersWidth = 51;
            this.dgvPrimerci.RowTemplate.Height = 24;
            this.dgvPrimerci.Size = new System.Drawing.Size(642, 231);
            this.dgvPrimerci.TabIndex = 4;
            // 
            // tbIgricaID
            // 
            this.tbIgricaID.Location = new System.Drawing.Point(263, 42);
            this.tbIgricaID.Name = "tbIgricaID";
            this.tbIgricaID.Size = new System.Drawing.Size(212, 22);
            this.tbIgricaID.TabIndex = 5;
            // 
            // tbNazivIgrice
            // 
            this.tbNazivIgrice.Location = new System.Drawing.Point(263, 82);
            this.tbNazivIgrice.Name = "tbNazivIgrice";
            this.tbNazivIgrice.Size = new System.Drawing.Size(212, 22);
            this.tbNazivIgrice.TabIndex = 6;
            // 
            // tbNazivProizvodjaca
            // 
            this.tbNazivProizvodjaca.Location = new System.Drawing.Point(263, 124);
            this.tbNazivProizvodjaca.Name = "tbNazivProizvodjaca";
            this.tbNazivProizvodjaca.Size = new System.Drawing.Size(212, 22);
            this.tbNazivProizvodjaca.TabIndex = 7;
            // 
            // DetaljiIgrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 485);
            this.Controls.Add(this.tbNazivProizvodjaca);
            this.Controls.Add(this.tbNazivIgrice);
            this.Controls.Add(this.tbIgricaID);
            this.Controls.Add(this.dgvPrimerci);
            this.Controls.Add(this.lblPrimerci);
            this.Controls.Add(this.lblNazivProizvodjaca);
            this.Controls.Add(this.lblNazivIgrice);
            this.Controls.Add(this.lblIgricaID);
            this.Name = "DetaljiIgrice";
            this.Text = "DetaljiIgrice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIgricaID;
        private System.Windows.Forms.Label lblNazivIgrice;
        private System.Windows.Forms.Label lblNazivProizvodjaca;
        private System.Windows.Forms.Label lblPrimerci;
        private System.Windows.Forms.DataGridView dgvPrimerci;
        private System.Windows.Forms.TextBox tbIgricaID;
        private System.Windows.Forms.TextBox tbNazivIgrice;
        private System.Windows.Forms.TextBox tbNazivProizvodjaca;
    }
}
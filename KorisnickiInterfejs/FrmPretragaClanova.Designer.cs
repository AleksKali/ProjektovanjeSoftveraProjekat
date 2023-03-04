
namespace KorisnickiInterfejs
{
    partial class FrmPretragaClanova
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
            this.tbClanskiBroj = new System.Windows.Forms.TextBox();
            this.dgvClanPretraga = new System.Windows.Forms.DataGridView();
            this.btnPronadjiClanove = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnObrisiClana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(76, 38);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(135, 17);
            this.lblClanskiBroj.TabIndex = 0;
            this.lblClanskiBroj.Text = "Unesite članski broj:";
            // 
            // tbClanskiBroj
            // 
            this.tbClanskiBroj.Location = new System.Drawing.Point(265, 38);
            this.tbClanskiBroj.Name = "tbClanskiBroj";
            this.tbClanskiBroj.Size = new System.Drawing.Size(204, 22);
            this.tbClanskiBroj.TabIndex = 1;
            // 
            // dgvClanPretraga
            // 
            this.dgvClanPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanPretraga.Location = new System.Drawing.Point(64, 102);
            this.dgvClanPretraga.Name = "dgvClanPretraga";
            this.dgvClanPretraga.RowHeadersWidth = 51;
            this.dgvClanPretraga.RowTemplate.Height = 24;
            this.dgvClanPretraga.Size = new System.Drawing.Size(512, 520);
            this.dgvClanPretraga.TabIndex = 2;
            // 
            // btnPronadjiClanove
            // 
            this.btnPronadjiClanove.Location = new System.Drawing.Point(544, 35);
            this.btnPronadjiClanove.Name = "btnPronadjiClanove";
            this.btnPronadjiClanove.Size = new System.Drawing.Size(146, 29);
            this.btnPronadjiClanove.TabIndex = 6;
            this.btnPronadjiClanove.Text = "Pronađi članove";
            this.btnPronadjiClanove.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(634, 138);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(118, 28);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.Location = new System.Drawing.Point(634, 186);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(118, 28);
            this.btnObrisiClana.TabIndex = 8;
            this.btnObrisiClana.Text = "Obriši člana";
            this.btnObrisiClana.UseVisualStyleBackColor = true;
            // 
            // FrmPretragaClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.btnObrisiClana);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnPronadjiClanove);
            this.Controls.Add(this.dgvClanPretraga);
            this.Controls.Add(this.tbClanskiBroj);
            this.Controls.Add(this.lblClanskiBroj);
            this.Name = "FrmPretragaClanova";
            this.Text = "PretragaClanova";
            this.Load += new System.EventHandler(this.FrmPretragaClanova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClanskiBroj;
        private System.Windows.Forms.TextBox tbClanskiBroj;
        private System.Windows.Forms.DataGridView dgvClanPretraga;
        private System.Windows.Forms.Button btnPronadjiClanove;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnObrisiClana;
    }
}
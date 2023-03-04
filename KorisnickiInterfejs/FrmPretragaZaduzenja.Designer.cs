
namespace KorisnickiInterfejs
{
    partial class FrmPretragaZaduzenja
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
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.dgvZaduzenja = new System.Windows.Forms.DataGridView();
            this.btnPronadjiZaduzenja = new System.Windows.Forms.Button();
            this.tbClanskiBroj = new System.Windows.Forms.TextBox();
            this.lblClanskiBroj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(829, 173);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(97, 32);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(829, 126);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(97, 32);
            this.btnRazduzi.TabIndex = 6;
            this.btnRazduzi.Text = "Razduži";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            // 
            // dgvZaduzenja
            // 
            this.dgvZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenja.Location = new System.Drawing.Point(34, 110);
            this.dgvZaduzenja.Name = "dgvZaduzenja";
            this.dgvZaduzenja.RowHeadersWidth = 51;
            this.dgvZaduzenja.RowTemplate.Height = 24;
            this.dgvZaduzenja.Size = new System.Drawing.Size(758, 465);
            this.dgvZaduzenja.TabIndex = 5;
            // 
            // btnPronadjiZaduzenja
            // 
            this.btnPronadjiZaduzenja.Location = new System.Drawing.Point(549, 51);
            this.btnPronadjiZaduzenja.Name = "btnPronadjiZaduzenja";
            this.btnPronadjiZaduzenja.Size = new System.Drawing.Size(146, 29);
            this.btnPronadjiZaduzenja.TabIndex = 10;
            this.btnPronadjiZaduzenja.Text = "Pronađi zaduženja";
            this.btnPronadjiZaduzenja.UseVisualStyleBackColor = true;
            // 
            // tbClanskiBroj
            // 
            this.tbClanskiBroj.Location = new System.Drawing.Point(270, 54);
            this.tbClanskiBroj.Name = "tbClanskiBroj";
            this.tbClanskiBroj.Size = new System.Drawing.Size(204, 22);
            this.tbClanskiBroj.TabIndex = 9;
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(81, 54);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(135, 17);
            this.lblClanskiBroj.TabIndex = 8;
            this.lblClanskiBroj.Text = "Unesite članski broj:";
            // 
            // FrmPretragaZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 606);
            this.Controls.Add(this.btnPronadjiZaduzenja);
            this.Controls.Add(this.tbClanskiBroj);
            this.Controls.Add(this.lblClanskiBroj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.dgvZaduzenja);
            this.Name = "FrmPretragaZaduzenja";
            this.Text = "FrmPretragaZaduzenja";
            this.Load += new System.EventHandler(this.FrmPretragaZaduzenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.DataGridView dgvZaduzenja;
        private System.Windows.Forms.Button btnPronadjiZaduzenja;
        private System.Windows.Forms.TextBox tbClanskiBroj;
        private System.Windows.Forms.Label lblClanskiBroj;
    }
}
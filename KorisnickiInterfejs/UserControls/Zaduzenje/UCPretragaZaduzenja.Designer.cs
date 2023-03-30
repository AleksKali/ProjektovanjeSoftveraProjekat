
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Zaduzenje
{
    partial class UCPretragaZaduzenja
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
            this.tbClanskiBroj = new System.Windows.Forms.TextBox();
            this.lblClanskiBroj = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.dgvZaduzenja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClanskiBroj
            // 
            this.tbClanskiBroj.Location = new System.Drawing.Point(379, 36);
            this.tbClanskiBroj.Name = "tbClanskiBroj";
            this.tbClanskiBroj.Size = new System.Drawing.Size(204, 22);
            this.tbClanskiBroj.TabIndex = 15;
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(95, 38);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(266, 17);
            this.lblClanskiBroj.TabIndex = 14;
            this.lblClanskiBroj.Text = "Unesi članski broj ILI ime i prezime člana:";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(846, 155);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(97, 32);
            this.btnDetalji.TabIndex = 13;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(846, 108);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(97, 32);
            this.btnRazduzi.TabIndex = 12;
            this.btnRazduzi.Text = "Razduži";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            // 
            // dgvZaduzenja
            // 
            this.dgvZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenja.Location = new System.Drawing.Point(51, 92);
            this.dgvZaduzenja.Name = "dgvZaduzenja";
            this.dgvZaduzenja.RowHeadersWidth = 51;
            this.dgvZaduzenja.RowTemplate.Height = 24;
            this.dgvZaduzenja.Size = new System.Drawing.Size(758, 465);
            this.dgvZaduzenja.TabIndex = 11;
            // 
            // UCPretragaZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbClanskiBroj);
            this.Controls.Add(this.lblClanskiBroj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.dgvZaduzenja);
            this.Name = "UCPretragaZaduzenja";
            this.Size = new System.Drawing.Size(963, 593);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbClanskiBroj;
        private System.Windows.Forms.Label lblClanskiBroj;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.DataGridView dgvZaduzenja;

        
        public TextBox TbClanskiBroj { get => tbClanskiBroj; set => tbClanskiBroj = value; }
        public Label LblClanskiBroj { get => lblClanskiBroj; set => lblClanskiBroj = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
        public Button BtnRazduzi { get => btnRazduzi; set => btnRazduzi = value; }
        public DataGridView DgvZaduzenja { get => dgvZaduzenja; set => dgvZaduzenja = value; }
    }
}

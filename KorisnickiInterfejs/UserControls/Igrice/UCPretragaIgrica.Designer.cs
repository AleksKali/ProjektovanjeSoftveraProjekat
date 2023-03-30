
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Igrice
{
    partial class UCPretragaIgrica
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
            this.dgvPretragaIgrica = new System.Windows.Forms.DataGridView();
            this.tbImeIgrice = new System.Windows.Forms.TextBox();
            this.lblimeIgrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaIgrica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPretragaIgrica
            // 
            this.dgvPretragaIgrica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPretragaIgrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaIgrica.Location = new System.Drawing.Point(72, 155);
            this.dgvPretragaIgrica.Name = "dgvPretragaIgrica";
            this.dgvPretragaIgrica.RowHeadersWidth = 51;
            this.dgvPretragaIgrica.RowTemplate.Height = 24;
            this.dgvPretragaIgrica.Size = new System.Drawing.Size(456, 268);
            this.dgvPretragaIgrica.TabIndex = 12;
            // 
            // tbImeIgrice
            // 
            this.tbImeIgrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImeIgrice.Location = new System.Drawing.Point(318, 110);
            this.tbImeIgrice.Name = "tbImeIgrice";
            this.tbImeIgrice.Size = new System.Drawing.Size(204, 22);
            this.tbImeIgrice.TabIndex = 13;
            // 
            // lblimeIgrice
            // 
            this.lblimeIgrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblimeIgrice.AutoSize = true;
            this.lblimeIgrice.Location = new System.Drawing.Point(82, 113);
            this.lblimeIgrice.Name = "lblimeIgrice";
            this.lblimeIgrice.Size = new System.Drawing.Size(217, 17);
            this.lblimeIgrice.TabIndex = 14;
            this.lblimeIgrice.Text = "Unesi naziv igrice ili proizvođača:";
            // 
            // UCPretragaIgrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblimeIgrice);
            this.Controls.Add(this.tbImeIgrice);
            this.Controls.Add(this.dgvPretragaIgrica);
            this.Name = "UCPretragaIgrica";
            this.Size = new System.Drawing.Size(613, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaIgrica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPretragaIgrica;
        private System.Windows.Forms.TextBox tbImeIgrice;
        private System.Windows.Forms.Label lblimeIgrice;

        public DataGridView DgvPretragaIgrica { get => dgvPretragaIgrica; set => dgvPretragaIgrica = value; }
        public TextBox TbImeIgrice { get => tbImeIgrice; set => tbImeIgrice = value; }
        public Label LblimeIgrice { get => lblimeIgrice; set => lblimeIgrice = value; }
    }
}

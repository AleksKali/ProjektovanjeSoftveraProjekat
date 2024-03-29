﻿
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCPretragaClanova
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
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvClanPretraga = new System.Windows.Forms.DataGridView();
            this.tbImeClana = new System.Windows.Forms.TextBox();
            this.lblimeClana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiClana.Location = new System.Drawing.Point(788, 163);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(118, 28);
            this.btnObrisiClana.TabIndex = 14;
            this.btnObrisiClana.Text = "Obriši člana";
            this.btnObrisiClana.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetalji.Location = new System.Drawing.Point(788, 115);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(118, 28);
            this.btnDetalji.TabIndex = 13;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // dgvClanPretraga
            // 
            this.dgvClanPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClanPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanPretraga.Location = new System.Drawing.Point(19, 84);
            this.dgvClanPretraga.Name = "dgvClanPretraga";
            this.dgvClanPretraga.RowHeadersWidth = 51;
            this.dgvClanPretraga.RowTemplate.Height = 24;
            this.dgvClanPretraga.Size = new System.Drawing.Size(749, 439);
            this.dgvClanPretraga.TabIndex = 11;
            // 
            // tbImeClana
            // 
            this.tbImeClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImeClana.Location = new System.Drawing.Point(158, 49);
            this.tbImeClana.Name = "tbImeClana";
            this.tbImeClana.Size = new System.Drawing.Size(204, 22);
            this.tbImeClana.TabIndex = 10;
            // 
            // lblimeClana
            // 
            this.lblimeClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblimeClana.AutoSize = true;
            this.lblimeClana.Location = new System.Drawing.Point(28, 49);
            this.lblimeClana.Name = "lblimeClana";
            this.lblimeClana.Size = new System.Drawing.Size(124, 17);
            this.lblimeClana.TabIndex = 9;
            this.lblimeClana.Text = "Unesite ime člana:";
            // 
            // UCPretragaClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiClana);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvClanPretraga);
            this.Controls.Add(this.tbImeClana);
            this.Controls.Add(this.lblimeClana);
            this.Name = "UCPretragaClanova";
            this.Size = new System.Drawing.Size(951, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiClana;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvClanPretraga;
        private System.Windows.Forms.TextBox tbImeClana;
        private System.Windows.Forms.Label lblimeClana;

        public Button BtnObrisiClana { get => btnObrisiClana; set => btnObrisiClana = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
        public DataGridView DgvClanPretraga { get => dgvClanPretraga; set => dgvClanPretraga = value; }
        public TextBox TbImeClana { get => tbImeClana; set => tbImeClana = value; }
        public Label LblimeClana { get => lblimeClana; set => lblimeClana = value; }
    }
}

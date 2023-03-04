
namespace KorisnickiInterfejs
{
    partial class FrmEvidentiranjeClanarine
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
            this.lblSveClanarine = new System.Windows.Forms.Label();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.gbEvidentiranjeClanarine = new System.Windows.Forms.GroupBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.tbClan = new System.Windows.Forms.TextBox();
            this.tbDatumOd = new System.Windows.Forms.TextBox();
            this.tbDatumDo = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            this.gbEvidentiranjeClanarine.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSveClanarine
            // 
            this.lblSveClanarine.AutoSize = true;
            this.lblSveClanarine.Location = new System.Drawing.Point(55, 29);
            this.lblSveClanarine.Name = "lblSveClanarine";
            this.lblSveClanarine.Size = new System.Drawing.Size(94, 17);
            this.lblSveClanarine.TabIndex = 0;
            this.lblSveClanarine.Text = "Sve članarine";
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Location = new System.Drawing.Point(58, 60);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.RowHeadersWidth = 51;
            this.dgvClanarine.RowTemplate.Height = 24;
            this.dgvClanarine.Size = new System.Drawing.Size(548, 187);
            this.dgvClanarine.TabIndex = 1;
            // 
            // gbEvidentiranjeClanarine
            // 
            this.gbEvidentiranjeClanarine.Controls.Add(this.btnSacuvaj);
            this.gbEvidentiranjeClanarine.Controls.Add(this.tbDatumDo);
            this.gbEvidentiranjeClanarine.Controls.Add(this.tbDatumOd);
            this.gbEvidentiranjeClanarine.Controls.Add(this.tbClan);
            this.gbEvidentiranjeClanarine.Controls.Add(this.lblDatumDo);
            this.gbEvidentiranjeClanarine.Controls.Add(this.lblDatumOd);
            this.gbEvidentiranjeClanarine.Controls.Add(this.lblClan);
            this.gbEvidentiranjeClanarine.Location = new System.Drawing.Point(57, 274);
            this.gbEvidentiranjeClanarine.Name = "gbEvidentiranjeClanarine";
            this.gbEvidentiranjeClanarine.Size = new System.Drawing.Size(548, 268);
            this.gbEvidentiranjeClanarine.TabIndex = 2;
            this.gbEvidentiranjeClanarine.TabStop = false;
            this.gbEvidentiranjeClanarine.Text = "Evidentiranje nove članarine";
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(63, 49);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(40, 17);
            this.lblClan.TabIndex = 0;
            this.lblClan.Text = "Član:";
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(63, 99);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(73, 17);
            this.lblDatumOd.TabIndex = 1;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(63, 147);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(73, 17);
            this.lblDatumDo.TabIndex = 2;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // tbClan
            // 
            this.tbClan.Location = new System.Drawing.Point(187, 49);
            this.tbClan.Name = "tbClan";
            this.tbClan.ReadOnly = true;
            this.tbClan.Size = new System.Drawing.Size(174, 22);
            this.tbClan.TabIndex = 4;
            // 
            // tbDatumOd
            // 
            this.tbDatumOd.Location = new System.Drawing.Point(187, 99);
            this.tbDatumOd.Name = "tbDatumOd";
            this.tbDatumOd.Size = new System.Drawing.Size(174, 22);
            this.tbDatumOd.TabIndex = 5;
            // 
            // tbDatumDo
            // 
            this.tbDatumDo.Location = new System.Drawing.Point(187, 147);
            this.tbDatumDo.Name = "tbDatumDo";
            this.tbDatumDo.Size = new System.Drawing.Size(174, 22);
            this.tbDatumDo.TabIndex = 6;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(231, 211);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(83, 31);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // FrmEvidentiranjeClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 598);
            this.Controls.Add(this.gbEvidentiranjeClanarine);
            this.Controls.Add(this.dgvClanarine);
            this.Controls.Add(this.lblSveClanarine);
            this.Name = "FrmEvidentiranjeClanarine";
            this.Text = "FrmEvidentiranjeClanarine";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            this.gbEvidentiranjeClanarine.ResumeLayout(false);
            this.gbEvidentiranjeClanarine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSveClanarine;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.GroupBox gbEvidentiranjeClanarine;
        private System.Windows.Forms.TextBox tbDatumDo;
        private System.Windows.Forms.TextBox tbDatumOd;
        private System.Windows.Forms.TextBox tbClan;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
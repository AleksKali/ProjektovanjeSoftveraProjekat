
namespace KorisnickiInterfejs.UserControls.Clanarina
{
    partial class UCEvidentiranjeClanarine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDatumDo = new System.Windows.Forms.TextBox();
            this.tbDatumOd = new System.Windows.Forms.TextBox();
            this.cbIzborClana = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDatumDo);
            this.groupBox1.Controls.Add(this.tbDatumOd);
            this.groupBox1.Controls.Add(this.cbIzborClana);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 275);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(608, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evidentiranje nove članarine";
            // 
            // tbDatumDo
            // 
            this.tbDatumDo.Location = new System.Drawing.Point(133, 148);
            this.tbDatumDo.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatumDo.Name = "tbDatumDo";
            this.tbDatumDo.ReadOnly = true;
            this.tbDatumDo.Size = new System.Drawing.Size(265, 22);
            this.tbDatumDo.TabIndex = 8;
            // 
            // tbDatumOd
            // 
            this.tbDatumOd.Location = new System.Drawing.Point(133, 98);
            this.tbDatumOd.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatumOd.Name = "tbDatumOd";
            this.tbDatumOd.ReadOnly = true;
            this.tbDatumOd.Size = new System.Drawing.Size(265, 22);
            this.tbDatumOd.TabIndex = 7;
            // 
            // cbIzborClana
            // 
            this.cbIzborClana.FormattingEnabled = true;
            this.cbIzborClana.Location = new System.Drawing.Point(133, 46);
            this.cbIzborClana.Margin = new System.Windows.Forms.Padding(4);
            this.cbIzborClana.Name = "cbIzborClana";
            this.cbIzborClana.Size = new System.Drawing.Size(265, 24);
            this.cbIzborClana.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Član:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(188, 203);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(137, 28);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datum od:";
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Location = new System.Drawing.Point(27, 56);
            this.dgvClanarine.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.RowHeadersWidth = 51;
            this.dgvClanarine.Size = new System.Drawing.Size(608, 185);
            this.dgvClanarine.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sve članarine:";
            // 
            // UCEvidentiranjeClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClanarine);
            this.Controls.Add(this.label1);
            this.Name = "UCEvidentiranjeClanarine";
            this.Size = new System.Drawing.Size(663, 532);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDatumOd;
        private System.Windows.Forms.ComboBox cbIzborClana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatumDo;
    }
}

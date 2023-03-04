
namespace KorisnickiInterfejs
{
    partial class PretragaIgrica
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
            this.lblNazivIgrice = new System.Windows.Forms.Label();
            this.tbNazivIgrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPronadjiIgrice = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivIgrice
            // 
            this.lblNazivIgrice.AutoSize = true;
            this.lblNazivIgrice.Location = new System.Drawing.Point(88, 38);
            this.lblNazivIgrice.Name = "lblNazivIgrice";
            this.lblNazivIgrice.Size = new System.Drawing.Size(123, 17);
            this.lblNazivIgrice.TabIndex = 0;
            this.lblNazivIgrice.Text = "Unesi naziv igrice:";
            // 
            // tbNazivIgrice
            // 
            this.tbNazivIgrice.Location = new System.Drawing.Point(240, 38);
            this.tbNazivIgrice.Name = "tbNazivIgrice";
            this.tbNazivIgrice.Size = new System.Drawing.Size(233, 22);
            this.tbNazivIgrice.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 406);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnPronadjiIgrice
            // 
            this.btnPronadjiIgrice.Location = new System.Drawing.Point(521, 36);
            this.btnPronadjiIgrice.Name = "btnPronadjiIgrice";
            this.btnPronadjiIgrice.Size = new System.Drawing.Size(130, 27);
            this.btnPronadjiIgrice.TabIndex = 3;
            this.btnPronadjiIgrice.Text = "Pronađi igrice";
            this.btnPronadjiIgrice.UseVisualStyleBackColor = true;
            this.btnPronadjiIgrice.Click += new System.EventHandler(this.btnPronadjiIgrice_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(557, 131);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(110, 32);
            this.btnDetalji.TabIndex = 4;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // PretragaIgrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 532);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnPronadjiIgrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbNazivIgrice);
            this.Controls.Add(this.lblNazivIgrice);
            this.Name = "PretragaIgrica";
            this.Text = "PretragaIgrica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivIgrice;
        private System.Windows.Forms.TextBox tbNazivIgrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPronadjiIgrice;
        private System.Windows.Forms.Button btnDetalji;
    }
}
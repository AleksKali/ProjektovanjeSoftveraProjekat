
namespace KorisnickiInterfejs
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.liToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogČlanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaČlanovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaduženjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaZaduženjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeNovogZaduženjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liToolStripMenuItem,
            this.krajRadaToolStripMenuItem,
            this.zaduženjaToolStripMenuItem,
            this.članarineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // liToolStripMenuItem
            // 
            this.liToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogČlanaToolStripMenuItem,
            this.pretragaČlanovaToolStripMenuItem});
            this.liToolStripMenuItem.Name = "liToolStripMenuItem";
            this.liToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.liToolStripMenuItem.Text = "Članovi";
            // 
            // unosNovogČlanaToolStripMenuItem
            // 
            this.unosNovogČlanaToolStripMenuItem.Name = "unosNovogČlanaToolStripMenuItem";
            this.unosNovogČlanaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.unosNovogČlanaToolStripMenuItem.Text = "Kreiranje novog člana";
            this.unosNovogČlanaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogČlanaToolStripMenuItem_Click);
            // 
            // pretragaČlanovaToolStripMenuItem
            // 
            this.pretragaČlanovaToolStripMenuItem.Name = "pretragaČlanovaToolStripMenuItem";
            this.pretragaČlanovaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.pretragaČlanovaToolStripMenuItem.Text = "Pretraga članova";
            this.pretragaČlanovaToolStripMenuItem.Click += new System.EventHandler(this.pretragaČlanovaToolStripMenuItem_Click);
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.krajRadaToolStripMenuItem.Text = "Pretraga igrica";
            // 
            // zaduženjaToolStripMenuItem
            // 
            this.zaduženjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaZaduženjaToolStripMenuItem,
            this.kreiranjeNovogZaduženjaToolStripMenuItem});
            this.zaduženjaToolStripMenuItem.Name = "zaduženjaToolStripMenuItem";
            this.zaduženjaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.zaduženjaToolStripMenuItem.Text = "Zaduženja";
            // 
            // pretragaZaduženjaToolStripMenuItem
            // 
            this.pretragaZaduženjaToolStripMenuItem.Name = "pretragaZaduženjaToolStripMenuItem";
            this.pretragaZaduženjaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.pretragaZaduženjaToolStripMenuItem.Text = "Pretraga zaduženja";
            // 
            // kreiranjeNovogZaduženjaToolStripMenuItem
            // 
            this.kreiranjeNovogZaduženjaToolStripMenuItem.Name = "kreiranjeNovogZaduženjaToolStripMenuItem";
            this.kreiranjeNovogZaduženjaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.kreiranjeNovogZaduženjaToolStripMenuItem.Text = "Kreiranje novog zaduženja";
            // 
            // članarineToolStripMenuItem
            // 
            this.članarineToolStripMenuItem.Name = "članarineToolStripMenuItem";
            this.članarineToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.članarineToolStripMenuItem.Text = "Članarine";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1006, 697);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem liToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogČlanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaČlanovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaduženjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaZaduženjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeNovogZaduženjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članarineToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}
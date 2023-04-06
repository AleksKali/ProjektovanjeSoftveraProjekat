using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls;
using KorisnickiInterfejs.UserControls.Clanarina;
using KorisnickiInterfejs.UserControls.Igrice;
using KorisnickiInterfejs.UserControls.Zaduzenje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            UCPretragaIgrica ucPretragaIgrica = new UCPretragaIgrica();
            pnlMain.Controls.Add(ucPretragaIgrica);
            ucPretragaIgrica.Dock = DockStyle.Fill;
        }
        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void unosNovogČlanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKreiranjeClana());
        }

      
        private void pretragaČlanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretragaClanova());
        }

        private void članarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCEvidentiranjeClanarine());
        }

        private void pretragaZaduženjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ChangePanel(new UCPretragaZaduzenja());
        }

        private void kreiranjeNovogZaduženjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKreiranjeZaduzenja());
        }

        private void igriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretragaIgrica());
           

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Komunikacija.Instance.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>> FormClosed event >>>>>" + ex.Message);
            }
        }
    }
    
}

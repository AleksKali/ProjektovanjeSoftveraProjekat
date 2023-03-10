using KorisnickiInterfejs.UserControls;
using KorisnickiInterfejs.UserControls.Clanarina;
using KorisnickiInterfejs.UserControls.Igrice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
    
}

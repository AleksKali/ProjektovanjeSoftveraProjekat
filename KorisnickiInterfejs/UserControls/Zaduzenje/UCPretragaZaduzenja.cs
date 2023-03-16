using AplikacionaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Zaduzenje
{
    public partial class UCPretragaZaduzenja : UserControl
    {
        public UCPretragaZaduzenja()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
           dgvZaduzenja.DataSource= Kontroler.Instance.VratiZaduzenja();
        }

        private void btnPronadjiZaduzenja_Click(object sender, EventArgs e)
        {

        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {

        }
    }
}

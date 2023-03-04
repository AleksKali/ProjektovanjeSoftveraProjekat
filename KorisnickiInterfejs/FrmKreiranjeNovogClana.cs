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

namespace KorisnickiInterfejs
{
    public partial class KreiranjeNovogClana : Form
    {
        public KreiranjeNovogClana()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Kontroler.Instance.DodajClana(tbIme.Text, tbPrezime.Text, tbJMBG.Text, tbKontakt.Text, tbMail.Text, tbUlica.Text, tbBroj.Text);
        }
    }
}

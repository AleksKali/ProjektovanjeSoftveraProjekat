using AplikacionaLogika;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Igrice
{
    public partial class UCPretragaIgrica : UserControl
    {

        private BindingList<Igrica> igrice = new BindingList<Igrica>();
        public UCPretragaIgrica()
        {
            InitializeComponent();
            Init();
            
        }
        public void Init()
        {
            try
            {
                igrice = new BindingList<Igrica>(Kontroler.Instance.VratiIgrice());
                dgvPretragaIgrica.DataSource = igrice;
                dgvPretragaIgrica.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbImeIgrice_TextChanged(object sender, EventArgs e)
        {
            string ime = tbImeIgrice.Text;
            try
            {
                igrice = new BindingList<Igrica>(Kontroler.Instance.VratiIgrice(ime));
                dgvPretragaIgrica.DataSource = igrice;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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

namespace KorisnickiInterfejs.UserControls.Clanarina
{
    public partial class UCEvidentiranjeClanarine : UserControl
    {
        public UCEvidentiranjeClanarine()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                dgvClanarine.DataSource = null; //posto nekad nece da nam radi
                dgvClanarine.DataSource = new BindingList<Domen.Clanarina>(Kontroler.Instance.VratiClanarine());
                dgvClanarine.ReadOnly = true;
                dgvClanarine.Columns[0].Visible = false;

                cbIzborClana.DataSource = Kontroler.Instance.VratiClanove();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Kontroler.Instance.SacuvajClanarinu(cbIzborClana, dtpDatumOd, dtpDatumDo);
            dgvClanarine.DataSource=new BindingList<Domen.Clanarina> (Kontroler.Instance.VratiClanarine());
        }
    }
}

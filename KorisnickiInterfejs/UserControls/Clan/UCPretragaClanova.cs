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

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCPretragaClanova : UserControl
    {
        private Clan izabranClan;
        public UCPretragaClanova()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            dgvClanPretraga.DataSource = Kontroler.Instance.VratiClanove();
        }

        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            if (dgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            izabranClan = (Clan)dgvClanPretraga.SelectedRows[0].DataBoundItem;
            Kontroler.Instance.ObrisiClana(izabranClan);
            MessageBox.Show("Član je uspešno obrisan iz baze.");
            dgvClanPretraga.DataSource = Kontroler.Instance.VratiClanove();

        }


        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            izabranClan = (Clan)dgvClanPretraga.SelectedRows[0].DataBoundItem;

            FrmDetaljiClana frmDetaljiClana = new FrmDetaljiClana(izabranClan);
            frmDetaljiClana.ShowDialog();
            DialogResult result = frmDetaljiClana.DialogResult;
            frmDetaljiClana.Dispose();
            if(result== DialogResult.OK)
            {
                MessageBox.Show("Uspesno ste izmenili podatke o clanu!");
            }

            
            dgvClanPretraga.DataSource = Kontroler.Instance.VratiClanove();
        }




        private void tbImeClana_TextChanged(object sender, EventArgs e)
        {
            string ime = tbImeClana.Text;
            try
            {
                dgvClanPretraga.DataSource = new BindingList<Clan>(Kontroler.Instance.VratiClanove(ime));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

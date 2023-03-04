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
        public UCPretragaClanova()
        {
            InitializeComponent();
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
        }

        private Clan izabranClan;
        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            izabranClan = (Clan)dgvClanPretraga.SelectedRows[0].DataBoundItem;

            new FrmDetaljiClana(izabranClan).ShowDialog();
            /*tbClanskiBroj.Text = izabranClan.ClanskiBroj.ToString();
            tbDatumUclanjenja.Text

            txtId.Text = selectedProduct.ProductId.ToString();
            txtDescription.Text = selectedProduct.Description.ToString();
            txtName.Text = selectedProduct.Name.ToString();
            txtPrice.Text = selectedProduct.Price.ToString();*/
        }

        private void btnPronadjiClanove_Click(object sender, EventArgs e)
        {
            int clanskiBr = int.Parse(tbClanskiBroj.Text);
            try
            {
                dgvClanPretraga.DataSource = new BindingList<Clan>(Kontroler.Instance.VratiClanove(clanskiBr));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

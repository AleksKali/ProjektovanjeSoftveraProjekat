
using Domen;
using KorisnickiInterfejs.KontrolerKI;
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
        //private BindingList<ZaduzenjePrimerak> zaduzenja = new BindingList<ZaduzenjePrimerak>();
        //private ZaduzenjePrimerak izabranoZaduzenje = new ZaduzenjePrimerak();
        private PretragaZaduzenjaKontroler kontroler;
        public UCPretragaZaduzenja()
        {
            InitializeComponent();
            kontroler = new PretragaZaduzenjaKontroler(this);
            kontroler.Init();
           // Init();
        }
        /*
        private void Init()
        {
            zaduzenja = new BindingList<ZaduzenjePrimerak>(Kontroler.Instance.VratiZaduzenja()); //ne radi mi osvezavanje automatsko
            dgvZaduzenja.DataSource = zaduzenja;
        }

        private void btnPronadjiZaduzenja_Click(object sender, EventArgs e)
        {
            Clan c = new Clan();
            c.ClanskiBroj = int.Parse(tbClanskiBroj.Text);
            zaduzenja = new BindingList<ZaduzenjePrimerak>(Kontroler.Instance.VratiZaduzenjaClana(c));
            dgvZaduzenja.DataSource = zaduzenja;
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            if (dgvZaduzenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            ZaduzenjePrimerak zp = new ZaduzenjePrimerak();
            Domen.Zaduzenje z = new Domen.Zaduzenje();
            zp = (ZaduzenjePrimerak)dgvZaduzenja.SelectedRows[0].DataBoundItem;
            z.Primerci = new List<Primerak>();
            z.Primerci.Add(new Primerak { InventarskiBroj = zp.InventarskiBrojPrimerka });
            z.DatumZaduzenja = zp.DatumZaduzenja;
            z.ZaduzenjeID = zp.ZaduzenjeId;
            z.Korisnik = zp.Korisnik;
            z.Clan = zp.Clan;

            Kontroler.Instance.Razduzi(z);
            dgvZaduzenja.DataSource = Kontroler.Instance.VratiZaduzenja();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvZaduzenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            //ZaduzenjePrimerak zp = new ZaduzenjePrimerak();
            izabranoZaduzenje = (Domen.ZaduzenjePrimerak)dgvZaduzenja.SelectedRows[0].DataBoundItem;
            //izabranoZaduzenje.Clan = zp.Clan;

            FrmDetaljiZaduzenja frmDetaljiZaduzenja = new FrmDetaljiZaduzenja(izabranoZaduzenje);
            frmDetaljiZaduzenja.ShowDialog();
            DialogResult result = frmDetaljiZaduzenja.DialogResult;
            frmDetaljiZaduzenja.Dispose();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Uspesno ste izmenili podatke o zaduzenju!");
            }
            dgvZaduzenja.DataSource = Kontroler.Instance.VratiZaduzenja();

            //tbClanskiBroj.Text = izabranClan.ClanskiBroj.ToString();
            //tbDatumUclanjenja.Text

            //txtId.Text = selectedProduct.ProductId.ToString();
            //txtDescription.Text = selectedProduct.Description.ToString();
            //txtName.Text = selectedProduct.Name.ToString();
            //txtPrice.Text = selectedProduct.Price.ToString();
            
            //dgvClanPretraga.Refresh();
        }

        private void tbClanskiBroj_TextChanged(object sender, EventArgs e)
        {
            dgvZaduzenja.DataSource = Kontroler.Instance.VratiZaduzenja();

        }*/
    }
}

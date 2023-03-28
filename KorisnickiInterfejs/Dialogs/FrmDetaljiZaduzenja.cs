
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

namespace KorisnickiInterfejs
{
    public partial class FrmDetaljiZaduzenja : Form
    {
        //ZaduzenjePrimerak zaduzenje = new ZaduzenjePrimerak();
        //Domen.Zaduzenje z = new Domen.Zaduzenje();

        public FrmDetaljiZaduzenja()
        {
            InitializeComponent();
            
            //Init();
        }
        /*
        private void Init() //prosla
        {
            tbDatumZaduzenja.ReadOnly = true;
            tbZaduzenjeID.ReadOnly = true;
            tbClan.ReadOnly = true;
            dgvSviPrimerci.ReadOnly = true;

            dgvSviPrimerci.DataSource = Kontroler.Instance.VratiPrimerkeZaduzenja(zaduzenje.ZaduzenjeId);

            tbZaduzenjeID.Text = zaduzenje.ZaduzenjeId.ToString();
            tbDatumZaduzenja.Text = zaduzenje.DatumZaduzenja.ToString();
            tbClan.Text = zaduzenje.Clan.ToString();

            dgvSviPrimerci.Columns[3].Visible = false;

            z.DatumZaduzenja = zaduzenje.DatumZaduzenja;
            z.ZaduzenjeID = zaduzenje.ZaduzenjeId;
            z.Korisnik = zaduzenje.Korisnik;
            z.Clan = zaduzenje.Clan;
        }

        private void btnRazduziIgricu_Click(object sender, EventArgs e)
        {
            if (dgvSviPrimerci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            z.Primerci = new List<Primerak>();
            Primerak p = (Primerak)dgvSviPrimerci.SelectedRows[0].DataBoundItem;
            z.Primerci.Add(p);
            dgvSviPrimerci.DataSource = Kontroler.Instance.VratiPrimerkeZaduzenja(zaduzenje.ZaduzenjeId);

            Kontroler.Instance.Razduzi(z);

            z.Primerci.Remove(p);
            dgvSviPrimerci.DataSource = Kontroler.Instance.VratiPrimerkeZaduzenja(zaduzenje.ZaduzenjeId);
        }

        private void btnRazduziSve_Click(object sender, EventArgs e)
        {
            List<Primerak> primerci = Kontroler.Instance.VratiPrimerkeZaduzenja(zaduzenje.ZaduzenjeId);
            z.Primerci = new List<Primerak>();

            foreach (Primerak primerak in primerci)
            {
                z.Primerci.Add(primerak); 
            }

            Kontroler.Instance.Razduzi(z);
            this.DialogResult = DialogResult.OK;

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }*/
    }
}

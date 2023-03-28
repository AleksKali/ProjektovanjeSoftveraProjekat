using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls.Zaduzenje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class PretragaZaduzenjaKontroler
    {

        private UCPretragaZaduzenja uc;
        private FrmDetaljiZaduzenja dijalog;
        private BindingList<ZaduzenjePrimerak> zaduzenja = new BindingList<ZaduzenjePrimerak>();
        private ZaduzenjePrimerak izabranoZaduzenje = new ZaduzenjePrimerak();
        Domen.Zaduzenje z = new Domen.Zaduzenje();

        public PretragaZaduzenjaKontroler(UCPretragaZaduzenja uc)
        {
            this.uc = uc;
        }
        internal void Init()
        {
            zaduzenja = new BindingList<ZaduzenjePrimerak>(Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenja)); //ne radi mi osvezavanje automatsko
            uc.DgvZaduzenja.DataSource = zaduzenja;
            uc.BtnPronadjiZaduzenja.Click += BtnPronadjiZaduzenja_Click;
            uc.BtnRazduzi.Click += BtnRazduzi_Click;
            uc.BtnDetalji.Click += BtnDetalji_Click;
            uc.TbClanskiBroj.TextChanged += TbClanskiBroj_TextChanged;
        }

        private void TbClanskiBroj_TextChanged(object sender, EventArgs e)
        {
           uc.DgvZaduzenja.DataSource = Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenja);
        }

        private void BtnDetalji_Click(object sender, EventArgs e)
        {
            if (uc.DgvZaduzenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            
            izabranoZaduzenje = (Domen.ZaduzenjePrimerak)uc.DgvZaduzenja.SelectedRows[0].DataBoundItem;
            
            dijalog = new FrmDetaljiZaduzenja();
            dijalog.BtnRazduziIgricu.Click += BtnRazduziIgricu_Click;
            dijalog.BtnRazduziSve.Click += BtnRazduziSve_Click;


            dijalog.TbDatumZaduzenja.ReadOnly = true;
            dijalog.TbZaduzenjeID.ReadOnly = true;
            dijalog.TbClan.ReadOnly = true;
            dijalog.DgvSviPrimerci.ReadOnly = true;

            try
            {
            dijalog.DgvSviPrimerci.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.VratiPrimerkeZaduzenja, izabranoZaduzenje);

            dijalog.TbZaduzenjeID.Text = izabranoZaduzenje.ZaduzenjeId.ToString();
            dijalog.TbDatumZaduzenja.Text = izabranoZaduzenje.DatumZaduzenja.ToString();
            dijalog.TbClan.Text = izabranoZaduzenje.Clan.ToString();

            dijalog.DgvSviPrimerci.Columns[3].Visible = false;

            z.DatumZaduzenja = izabranoZaduzenje.DatumZaduzenja;
            z.ZaduzenjeID = izabranoZaduzenje.ZaduzenjeId;
            z.Korisnik = izabranoZaduzenje.Korisnik;
            z.Clan = izabranoZaduzenje.Clan;

            dijalog.ShowDialog();
            DialogResult result = dijalog.DialogResult;
            dijalog.Dispose();
            ////if (result == DialogResult.OK)
            ////{
            ////    MessageBox.Show("Uspesno ste izmenili podatke o zaduzenju!");
            ////}
            uc.DgvZaduzenja.DataSource = Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnRazduziSve_Click(object sender, EventArgs e)
        {
            List<Primerak> primerci = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.VratiPrimerkeZaduzenja, izabranoZaduzenje);
            z.Primerci = new List<Primerak>();

            foreach (Primerak primerak in primerci)
            {
                z.Primerci.Add(primerak);
            }

            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.RazduziZaduzenje, z);
            dijalog.DialogResult = DialogResult.OK;
        }

        private void BtnRazduziIgricu_Click(object sender, EventArgs e)
        {
            if (dijalog.DgvSviPrimerci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            z.Primerci = new List<Primerak>();
            Primerak p = (Primerak)dijalog.DgvSviPrimerci.SelectedRows[0].DataBoundItem;
            z.Primerci.Add(p);
            dijalog.DgvSviPrimerci.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.VratiPrimerkeZaduzenja, izabranoZaduzenje);

            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.RazduziZaduzenje, z);

            z.Primerci.Remove(p);
            dijalog.DgvSviPrimerci.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.VratiPrimerkeZaduzenja, izabranoZaduzenje);
        }

       
        private void BtnRazduzi_Click(object sender, EventArgs e)
        {
            if (uc.DgvZaduzenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            ZaduzenjePrimerak zp = new ZaduzenjePrimerak();
            Domen.Zaduzenje z = new Domen.Zaduzenje();
            zp = (ZaduzenjePrimerak)uc.DgvZaduzenja.SelectedRows[0].DataBoundItem;
            z.Primerci = new List<Primerak>();
            z.Primerci.Add(new Primerak { InventarskiBroj = zp.InventarskiBrojPrimerka });
            z.DatumZaduzenja = zp.DatumZaduzenja;
            z.ZaduzenjeID = zp.ZaduzenjeId;
            z.Korisnik = zp.Korisnik;
            z.Clan = zp.Clan;

            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.RazduziZaduzenje, z);
            uc.DgvZaduzenja.DataSource = Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenja);
        }

        private void BtnPronadjiZaduzenja_Click(object sender, EventArgs e)
        {
            ZaduzenjePrimerak zp = new ZaduzenjePrimerak
            {
                Clan = new Clan
                {
                    ClanskiBroj= int.Parse(uc.TbClanskiBroj.Text) 
                }
        
            };
            
            zaduzenja = new BindingList<ZaduzenjePrimerak>(Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenjaClana, zp));
            uc.DgvZaduzenja.DataSource = zaduzenja;

        }
    }
}

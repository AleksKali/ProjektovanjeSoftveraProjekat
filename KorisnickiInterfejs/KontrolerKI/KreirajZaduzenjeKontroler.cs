using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.Sesija;
using KorisnickiInterfejs.UserControls.Zaduzenje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class KreirajZaduzenjeKontroler
    {
        UCKreiranjeZaduzenja uc;
        private BindingList<Primerak> primerci = new BindingList<Primerak>();
        private Domen.Zaduzenje zaduzenje = new Domen.Zaduzenje();

        public KreirajZaduzenjeKontroler(UCKreiranjeZaduzenja uc)
        {
            this.uc = uc;
        }

        internal void Init()
        {
            try
            {
            uc.CbIgrica.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Igrica>>(Common.Komunikacija.Operacija.VratiIgrice);
            uc.CbClan.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove);
            uc.DgvPrimerci.DataSource = primerci;
            //uc.DgvPrimerci.Columns[3].Visible = false;

            uc.BtnSacuvajIgricu.Click += BtnSacuvajIgricu_Click;
            uc.BtnSacuvajZaduzenje.Click += BtnSacuvajZaduzenje_Click;
            uc.CbIgrica.SelectedIndexChanged += CbIgrica_SelectedIndexChanged;
            uc.BtnIzbrisiRed.Click += BtnIzbrisiRed_Click;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);

            }
        }

        private void BtnIzbrisiRed_Click(object sender, EventArgs e)
        {
            if (uc.DgvPrimerci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }

            Primerak izabranPrimerak = (Primerak)uc.DgvPrimerci.SelectedRows[0].DataBoundItem;
            primerci.Remove(izabranPrimerak);
        }

        private void CbIgrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            Primerak p = new Primerak
            {
                Igrica = (Igrica)uc.CbIgrica.SelectedItem
            };
            try
            {
            uc.CbPrimerak.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.PretraziPrimerke, p);

            }
            catch (Exception ex)
            {

                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        private void BtnSacuvajZaduzenje_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }

            try
            {
            zaduzenje.Clan = (Clan)uc.CbClan.SelectedItem;
            zaduzenje.Korisnik = SessionData.Instance.Korisnik;
            zaduzenje.Primerci = primerci.ToList();

            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.KreirajZaduzenje, zaduzenje);
            
            primerci.Clear();
            uc.DgvPrimerci.DataSource = primerci;

            MessageBox.Show("Sistem je zapamtio zaduženje.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da zapamti zaduženje.");
                Debug.WriteLine(">>> " + ex.Message);

            }
        }

        private void BtnSacuvajIgricu_Click(object sender, EventArgs e)
        {
            Primerak primerak = (Primerak)uc.CbPrimerak.SelectedItem;
            primerak.Igrica = (Igrica)uc.CbIgrica.SelectedItem;
            if (primerci.Contains(primerak))
            {
                MessageBox.Show("Primerak vec postoji u listi");
                return;
            }
            primerci.Add(primerak);
        }



        public bool Validacija()
        {
            bool uspesno = true;

            if (primerci.Count == 0)
            {
                uc.LblGreska.Text = "Ne mozete sacuvati zaduzenje bez unetih primeraka!";
                uspesno = false;
            }
            else
            {
                uc.LblGreska.Text = string.Empty;
            }
            return uspesno;
        }
    }
}

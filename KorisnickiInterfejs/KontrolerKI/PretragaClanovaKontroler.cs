using Domen;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class PretragaClanovaKontroler
    {
        private UCPretragaClanova uc;
        private Clan izabranClan;
        private FrmDetaljiClana dijalog;
        private FrmDetaljiZaduzenja dijalogZaduzenje;
        private List<ZaduzenjePrimerak> trenutnaZaduzenja = new List<ZaduzenjePrimerak>();
        private BindingList<Clan> clanovi = new BindingList<Clan>();


        public PretragaClanovaKontroler(UCPretragaClanova ucPretraga)
        {
            uc = ucPretraga;
        }
        
        internal void Init()
        {
            try
            {
            clanovi= new BindingList<Clan>(Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove));
            uc.DgvClanPretraga.DataSource = clanovi;
            uc.BtnObrisiClana.Click += BtnObrisiClana_Click;
            uc.BtnDetalji.Click += BtnDetalji_Click;
            uc.TbImeClana.TextChanged += TbImeClana_TextChanged;

            }
            catch (Exception ex)
            {
                
                Debug.WriteLine(">>> " + ex.Message);
            }
         
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {

                izabranClan.Ime = dijalog.TbIme.Text;
                izabranClan.Prezime = dijalog.TbPrezime.Text;
                izabranClan.Mail = dijalog.TbMail.Text;
                izabranClan.Jmbg = dijalog.TbJMBG.Text;
                izabranClan.Kontakt = dijalog.TbKontakt.Text;
                izabranClan.Ulica = dijalog.TbUlica.Text;
                izabranClan.BrojUlice = dijalog.TbBroj.Text;

                Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.IzmeniClana, izabranClan); 
                dijalog.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da zapamti člana.");
                Debug.WriteLine(">>> " + ex.Message);
            }
        }
        private void BtnDetalji_Click(object sender, EventArgs e)
        {
            if (uc.DgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            dijalog = new FrmDetaljiClana();
            dijalog.BtnIzmeni.Click += BtnIzmeni_Click;
            dijalog.BtnDetaljiZaduzenja.Click += BtnDetaljiZaduzenja_Click;

            izabranClan = (Clan)uc.DgvClanPretraga.SelectedRows[0].DataBoundItem;

            ZaduzenjePrimerak zp = new ZaduzenjePrimerak
            {

                uslovPretrage = $"{izabranClan.Ime} {izabranClan.Prezime} {izabranClan.ClanskiBroj}"
            };
           
            try
            {
                trenutnaZaduzenja = Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.PretraziZaduzenja, zp);
                dijalog.DgvTrenutnaZaduzenja.DataSource = trenutnaZaduzenja;

                if (trenutnaZaduzenja.Count == 0)
                {
                    dijalog.BtnDetaljiZaduzenja.Enabled = false;
                    dijalog.LblBezZaduzenja.Visible = true;
                }
                dijalog.DgvTrenutnaZaduzenja.ReadOnly = true;
                dijalog.DgvTrenutnaZaduzenja.Columns[1].Visible = false;
                

                dijalog.TbClanskiBroj.ReadOnly = true;
                dijalog.TbDatumUclanjenja.ReadOnly = true;

                dijalog.TbClanskiBroj.Text = izabranClan.ClanskiBroj.ToString();
                dijalog.TbDatumUclanjenja.Text = izabranClan.DatumUclanjenja.ToString();
                dijalog.TbIme.Text = izabranClan.Ime;
                dijalog.TbPrezime.Text = izabranClan.Prezime;
                dijalog.TbJMBG.Text = izabranClan.Jmbg.ToString();
                dijalog.TbKontakt.Text = izabranClan.Kontakt;
                dijalog.TbUlica.Text = izabranClan.Ulica;
                dijalog.TbBroj.Text = izabranClan.BrojUlice;
                dijalog.TbMail.Text = izabranClan.Mail;

                StatusClanarine();

                dijalog.ShowDialog();

                DialogResult result = dijalog.DialogResult;
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Sistem je zapamtio člana.");
                }
                dijalog.Dispose();
                clanovi = new BindingList<Clan>(Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove));
                uc.DgvClanPretraga.DataSource = clanovi;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita člana.");
                Debug.WriteLine(">>> " + ex.Message);
            }

        }

        private void BtnDetaljiZaduzenja_Click(object sender, EventArgs e)
        {
            
            if (dijalog.DgvTrenutnaZaduzenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            ZaduzenjePrimerak izabranoZaduzenje = (Domen.ZaduzenjePrimerak)dijalog.DgvTrenutnaZaduzenja.SelectedRows[0].DataBoundItem;
            dijalogZaduzenje = new FrmDetaljiZaduzenja();
            try
            {
             dijalogZaduzenje.DgvSviPrimerci.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Primerak>>(Common.Komunikacija.Operacija.VratiPrimerkeZaduzenja, izabranoZaduzenje);

             dijalogZaduzenje.TbZaduzenjeID.Text = izabranoZaduzenje.ZaduzenjeId.ToString();
             dijalogZaduzenje.TbDatumZaduzenja.Text = izabranoZaduzenje.DatumZaduzenja.ToString();

             dijalogZaduzenje.DgvSviPrimerci.ReadOnly = true;
             dijalogZaduzenje.TbZaduzenjeID.ReadOnly = true;
             dijalogZaduzenje.TbDatumZaduzenja.ReadOnly = true;
             dijalogZaduzenje.TbClan.Visible = false;
             dijalogZaduzenje.LblClan.Visible = false;
             dijalogZaduzenje.BtnRazduziIgricu.Visible = false;
             dijalogZaduzenje.BtnRazduziSve.Visible = false;



             dijalogZaduzenje.ShowDialog();

             dijalogZaduzenje.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita podatke o zaduženju.");
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        private void StatusClanarine()
        {
            try
            {
            List<Clanarina> clanarine = Komunikacija.Instance.SendRequestGetResult<List<Clanarina>>(Common.Komunikacija.Operacija.VratiClanarine);

            foreach (Clanarina cla in clanarine)
            {
                if (cla.Clan.ClanskiBroj == izabranClan.ClanskiBroj)
                {
                    if (cla.DatumDo > DateTime.Now)
                    {
                        dijalog.LblClanarinaNijeIstekla.Visible = true;
                        return;
                    }
                    else
                    {
                        dijalog.LblClanarinaIstekla.Visible = true;
                        return;
                    }
                }
            }
            dijalog.LblNemaClanarine.Visible = true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }
        private void BtnObrisiClana_Click(object sender, EventArgs e)
        {
            if (uc.DgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }

            try
            {
            izabranClan = (Clan)uc.DgvClanPretraga.SelectedRows[0].DataBoundItem;
            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.ObrisiClana, izabranClan);
            clanovi.Remove(izabranClan);
            uc.DgvClanPretraga.DataSource = clanovi; 
            MessageBox.Show("Sistem je obrisao člana.");

            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show("Sistem ne može da obriše člana koji ima zaduženje.");
                Debug.WriteLine(">>> " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da obriše člana.");
                Debug.WriteLine(">>> " + ex.Message);
            }

        }

        private void TbImeClana_TextChanged(object sender, EventArgs e)
        {
            Clan c = new Clan
            {
                uslovPretrage = uc.TbImeClana.Text
            };
        
            
            try
            {
                uc.DgvClanPretraga.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.PretraziClanove, c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da nađe članove po zadatim vrednostima.");
                Debug.WriteLine(">>> " + ex.Message);
            }
        }
        
    }
}

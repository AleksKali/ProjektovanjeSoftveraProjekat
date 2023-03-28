using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
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
        

        public PretragaClanovaKontroler(UCPretragaClanova ucPretraga)
        {
            uc = ucPretraga;
        }
        
        internal void Init()
        {
          uc.DgvClanPretraga.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove);
          uc.BtnObrisiClana.Click += BtnObrisiClana_Click;
          uc.BtnDetalji.Click += BtnDetalji_Click;
          uc.TbImeClana.TextChanged += TbImeClana_TextChanged;
         
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

                Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.IzmeniClana, izabranClan); //moramo da ga obavestimo da je uspesna izmena i da zatvorimo formu za detalje?
                dijalog.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            izabranClan = (Clan)uc.DgvClanPretraga.SelectedRows[0].DataBoundItem;
            ZaduzenjePrimerak zp = new ZaduzenjePrimerak
            {
                Clan = izabranClan
            };
           
            try
            {
                dijalog.DgvTrenutnaZaduzenja.DataSource = Komunikacija.Instance.SendRequestGetResult<List<ZaduzenjePrimerak>>(Common.Komunikacija.Operacija.VratiZaduzenjaClana, zp);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska kod detalja clana "+ex.Message);
            }

            dijalog.ShowDialog();

            DialogResult result = dijalog.DialogResult;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Uspesno ste izmenili podatke o clanu!");
            }
            dijalog.Dispose();

            uc.DgvClanPretraga.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove);
        }

        private void StatusClanarine()
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
        private void BtnObrisiClana_Click(object sender, EventArgs e)
        {
            if (uc.DgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            izabranClan = (Clan)uc.DgvClanPretraga.SelectedRows[0].DataBoundItem;
            Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.ObrisiClana, izabranClan);
            uc.DgvClanPretraga.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove);

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
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}

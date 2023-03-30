using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls.Clanarina;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class EvidentiranjeClanarineKontroler
    {
        UCEvidentiranjeClanarine uc;
        List<Clanarina> clanarine;

        public EvidentiranjeClanarineKontroler(UCEvidentiranjeClanarine uc)
        {
            this.uc = uc;
        }

        internal void Init()
        {
            uc.BtnSacuvaj.Click += BtnSacuvaj_Click;
            try
            {
              //  uc.DgvClanarine.DataSource = null; //posto nekad nece da nam radi binding list
                clanarine = Komunikacija.Instance.SendRequestGetResult<List<Clanarina>>(Common.Komunikacija.Operacija.VratiClanarine);

                uc.DgvClanarine.DataSource = clanarine;
                uc.DgvClanarine.ReadOnly = true;
                //uc.DgvClanarine.Columns[0].Visible = false;

                uc.CbIzborClana.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clan>>(Common.Komunikacija.Operacija.VratiClanove);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            
            Clanarina c = new Clanarina
            {
                Clan = (Clan)uc.CbIzborClana.SelectedItem,
                DatumDo = uc.DtpDatumDo.Value,
                DatumOd = uc.DtpDatumOd.Value
            };


            if (c.DatumDo < c.DatumOd)
            {
                MessageBox.Show("Datum do mora biti veci od datuma od. ");
                return;
            }

            if (clanarine.Contains(c))
            {
                foreach (Clanarina cl in clanarine)
                {
                    if (cl.Clan.ClanskiBroj == c.Clan.ClanskiBroj)
                    {
                        if (cl.DatumDo > c.DatumOd)
                        {

                            MessageBox.Show("Clanarina istice tek " + cl.DatumDo.ToShortDateString() + ". Sledecu clanarinu evidentirajte nakon tog datuma.");
                            return;
                        }
                        else
                        {
                            try
                            {
                                Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.IzbrisiClanarinu, cl);
                                Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.EvidentirajClanarinu, c);

                                MessageBox.Show("Sistem je zapamtio novu članarinu!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Sistem ne može da zapamti članarinu.");
                                Debug.WriteLine(">>> " + ex.Message);
                            }

                        }
                    }

                }
            }
            else
            {
                try
                {

                    Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.EvidentirajClanarinu, c);
                    MessageBox.Show("Sistem je zapamtio novu članarinu!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da zapamti članarinu.");
                    Debug.WriteLine(">>> " + ex.Message);
                }
            }

            uc.DgvClanarine.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Clanarina>>(Common.Komunikacija.Operacija.VratiClanarine);
        }

       
    }
}

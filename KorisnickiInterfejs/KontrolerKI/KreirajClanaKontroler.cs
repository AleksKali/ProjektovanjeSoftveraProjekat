using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class KreirajClanaKontroler
    {

        private UCKreiranjeClana uc;


        public KreirajClanaKontroler(UCKreiranjeClana uc)
        {
            this.uc = uc;
        }

        public void Init()
        {
            uc.BtnSacuvaj.Click += btnSacuvaj_Click;
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaClana())
            {
                return;
            }


            Clan clan = new Clan();
            clan.Ime = uc.TbIme.Text;
            clan.Prezime = uc.TbPrezime.Text;
            clan.Mail = uc.TbMail.Text;
            clan.Ulica = uc.TbUlica.Text;
            clan.BrojUlice = uc.TbBroj.Text;
            clan.Jmbg = uc.TbJMBG.Text;
            clan.Kontakt = uc.TbKontakt.Text;
            //try catch? 

            //int id = Kontroler.Instance.DodajClana(clan);

            //Komunikacija.Instance.SendRequestNoResult(Common.Komunikacija.Operacija.KreirajClana, clan);
            int id = Komunikacija.Instance.SendRequestGetResult<List<int>>(Common.Komunikacija.Operacija.KreirajClana, clan)[0];

            MessageBox.Show("Uspešno ste kreirali člana " + clan.Ime + " " + clan.Prezime + " sa članskim brojem: " + id);

            foreach (Control control in uc.GbDodajClana.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        public bool ValidacijaClana()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(uc.TbIme.Text))
            {
                uc.TbIme.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                uc.TbIme.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(uc.TbPrezime.Text))
            {
                uc.TbPrezime.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                uc.TbPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uc.TbJMBG.Text)) //try parse u int i labela
            {
                uc.TbJMBG.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                uc.TbJMBG.BackColor = Color.White;
            }

            return valid;
        }

    }
}

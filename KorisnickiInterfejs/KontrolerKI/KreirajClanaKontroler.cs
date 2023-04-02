using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            
            try
            {
            int id = Komunikacija.Instance.SendRequestGetResult<List<int>>(Common.Komunikacija.Operacija.KreirajClana, clan)[0];

                MessageBox.Show("Sistem je zapamtio člana " + clan.Ime + " " + clan.Prezime + " sa članskim brojem: " + id);


                foreach (Control control in uc.GbDodajClana.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da zapamti člana.");
                Debug.WriteLine(">>> " + ex.Message);
            }
        }
        private bool IsEmailValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
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
            if (string.IsNullOrEmpty(uc.TbJMBG.Text))
            {
                uc.TbJMBG.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                uc.TbJMBG.BackColor = Color.White;
            }
            if (!string.IsNullOrEmpty(uc.TbMail.Text) && !IsEmailValid(uc.TbMail.Text))
            {
                uc.TbMail.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                uc.TbMail.BackColor = Color.White;
            }

            return valid;
        }

    }
}

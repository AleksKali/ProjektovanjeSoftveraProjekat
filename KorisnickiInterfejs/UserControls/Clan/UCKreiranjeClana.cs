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
    public partial class UCKreiranjeClana : UserControl
    {
        public UCKreiranjeClana()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Kontroler.Instance.ValidacijaClana(tbIme,tbPrezime, tbJMBG)){
                return;
            }


            Clan clan = new Clan();
            clan.Ime = tbIme.Text;
            clan.Prezime = tbPrezime.Text;
            clan.Mail = tbMail.Text;
            clan.Ulica = tbUlica.Text;
            clan.BrojUlice = tbBroj.Text;
            clan.Jmbg = tbJMBG.Text;
            clan.Kontakt = tbKontakt.Text;

           
            int id= Kontroler.Instance.DodajClana(clan);
            MessageBox.Show("Uspešno ste kreirali člana " + clan.Ime + " " + clan.Prezime+" sa članskim brojem: "+id);

            foreach (Control control in gbDodajClana.Controls)
            {
                if(control is TextBox)
                {
                    control.ResetText();
                }
            }

        }

        private void UCKreiranjeClana_Load(object sender, EventArgs e)
        {

        }
    }
}

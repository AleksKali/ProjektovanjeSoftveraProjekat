
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

namespace KorisnickiInterfejs
{
    public partial class FrmDetaljiClana : Form
    {

       //private DetaljiClanaKontroler kontroler;

        public FrmDetaljiClana()
        {
            InitializeComponent();
        }
        /*
        Clan c = new Clan();
        

        public FrmDetaljiClana(Clan izabranClan)
        {
            InitializeComponent();
            kontroler = new DetaljiClanaKontroler();
            c = izabranClan;
            Init();
        }

        private void Init()
        {
            try
            {
                dgvTrenutnaZaduzenja.DataSource = Kontroler.Instance.PretraziZaduzenja(c.ClanskiBroj);
                dgvTrenutnaZaduzenja.ReadOnly = true;
                dgvTrenutnaZaduzenja.Columns[1].Visible = false;

                tbClanskiBroj.ReadOnly = true;
                tbDatumUclanjenja.ReadOnly = true;

                tbClanskiBroj.Text = c.ClanskiBroj.ToString();
                tbDatumUclanjenja.Text = c.DatumUclanjenja.ToString();
                tbIme.Text = c.Ime;
                tbPrezime.Text = c.Prezime;
                tbJMBG.Text = c.Jmbg.ToString();
                tbKontakt.Text = c.Kontakt;
                tbUlica.Text = c.Ulica;
                tbBroj.Text = c.BrojUlice;
                tbMail.Text = c.Mail;
                Kontroler.Instance.StatusClanarine(lblNemaClanarine, lblClanarinaIstekla, lblClanarinaNijeIstekla, c);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try {

                c.Ime = tbIme.Text;
                c.Prezime = tbPrezime.Text;
                c.Mail = tbMail.Text;
                c.Jmbg = tbJMBG.Text;
                c.Kontakt = tbKontakt.Text;
                c.Ulica = tbUlica.Text;
                c.BrojUlice = tbBroj.Text;

                Kontroler.Instance.IzmeniClana(c); //moramo da ga obavestimo da je uspesna izmena i da zatvorimo formu za detalje?
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           


        }*/

    }
}

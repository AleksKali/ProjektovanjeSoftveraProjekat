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

namespace KorisnickiInterfejs.UserControls.Zaduzenje
{
    public partial class UCKreiranjeZaduzenja : UserControl
    {
        private BindingList<Primerak> primerci = new BindingList<Primerak>();
        private Domen.Zaduzenje zaduzenje = new Domen.Zaduzenje();

        public UCKreiranjeZaduzenja()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            cbIgrica.DataSource = Kontroler.Instance.VratiIgrice();
            cbClan.DataSource = Kontroler.Instance.VratiClanove();
            dgvPrimerci.DataSource = primerci;
            dgvPrimerci.Columns[3].Visible = false;
            
        }

        

        private void btnSacuvajIgricu_Click(object sender, EventArgs e)
        {
            Primerak primerak = (Primerak)cbPrimerak.SelectedItem;
            primerak.Igrica = (Igrica)cbIgrica.SelectedItem;
            if (primerci.Contains(primerak))
            {
                MessageBox.Show("Primerak vec postoji u listi");
                return;
            }
            primerci.Add(primerak);
        }

        private void btnSacuvajZaduzenje_Click(object sender, EventArgs e)
        {
            
                if (!Validacija())
                {
                    return;
                }

                zaduzenje.Clan = (Clan)cbClan.SelectedItem;
                zaduzenje.Korisnik = Kontroler.Instance.Korisnik;
                zaduzenje.Primerci = primerci.ToList();
                
                Kontroler.Instance.SacuvajZaduzenje(zaduzenje);
                //primerci = null;
                //dgvPrimerci.DataSource = primerci;


    }
    public bool Validacija()
        {
            bool uspesno = true;
            
            if (primerci.Count == 0)
            {
                lblGreska.Text = "Ne mozete sacuvati zaduzenje bez unetih primeraka!";
                uspesno = false;
            }
            else
            {
                lblGreska.Text = string.Empty;
            }
            return uspesno;
        }

        private void cbIgrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrimerak.DataSource = Kontroler.Instance.VratiPrimerke(cbIgrica);
        }

        private void btnIzbrisiRed_Click(object sender, EventArgs e)
        {
            Primerak izabranPrimerak = (Primerak)dgvPrimerci.SelectedRows[0].DataBoundItem;
            primerci.Remove(izabranPrimerak);
        }

    }
}

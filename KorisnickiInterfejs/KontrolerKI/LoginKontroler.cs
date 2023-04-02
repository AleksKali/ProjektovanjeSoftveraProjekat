using Domen;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.Sesija;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    public class LoginKontroler
    {
        public Korisnik User { get; set; }
        internal void Login(FrmLogin frmLogin)
        {
            string username = frmLogin.TxtKorisnickoIme.Text;
            string password = frmLogin.TxtLozinka.Text;

            if (!ValidacijaKorisnika(frmLogin))
            {
                return;
            }
            
            try
            {
                Korisnik user = new Korisnik()
                {
                    KorisnickoIme = username,
                    KorisnickaSifra = password,
                };

                Komunikacija.Instance.Connect(); 

                SessionData.Instance.Korisnik = Komunikacija.Instance.SendRequestGetResult<Korisnik>(Common.Komunikacija.Operacija.NadjiKorisnika, user);
                if (SessionData.Instance.Korisnik != null)
                {
                    MessageBox.Show($"Dobrodosao, {SessionData.Instance.Korisnik.Ime} {SessionData.Instance.Korisnik.Prezime}!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom!");
            }
        }

        private bool ValidacijaKorisnika(FrmLogin frmLogin)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(frmLogin.TxtKorisnickoIme.Text))
            {
                frmLogin.TxtKorisnickoIme.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                frmLogin.TxtKorisnickoIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(frmLogin.TxtLozinka.Text))
            {
                frmLogin.TxtLozinka.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                frmLogin.TxtLozinka.BackColor = Color.White;
            }
            return valid;
        }
    }
}

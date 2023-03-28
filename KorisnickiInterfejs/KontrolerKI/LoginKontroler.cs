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
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                frmLogin.TxtKorisnickoIme.BackColor = Color.Salmon;
                frmLogin.TxtLozinka.BackColor = Color.Salmon;
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

                SessionData.Instance.Korisnik = Komunikacija.Instance.SendRequestGetResult<Korisnik>(Common.Komunikacija.Operacija.Login, user);
                if (SessionData.Instance.Korisnik != null)
                {
                    MessageBox.Show($"Dobrodosao, {SessionData.Instance.Korisnik.Ime} {SessionData.Instance.Korisnik.Prezime}!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji u bazi.");
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
    }
}

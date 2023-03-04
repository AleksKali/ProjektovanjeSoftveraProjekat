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

namespace KorisnickiInterfejs
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "pera";
            txtLozinka.Text = "pera";
            string username = txtKorisnickoIme.Text;
            string password = txtLozinka.Text;
            //User user = new User();
            //user.Username = username;
            //user.Password = password;
            //UserRepository repository = new UserRepository();
            //Controller controller = Controller.GetInstance();
            //controller.Test();
            //Controller controller = Controller.Instance;
            //controller.Test();
            //Controller.GetInstance().Test();

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Korisnicko ime i sifra moraju biti popunjeni.");
                return;
            }


            Korisnik user = new Korisnik()
            {
                KorisnickoIme = username,
                KorisnickaSifra = password,
            };

            user = Kontroler.Instance.Login(user);

            if (user != null)
            {
                MessageBox.Show($"Dobrodosao, {user.Ime} {user.Prezime}!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji!");
            }
        }
    }
}

using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=psProjekat;Integrated Security=True;");

        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public List<Korisnik> GetUsers()
        {
            List<Korisnik> users = new List<Korisnik>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM Korisnik";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Korisnik k = new Korisnik();
                    k.KorisnikID = (int)reader["KorisnikID"];
                    k.Ime = (string)reader["Ime"];
                    k.Prezime = (string)reader["Prezime"];
                    k.KorisnickoIme = (string)reader["KorisnickoIme"];
                    k.KorisnickaSifra = (string)reader["KorisnickaSifra"];
                    users.Add(k);
                }
            }
            return users;
        }

        public int IzmeniClana(Clan c)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "insert into Clan (DatumUclanjenja, Ime, Prezime, JMBG, Kontakt, Mail, Ulica, Broj) output inserted.ClanskiBroj values (@DatumUclanjenja, @Ime, @Prezime, @JMBG, @Kontakt, @Mail, @Ulica, @Broj)";
            command.Parameters.AddWithValue("@DatumUclanjenja", DateTime.Now);
            command.Parameters.AddWithValue("@Ime", c.Ime);
            command.Parameters.AddWithValue("@Prezime", c.Prezime);
            command.Parameters.AddWithValue("@JMBG", c.Jmbg);
            command.Parameters.AddWithValue("@Kontakt", c.Kontakt);
            command.Parameters.AddWithValue("@Mail", c.Mail);
            command.Parameters.AddWithValue("@Ulica", c.Ulica);
            command.Parameters.AddWithValue("@Broj", c.BrojUlice);
            //.ExecuteNonQuery();
            int generisaniId = (int)command.ExecuteScalar();
            return generisaniId;
        }
        public List<Clan> VratiClanove(int i)
        {
            List<Clan> clanovi = new List<Clan>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM Clan WHERE ClanskiBroj LIKE '"+i+"%'";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clan c = new Clan();
                    c.ClanskiBroj = (int)reader["ClanskiBroj"];
                    c.DatumUclanjenja = (DateTime)reader["DatumUclanjenja"];
                    c.Ime= (string)reader["Ime"];
                    c.Prezime = (string)reader["Prezime"];
                    c.Jmbg = (string)reader["JMBG"];
                    c.Kontakt = (string)reader["Kontakt"];
                    c.Mail = (string)reader["Mail"];
                    c.Ulica = (string)reader["Ulica"];
                    c.BrojUlice = (string)reader["Broj"];
                    clanovi.Add(c);
                }
            }
            return clanovi;
        }
        public void ObrisiClana(Clan c)
        {
            
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"DELETE FROM Clan WHERE ClanskiBroj={c.ClanskiBroj}";//proveri upit
            command.ExecuteNonQuery();
        }

    }

    
}

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

      

        public void IzmeniClana(Clan c)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update Clan set Ime= '{c.Ime}', Prezime= '{c.Prezime}', JMBG='{c.Jmbg}', Kontakt='{c.Kontakt}', Mail='{c.Mail}', Ulica='{c.Ulica}', Broj='{c.BrojUlice}' where ClanskiBroj= {c.ClanskiBroj}";
            
            command.ExecuteNonQuery();
        }

        public int DodajClana(Clan c)
        {
            SqlCommand command = new SqlCommand("", connection);
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

        public List<Zaduzenje> VratiZaduzenjaClana(Clan clan)
        {
            List<Zaduzenje> zaduzenja = new List<Zaduzenje>();

            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from zaduzenje where ClanskiBroj={clan.ClanskiBroj}";

           
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zaduzenje z = new Zaduzenje
                    {
                        ZaduzenjeID = (int)reader["ZaduzenjeID"],
                        DatumZaduzenja = (DateTime)reader["DatumZaduzenja"]
                    };
                    zaduzenja.Add(z);
                    
                }
            }
            return zaduzenja;
        }
        #region neki join
        /*command.CommandText = $"select z.Zaduzenjeid as zaduzenjeId, c.ClanskiBroj as clanskiBroj, z.DatumZaduzenja as datumZaduzenja, z.DatumRazduzenja as datumRazduzenja, z.korisnikID as korisnikId, c.DatumUclanjenja as datumUclanjenja, c.ime as imeClana, c.prezime as prezimeClana, c.jmbg as jmbgClana, c.kontakt as kontaktClana, c.Mail as mailClana, c.Ulica as ulicaClana, c.broj as brojUliceClana from zaduzenje z join clan c on (z.ClanskiBroj=c.ClanskiBroj) and z.ClanskiBroj={clan.ClanskiBroj}";

           
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zaduzenje z = new Zaduzenje
                    {
                        ZaduzenjeID = (int)reader["zaduzenjeId"],
                        DatumZaduzenja = (DateTime)reader["datumZaduzenja"],
                        DatumRazduzenja = (DateTime)reader["datumRazduzenja"],
                        Clan = new Clan
                        {
                            ClanskiBroj = (int)reader["clanskiBroj"],
                            DatumUclanjenja = (DateTime)reader["datumUclanjenja"],
                            Ime = (string)reader["imeClana"],
                            Prezime = (string)reader["prezimeClana"],
                            Kontakt = (string)reader["kontaktClana"],
                            Ulica = (string)reader["ulicaClana"],
                            Mail = (string)reader["mailClana"],
                            BrojUlice = (string)reader["brojUliceClana"],
                            Jmbg = (string)reader["jmbgClana"]
                        }

                    };
                    zaduzenja.Add(z);
                    
                }
            }
            return zaduzenja;*/
        #endregion

        public List<Clan> VratiClanove(string ime)
        {
            List<Clan> clanovi = new List<Clan>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * FROM Clan WHERE Ime LIKE '%{ime}%'";
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

        public List<Igrica> VratiIgrice(string ime)
        {
            List<Igrica> igrice = new List<Igrica>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT i.igricaid as igricaId, i.naziv as nazivIgrice, p.proizvodjacid as proizvodjacId, p.naziv as proizvodjacNaziv FROM Igrica i join proizvodjac p on (i.proizvodjacid=p.proizvodjacid) WHERE i.naziv LIKE '%{ime}%'";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Igrica i = new Igrica
                    {
                        IgricaId = (int)reader["igricaId"],
                        Naziv = (string)reader["nazivIgrice"],
                        Proizvodjac = new Proizvodjac
                        {
                            ProizvodjacID = (int)reader["proizvodjacId"],
                            Naziv = (string)reader["proizvodjacNaziv"]
                        }
                    };
                   
                    igrice.Add(i);
                }
            }
            return igrice;
        }

        public List<Igrica> VratiIgrice()
        {
            List<Igrica> igrice = new List<Igrica>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT i.igricaid as igricaId, i.naziv as nazivIgrice, p.proizvodjacid as proizvodjacId, p.naziv as proizvodjacNaziv FROM Igrica i join proizvodjac p on (i.proizvodjacid=p.proizvodjacid)";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Igrica i = new Igrica
                    {
                        IgricaId = (int)reader["igricaId"],
                        Naziv = (string)reader["nazivIgrice"],
                        Proizvodjac = new Proizvodjac
                        {
                            ProizvodjacID = (int)reader["proizvodjacId"],
                            Naziv = (string)reader["proizvodjacNaziv"]
                        }
                    };

                    igrice.Add(i);
                }
            }
            return igrice;
        }

        public List<Clanarina> VratiClanarine()
        {
            List<Clanarina> clanarine = new List<Clanarina>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT c.clanarinaid as clanarinaId, cl.clanskibroj as clanskiBroj, c.datumod as datumOd, c.datumDo as datumDo, cl.ime as imeClana, cl.prezime as prezimeClana FROM clanarina c join clan cl on (c.clanskibroj=cl.clanskibroj)";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clanarina c = new Clanarina
                    {
                        ClanarinaID = (int)reader["clanarinaId"],
                        DatumOd = (DateTime)reader["datumOd"],
                        DatumDo = (DateTime)reader["datumDo"],
                        Clan = new Clan
                        {
                            ClanskiBroj = (int)reader["clanskiBroj"],
                            Ime = (string)reader["imeClana"],
                            Prezime = (string)reader["prezimeClana"]
                        }
                    };

                    clanarine.Add(c);
                }
            }
            return clanarine;
        }

    }

}

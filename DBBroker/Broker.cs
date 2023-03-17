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
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
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

        public List<Primerak> VratiPrimerkeZaduzenja(int zaduzenjeId)
        {
            List<Primerak> primerci = new List<Primerak>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select p.InventarskiBroj as inventarskiBroj, p.godinaIzdanja as godinaIzdanja, i.Naziv as nazivIgrice from primerak p join ZaduzenjePrimerak zp on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join zaduzenje z on (z.ZaduzenjeID=zp.ZaduzenjeID) join Igrica i on (p.IgricaID=i.IgricaID) where z.ZaduzenjeID = {zaduzenjeId} and z.DatumRazduzenja IS NULL and p.izdat=1";


            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Primerak p = new Primerak
                    {

                        
                        Igrica = new Igrica{
                           Naziv = (string)reader["nazivIgrice"]
                        },
                        InventarskiBroj = (int)reader["inventarskiBroj"],
                        GodinaIzdanja = (int)reader["godinaIzdanja"]

                    };
                    primerci.Add(p);

                }
            }
            return primerci;
        }

        public void RazduziPrimerak(Primerak p)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update primerak set izdat=0 where inventarskiBroj= {p.InventarskiBroj}";

            command.ExecuteNonQuery();
        }

        public int ProveraZaduzenja(Zaduzenje z)
        {
            int brojPrimeraka = 0;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select count(p.InventarskiBroj) from primerak p join ZaduzenjePrimerak zp on(p.InventarskiBroj=zp.InventarskiBroj and p.IgricaID=zp.IgricaID) join zaduzenje z on(zp.ZaduzenjeID=z.ZaduzenjeID) where z.zaduzenjeId={z.ZaduzenjeID} and p.izdat=1 group by z.ZaduzenjeID";

            brojPrimeraka = (int)command.ExecuteScalar();
            return brojPrimeraka;
        }
        public void Razduzi(Zaduzenje z)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update zaduzenje set datumRazduzenja=@datumRazduzenja where zaduzenjeId= {z.ZaduzenjeID}"; 
            command.Parameters.AddWithValue("@datumRazduzenja", DateTime.Now); 

            command.ExecuteNonQuery();
        }

        public int SacuvajZaduzenje(Zaduzenje zaduzenje)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "insert into zaduzenje (ClanskiBroj, DatumZaduzenja, KorisnikID) output inserted.zaduzenjeid values (@ClanskiBroj, @DatumZaduzenja, @Korisnik)";
            command.Parameters.AddWithValue("@ClanskiBroj", zaduzenje.Clan.ClanskiBroj);
            command.Parameters.AddWithValue("@DatumZaduzenja", DateTime.Now);
            command.Parameters.AddWithValue("@Korisnik", zaduzenje.Korisnik.KorisnikID);
            return (int)command.ExecuteScalar();
        }

        public void ZaduziPrimerak(Primerak p)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update primerak set izdat=1 where inventarskiBroj= {p.InventarskiBroj}";

            command.ExecuteNonQuery();
        }
        public void SacuvajPrimerakZaduzenja(int z, Primerak p)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "insert into ZaduzenjePrimerak values (@ZaduzenjeID, @InventarskiBroj, @IgricaID)";
            command.Parameters.AddWithValue("@ZaduzenjeID", z);
            command.Parameters.AddWithValue("@InventarskiBroj", p.InventarskiBroj);
            command.Parameters.AddWithValue("@IgricaID", p.Igrica.IgricaId);

            command.ExecuteNonQuery();
        }

        public List<Primerak> VratiPrimerke(Igrica i)
        {
            List<Primerak> primerci = new List<Primerak>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * FROM Primerak where Izdat=0 and igricaId={i.IgricaId}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Primerak p = new Primerak
                    {
                        InventarskiBroj = (int)reader["InventarskiBroj"],
                        Igrica = new Igrica
                        {
                            IgricaId = (int)reader["IgricaID"]
                        },
                        GodinaIzdanja = (int)reader["GodinaIzdanja"] 
                    };

                    primerci.Add(p);
                }
            }


            return primerci;
        }
        
        public List<ZaduzenjePrimerak> VratiZaduzenja()
        {
            List<ZaduzenjePrimerak> zaduzenja = new List<ZaduzenjePrimerak>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select c.ime as imeClana, c.prezime as prezimeClana, c.clanskiBroj as clanskiBroj, z.Zaduzenjeid as zaduzenjeId, z.DatumZaduzenja as datumZaduzenja, k.ime as imeKorisnika, k.prezime as prezimeKorisnika, p.InventarskiBroj as inventarskiBroj, i.Naziv as nazivIgrice from Clan c join zaduzenje z on (c.clanskiBroj = z.ClanskiBroj) join ZaduzenjePrimerak zp on (z.ZaduzenjeID=zp.ZaduzenjeID) join Primerak p on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join Igrica i on (p.IgricaID=i.IgricaID) join korisnik k on (z.korisnikId=k.korisnikId) where z.DatumRazduzenja IS NULL and p.Izdat=1";


            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ZaduzenjePrimerak zp = new ZaduzenjePrimerak
                    {
                        
                            ZaduzenjeId = (int)reader["zaduzenjeId"],
                            DatumZaduzenja = (DateTime)reader["datumZaduzenja"],
                            Clan = new Clan {
                                Ime = (string)reader["imeClana"],
                                Prezime = (string)reader["prezimeClana"],
                                ClanskiBroj = (int)reader["clanskiBroj"]
                            },
                            NazivIgrice = (string)reader["nazivIgrice"],
                            InventarskiBrojPrimerka = (int)reader["inventarskiBroj"],
                            Korisnik = new Korisnik
                            {
                                Ime=(string)reader["imeKorisnika"],
                                Prezime=(string)reader["prezimeKorisnika"]
                            }

                    };
                    zaduzenja.Add(zp);

                }
            }
            return zaduzenja;
        }

        public List<ZaduzenjePrimerak> VratiZaduzenjaClana(int clanskiBroj)
        {
            List<ZaduzenjePrimerak> zaduzenja = new List<ZaduzenjePrimerak>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select z.Zaduzenjeid as zaduzenjeId, z.DatumZaduzenja as datumZaduzenja, z.clanskiBroj as clanskiBroj, k.ime as imeKorisnika, k.prezime as prezimeKorisnika, p.InventarskiBroj as inventarskiBroj, i.Naziv as nazivIgrice from zaduzenje z join ZaduzenjePrimerak zp on (z.ZaduzenjeID=zp.ZaduzenjeID) join Primerak p on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join Igrica i on (p.IgricaID=i.IgricaID) join korisnik k on (z.korisnikId=k.korisnikId) where z.clanskiBroj={clanskiBroj} and z.DatumRazduzenja IS NULL and p.izdat=1";


            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ZaduzenjePrimerak zp = new ZaduzenjePrimerak
                    {

                        ZaduzenjeId = (int)reader["zaduzenjeId"],
                        DatumZaduzenja = (DateTime)reader["datumZaduzenja"],
                        Clan = new Clan { ClanskiBroj = (int)reader["clanskiBroj"] }, //nije gotova fja
                        NazivIgrice = (string)reader["nazivIgrice"],
                        InventarskiBrojPrimerka = (int)reader["inventarskiBroj"],
                        Korisnik = new Korisnik
                        {
                            Ime = (string)reader["imeKorisnika"],
                            Prezime = (string)reader["prezimeKorisnika"]
                        }

                    };
                    zaduzenja.Add(zp);

                }
            }
            return zaduzenja;
        }
        public void IzbrisiClanarinu(Clanarina c)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"DELETE FROM Clanarina WHERE ClanarinaID={c.ClanarinaID}";//proveri upit
            command.ExecuteNonQuery();
        }

        public void SacuvajClanarinu(Clanarina c)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Clanarina (ClanskiBroj, DatumOd, DatumDo) values (@ClanskiBroj, @DatumOd, @DatumDo)";
            command.Parameters.AddWithValue("@ClanskiBroj", c.Clan.ClanskiBroj);
            command.Parameters.AddWithValue("@DatumOd", c.DatumOd);
            command.Parameters.AddWithValue("@DatumDo", c.DatumDo);

            command.ExecuteNonQuery();
        }

        public DateTime VratiDatumDoClanarine(Clan c)
        {
            DateTime datumDo = new DateTime();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select datumDo from Clanarina where ClanskiBroj= {c.ClanskiBroj}";

            datumDo = (DateTime)command.ExecuteScalar();

            return datumDo;
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

        public List<Clan> VratiClanove()
        {
            List<Clan> clanovi = new List<Clan>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * FROM Clan";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clan c = new Clan();
                    c.ClanskiBroj = (int)reader["ClanskiBroj"];
                    c.DatumUclanjenja = (DateTime)reader["DatumUclanjenja"];
                    c.Ime = (string)reader["Ime"];
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

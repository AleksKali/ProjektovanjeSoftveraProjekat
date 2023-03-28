using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : IDomenskiObjekat
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string KorisnickaSifra { get; set; }
        [Browsable(false)]
        public string NazivTabele => "Korisnik";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string UslovPretrage => "";
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string InsertColumns => "";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => "";
        [Browsable(false)]
        public string AlijasTabele => "";
        [Browsable(false)]
        public string SelectValuesSearch => "*";
        [Browsable(false)]
        public string JoinSearch => "";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
        {
            Korisnik k = new Korisnik();
            k.KorisnikID = (int)reader["KorisnikID"];
            k.Ime = (string)reader["Ime"];
            k.Prezime = (string)reader["Prezime"];
            k.KorisnickoIme = (string)reader["KorisnickoIme"];
            k.KorisnickaSifra = (string)reader["KorisnickaSifra"];
            return k;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }

        public override string ToString()
        {
            return Ime+" "+Prezime;
        }
    }
}

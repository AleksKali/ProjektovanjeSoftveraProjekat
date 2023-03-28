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
    public class Clan : IDomenskiObjekat
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ClanskiBroj { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public string Kontakt { get; set; }
        [Browsable(false)]
        public string NazivTabele => "Clan";
        [Browsable(false)]
        public string InsertValues => $"('{DateTime.Now}', '{Ime}', '{Prezime}', '{Jmbg}', '{Kontakt}', '{Mail}', '{Ulica}', '{BrojUlice}')"; //ne radi nesto
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => $"Ime= '{Ime}', Prezime= '{Prezime}', JMBG='{Jmbg}', Kontakt='{Kontakt}', Mail='{Mail}', Ulica='{Ulica}', Broj='{BrojUlice}'";

        public string uslovPretrage;
        [Browsable(false)]
        public string UslovPretrage => $"Ime LIKE '%{uslovPretrage}%'";
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string InsertColumns => "(DatumUclanjenja, Ime, Prezime, JMBG, Kontakt, Mail, Ulica, Broj)";
        [Browsable(false)]
        public string OutputValue => "output inserted.ClanskiBroj";
        [Browsable(false)]
        public string GlavniUslov => $"ClanskiBroj={ClanskiBroj}";
        [Browsable(false)]
        public string AlijasTabele => "";
        [Browsable(false)]
        public string SelectValuesSearch => "*";
        [Browsable(false)]
        public string JoinSearch => "";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
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

            return c;
        }

        public override string ToString()
        {
            return Ime+ " "+ Prezime;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

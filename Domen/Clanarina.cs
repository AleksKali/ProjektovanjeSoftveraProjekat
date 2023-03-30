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
    public class Clanarina : IDomenskiObjekat
    {
        [Browsable(false)]
        public int ClanarinaID { get; set; }
        public Clan Clan {get; set; } 
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        [Browsable(false)]
        public string NazivTabele => "Clanarina";
        [Browsable(false)]
        public string InsertValues => $"({Clan.ClanskiBroj}, '{DatumOd}', '{DatumDo}')";
        [Browsable(false)]
        public string SelectValues => "c.clanarinaid as clanarinaId, cl.clanskibroj as clanskiBroj, c.datumod as datumOd, c.datumDo as datumDo, cl.ime as imeClana, cl.prezime as prezimeClana";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string UslovPretrage => "";
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string Join => "join clan cl on (c.clanskibroj=cl.clanskibroj)";
        [Browsable(false)]
        public string InsertColumns => "(ClanskiBroj, DatumOd, DatumDo)";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => $"ClanarinaID={ClanarinaID}";
        [Browsable(false)]
        public string AlijasTabele => "c";
        [Browsable(false)]
        public string SelectValuesSearch => "c.clanarinaid as clanarinaId, cl.clanskibroj as clanskiBroj, c.datumod as datumOd, c.datumDo as datumDo, cl.ime as imeClana, cl.prezime as prezimeClana";
        [Browsable(false)]
        public string JoinSearch => "join clan cl on (c.clanskibroj=cl.clanskibroj)";

        public override bool Equals(object obj)
        {
            if (obj is Clanarina c)
            {
                return c.Clan.ClanskiBroj == Clan.ClanskiBroj;
            }
            return false;
        }

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
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
            return c;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

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
    public class Igrica : IDomenskiObjekat
    {
        public int IgricaId { get; set; }
        public string Naziv { get; set; }
        public Proizvodjac Proizvodjac { get; set; }
        [Browsable(false)]
        public string NazivTabele => "Igrica i";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string SelectValues => "i.igricaid as igricaId, i.naziv as nazivIgrice, p.proizvodjacid as proizvodjacId, p.naziv as proizvodjacNaziv";

        public string uslovPretrage;
        [Browsable(false)]
        public string UslovPretrage => $"pr.izdat=0 AND i.naziv LIKE '%{uslovPretrage}%' group by i.igricaid, i.naziv, p.proizvodjacid, p.naziv";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string WhereUslov => "where pr.izdat=0 group by i.igricaid, i.naziv, p.proizvodjacid, p.naziv";
        [Browsable(false)]
        public string Join => " join proizvodjac p on (i.proizvodjacid=p.proizvodjacid) join primerak pr on (i.igricaId=pr.igricaId) ";
        [Browsable(false)]
        public string InsertColumns => "";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => "";
        [Browsable(false)]
        public string AlijasTabele => "";
        [Browsable(false)]
        public string SelectValuesSearch => "i.igricaid as igricaId, i.naziv as nazivIgrice, p.proizvodjacid as proizvodjacId, p.naziv as proizvodjacNaziv";
        [Browsable(false)]
        public string JoinSearch => " join proizvodjac p on (i.proizvodjacid=p.proizvodjacid) join primerak pr on (i.igricaId=pr.igricaId) ";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
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
            return i;
        }

        public override string ToString()
        {
            return Naziv;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

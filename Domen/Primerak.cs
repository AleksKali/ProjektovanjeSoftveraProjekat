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
    public class Primerak : IDomenskiObjekat
    {
        public Igrica Igrica { get; set; } 
        public int InventarskiBroj { get; set; }
        public int GodinaIzdanja { get; set; }
        public bool Izdat { get; set; }
        [Browsable(false)]
        public string NazivTabele => "Primerak";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string SelectValues => "p.InventarskiBroj, p.IgricaID, p.GodinaIzdanja";
        public int izdat;
        [Browsable(false)]
        public string UpdateValues => $"izdat={izdat}";

        public int uslovPretrage;
        [Browsable(false)]
        public string UslovPretrage => $"z.ZaduzenjeID = {uslovPretrage} and z.DatumRazduzenja IS NULL and p.izdat=1";
        [Browsable(false)]
        public string WhereUslov => $"where p.Izdat=0 and p.igricaId={Igrica.IgricaId}";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string InsertColumns => "";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => $"inventarskiBroj= {InventarskiBroj}";
        [Browsable(false)]
        public string AlijasTabele => "p";
        [Browsable(false)]
        public string SelectValuesSearch => "p.InventarskiBroj as inventarskiBroj, p.godinaIzdanja as godinaIzdanja, i.Naziv as nazivIgrice";
        [Browsable(false)]
        public string JoinSearch => "join ZaduzenjePrimerak zp on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join zaduzenje z on (z.ZaduzenjeID=zp.ZaduzenjeID) join Igrica i on (p.IgricaID=i.IgricaID)";

        public override string ToString()
        {
            return $"{InventarskiBroj}"; 
        }
        public override bool Equals(object obj)
        {
            if (obj is Primerak p)
            {
                return p.InventarskiBroj == InventarskiBroj;
            }
            return false;
        }

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
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
            return p;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {

            Primerak p = new Primerak
            {


                Igrica = new Igrica
                {
                    Naziv = (string)reader["nazivIgrice"]
                },
                InventarskiBroj = (int)reader["inventarskiBroj"],
                GodinaIzdanja = (int)reader["godinaIzdanja"]

            };
            return p;
        }
    }
}

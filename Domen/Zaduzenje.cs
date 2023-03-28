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
    public class Zaduzenje : IDomenskiObjekat
    {
        public int ZaduzenjeID { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumZaduzenja { get; set; }
        public DateTime DatumRazduzenja { get; set; }
        public Korisnik Korisnik { get; set; }

        public int brojPrimeraka;
        public List<Primerak> Primerci { get; set; }
        [Browsable(false)]
        public string NazivTabele => "zaduzenje";
        [Browsable(false)]
        public string InsertValues => $"({Clan.ClanskiBroj}, '{DateTime.Now}', {Korisnik.KorisnikID})";
        [Browsable(false)]
        public string SelectValues => "";
        [Browsable(false)]
        public string UpdateValues => $"datumRazduzenja='{DateTime.Now}'";
        [Browsable(false)]
        public string UslovPretrage => $"z.zaduzenjeId= {ZaduzenjeID} and p.izdat=1"; //dodat ovaj drugi deo
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string Join => "join ZaduzenjePrimerak zp on(zp.ZaduzenjeID=z.ZaduzenjeID) join primerak p on(p.InventarskiBroj=zp.InventarskiBroj and p.IgricaID=zp.IgricaID)";
        [Browsable(false)]
        public string InsertColumns => "(ClanskiBroj, DatumZaduzenja, KorisnikID)";
        [Browsable(false)]
        public string OutputValue => "output inserted.zaduzenjeid";
        [Browsable(false)]
        public string GlavniUslov => $"zaduzenjeId= {ZaduzenjeID}";
        [Browsable(false)]
        public string AlijasTabele => "z";
        [Browsable(false)]
        public string SelectValuesSearch => "count(p.InventarskiBroj)";
        [Browsable(false)]
        public string JoinSearch => "join ZaduzenjePrimerak zp on(zp.ZaduzenjeID=z.ZaduzenjeID) join primerak p on(p.InventarskiBroj=zp.InventarskiBroj and p.IgricaID=zp.IgricaID)";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader result)
        {
            throw new NotImplementedException();
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            Zaduzenje z = new Zaduzenje
            {
               brojPrimeraka = (int)reader[0]
            };
            
            return z;
        }
    }
}

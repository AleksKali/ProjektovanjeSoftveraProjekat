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
    public class ZaduzenjePrimerak : IDomenskiObjekat
    {
        public int ZaduzenjeId { get; set; }
        //public int ClanskiBroj { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumZaduzenja { get; set; }
       // public DateTime DatumRazduzenja { get; set; }

        public int InventarskiBrojPrimerka { get; set; }
        public string NazivIgrice { get; set; }
        [Browsable(false)]
        public int IgricaID { get; set; }
        public Korisnik Korisnik { get; set; }
        [Browsable(false)]
        public string NazivTabele => "ZaduzenjePrimerak";
        [Browsable(false)]
        public string InsertValues => $"({ZaduzenjeId}, {InventarskiBrojPrimerka}, {IgricaID})";
        [Browsable(false)]
        public string SelectValues => "c.ime as imeClana, c.prezime as prezimeClana, c.clanskiBroj as clanskiBroj, z.Zaduzenjeid as zaduzenjeId, z.DatumZaduzenja as datumZaduzenja, k.ime as imeKorisnika, k.prezime as prezimeKorisnika, p.InventarskiBroj as inventarskiBroj, i.Naziv as nazivIgrice";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string UslovPretrage => $"z.clanskiBroj={Clan.ClanskiBroj} and z.DatumRazduzenja IS NULL and p.Izdat=1";
        [Browsable(false)]
        public string WhereUslov => "where z.DatumRazduzenja IS NULL and p.Izdat=1";
        [Browsable(false)]
        public string Join => "join zaduzenje z on (z.ZaduzenjeID=zp.ZaduzenjeID) join Clan c  on (c.clanskiBroj = z.ClanskiBroj) join Primerak p on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join Igrica i on (p.IgricaID=i.IgricaID) join korisnik k on (z.korisnikId=k.korisnikId)";
        [Browsable(false)]
        public string InsertColumns => "";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => "";
        [Browsable(false)]
        public string AlijasTabele => "zp";
        [Browsable(false)]
        public string SelectValuesSearch => "c.ime as imeClana, c.prezime as prezimeClana, c.clanskiBroj as clanskiBroj, z.Zaduzenjeid as zaduzenjeId, z.DatumZaduzenja as datumZaduzenja, k.ime as imeKorisnika, k.prezime as prezimeKorisnika, p.InventarskiBroj as inventarskiBroj, i.Naziv as nazivIgrice";
        [Browsable(false)]
        public string JoinSearch => "join zaduzenje z on (z.ZaduzenjeID=zp.ZaduzenjeID) join Clan c  on (c.clanskiBroj = z.ClanskiBroj) join Primerak p on (zp.IgricaID=p.IgricaID and zp.InventarskiBroj=p.InventarskiBroj) join Igrica i on (p.IgricaID=i.IgricaID) join korisnik k on (z.korisnikId=k.korisnikId)";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader reader)
        {
            ZaduzenjePrimerak zp = new ZaduzenjePrimerak
            {

                ZaduzenjeId = (int)reader["zaduzenjeId"],
                DatumZaduzenja = (DateTime)reader["datumZaduzenja"],
                Clan = new Clan
                {
                    Ime = (string)reader["imeClana"],
                    Prezime = (string)reader["prezimeClana"],
                    ClanskiBroj = (int)reader["clanskiBroj"]
                },
                NazivIgrice = (string)reader["nazivIgrice"],
                InventarskiBrojPrimerka = (int)reader["inventarskiBroj"],
                Korisnik = new Korisnik
                {
                    Ime = (string)reader["imeKorisnika"],
                    Prezime = (string)reader["prezimeKorisnika"]
                }

            };
            return zp;
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
        //public string NazivIgrice { get { return Primerak.Igrica.Naziv; } } dodala Tatjana kao primer, moze da baci null pointer except

    }
}

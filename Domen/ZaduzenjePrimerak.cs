using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class ZaduzenjePrimerak
    {
        public int ZaduzenjeId { get; set; }
        //public int ClanskiBroj { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumZaduzenja { get; set; }
       // public DateTime DatumRazduzenja { get; set; }

        public int InventarskiBrojPrimerka { get; set; }
        public string NazivIgrice { get; set; }
        public Korisnik Korisnik { get; set; }
        //public string NazivIgrice { get { return Primerak.Igrica.Naziv; } } dodala tatjana kao primer, moze da baci null pointer except

    }
}

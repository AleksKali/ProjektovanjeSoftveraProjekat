using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zaduzenje
    {
        public int ZaduzenjeID { get; set; }
        public Clan Clan { get; set; }
        public DateTime DatumZaduzenja { get; set; }
        public DateTime DatumRazduzenja { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clanarina
    {
        public int ClanarinaID { get; set; }
        public int ClanId {get; set; } //ne treba nam ceo objekat, jer je ovo slab
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
    }
}

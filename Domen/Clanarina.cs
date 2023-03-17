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
        public Clan Clan {get; set; } 
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Clanarina c)
            {
                return c.Clan.ClanskiBroj == Clan.ClanskiBroj;
            }
            return false;
        }
    }
}

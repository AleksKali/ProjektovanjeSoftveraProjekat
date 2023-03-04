using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Primerak
    {
        public int IgricaId { get; set; } //Vezbe08 tako je uradila, kao ne treba nam nista sem id-ja jer je slab obj
        public int InventarskiBroj { get; set; }
        public int GodinaIzdanja { get; set; }
        public bool Izdat { get; set; }
    }
}

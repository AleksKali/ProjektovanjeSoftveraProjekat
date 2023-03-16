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
        public Igrica Igrica { get; set; } 
        public int InventarskiBroj { get; set; }
        public int GodinaIzdanja { get; set; }
        public bool Izdat { get; set; }

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
    }
}

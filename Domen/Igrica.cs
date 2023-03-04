using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Igrica
    {
        public int IgricaId { get; set; }
        public string Naziv { get; set; }
        public Proizvodjac Proizvodjac { get; set; }
    }
}

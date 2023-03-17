using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clan
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ClanskiBroj { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public string Kontakt { get; set; }
        public override string ToString()
        {
            return Ime+ " "+ Prezime;
        }
    }
}

using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiIgriceSO : SOBase
    {
        public List<Igrica> Rezultat { get; private set; }

      
        protected override void Execute()
        {
            Rezultat = repozitorijum.GetAll(new Igrica()).OfType<Igrica>().ToList();
        }
    }
}

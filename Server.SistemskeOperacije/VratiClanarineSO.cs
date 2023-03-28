using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiClanarineSO : SOBase
    {
        public List<Clanarina> Rezultat { get; private set; }
        protected override void Execute()
        {
            Rezultat = repozitorijum.GetAll(new Clanarina()).OfType<Clanarina>().ToList();
        }
    }
}

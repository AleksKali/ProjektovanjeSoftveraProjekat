using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiClanoveSO : SOBase
    {
        public List<Clan> Rezultat { get; private set; }
        protected override void Execute()
        {
            Rezultat = repozitorijum.GetAll(new Clan()).OfType<Clan>().ToList();
        }
    }
}

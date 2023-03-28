using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije 
{

    public class PretraziIgriceSO : SOBase
    {
        public List<Igrica> Rezultat { get; private set; }

        private readonly Igrica i;

        public PretraziIgriceSO(Igrica i)
        {
            this.i = i;
        }
        protected override void Execute()
        {
            Rezultat = repozitorijum.Search(i).OfType<Igrica>().ToList();
        }
    }
}

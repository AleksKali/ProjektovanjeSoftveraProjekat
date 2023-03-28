using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class IzbrisiClanarinuSO : SOBase
    {
        private readonly Clanarina c;

        public IzbrisiClanarinuSO(Clanarina c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            repozitorijum.Delete(c);
        }
    }
}

using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class EvidentirajClanarinuSO : SOBase
    {
        private readonly Clanarina c;

        public EvidentirajClanarinuSO(Clanarina c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            repozitorijum.Save(c);
        }
    }
}

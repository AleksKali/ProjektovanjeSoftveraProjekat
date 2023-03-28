using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class IzmeniClanaSO : SOBase
    {
        private readonly Clan c;

        public IzmeniClanaSO(Clan c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            repozitorijum.Update(c);
        }
    }
}

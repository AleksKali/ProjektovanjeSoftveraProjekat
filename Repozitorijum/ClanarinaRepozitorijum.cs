using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class ClanarinaRepozitorijum
    {
        private Broker broker = new Broker();

        public List<Clanarina> VratiClanarine()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiClanarine();
            }

            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}

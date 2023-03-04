using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class KorisnikRepozitorijum
    {
        private Broker broker = new Broker();
        public List<Korisnik> GetUsers()
        {
            try
            {
                broker.OpenConnection();
                List<Korisnik> users = broker.GetUsers();
                return users;
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

using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class IgricaRepozitorijum
    {

        private Broker broker = new Broker();

        public List<Igrica> VratiIgrice(string ime)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiIgrice(ime);
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

        public List<Igrica> VratiIgrice()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiIgrice();
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

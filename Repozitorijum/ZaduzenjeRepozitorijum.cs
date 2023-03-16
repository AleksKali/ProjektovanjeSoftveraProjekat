using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class ZaduzenjeRepozitorijum
    {
        private Broker broker = new Broker();


        public List<ZaduzenjePrimerak> VratiZaduzenja()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiZaduzenja();
            }

            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> " + ex.Message);
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void SacuvajZaduzenje(Zaduzenje zaduzenje)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                int id = broker.SacuvajZaduzenje(zaduzenje);
                foreach (Primerak p in zaduzenje.Primerci)
                {
                    
                    broker.SacuvajPrimerakZaduzenja(id, p);
                    broker.UpdateIzdat(p);
                }

                broker.Commit();
                
            }
            catch (Exception ex)
            {
                broker.Rollback();
                Debug.WriteLine(">>>>>> " + ex.Message);
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }

    
}

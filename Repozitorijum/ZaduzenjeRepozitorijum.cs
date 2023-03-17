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
        public List<ZaduzenjePrimerak> VratiZaduzenjaClana(int clanskiBroj)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiZaduzenjaClana(clanskiBroj);
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

        public void SacuvajZaduzenje(Zaduzenje zaduzenje)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                int id = broker. SacuvajZaduzenje(zaduzenje);
                foreach (Primerak p in zaduzenje.Primerci)
                {
                    
                    broker.SacuvajPrimerakZaduzenja(id, p);
                    broker.ZaduziPrimerak(p);
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

        public void Razduzi(Zaduzenje z)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                if (broker.ProveraZaduzenja(z) == z.Primerci.Count)
                {
                    broker.Razduzi(z);
                }

                foreach (Primerak p in z.Primerci)
                {

                    
                    broker.RazduziPrimerak(p);
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

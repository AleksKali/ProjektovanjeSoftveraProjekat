using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class ClanRepozitorijum
    {
        private Broker broker = new Broker();

        public int DodajClana(Clan c)
        {
            try
            {
                broker.OpenConnection();
                return broker.IzmeniClana(c);
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

        public int IzmeniClana(Clan c)
        {
            try
            {
                broker.OpenConnection();
                return broker.IzmeniClana(c);
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
        public void ObrisiClana(Clan c)
        {
            try
            {
                broker.OpenConnection();
                broker.ObrisiClana(c);
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
        public List<Clan> VratiClanove(int id)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiClanove(id);
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

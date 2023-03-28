using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public abstract class SOBase
    {
        protected IRepozitorijum<IDomenskiObjekat> repozitorijum = new GenerickiDBRepozitorijum();

        public void ExecuteTemplate()
        {
            try
            {
                repozitorijum.OpenConnection();
                repozitorijum.BeginTransaction();
                Execute();
                repozitorijum.Commit();

            }
            catch (Exception ex)
            {
                repozitorijum.Rollback();
                throw;
            }
            finally
            {
                repozitorijum.CloseConnection();
            }
        }
        protected abstract void Execute();
    }
}

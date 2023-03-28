using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public interface IRepozitorijum<T> where T : class
    {

        List<T> GetAll(IDomenskiObjekat obj);
        void Save(T obj);
        int SaveWithOutput(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(T obj);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}

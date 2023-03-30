using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class GenerickiDBRepozitorijum : IRepozitorijum<IDomenskiObjekat>
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.NazivTabele} WHERE {obj.GlavniUslov}";
            command.ExecuteNonQuery();
        }

        public List<IDomenskiObjekat> GetAll(IDomenskiObjekat obj)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT {obj.SelectValues} FROM {obj.NazivTabele} {obj.AlijasTabele} {obj.Join} {obj.WhereUslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        public List<IDomenskiObjekat> Search(IDomenskiObjekat obj)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT {obj.SelectValuesSearch} FROM {obj.NazivTabele} {obj.AlijasTabele} {obj.JoinSearch} WHERE {obj.UslovPretrage}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat rowObject = obj.ReadObjectRowSearch(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.NazivTabele} {obj.InsertColumns} values {obj.InsertValues}";
            command.ExecuteNonQuery();
        }

        public int SaveWithOutput(IDomenskiObjekat obj)
        {
            int result = -1;

            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.NazivTabele} {obj.InsertColumns} {obj.OutputValue} values {obj.InsertValues}";
            result = (int)command.ExecuteScalar();

            return result;
        }

    

        public void Update(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"UPDATE {obj.NazivTabele} SET {obj.UpdateValues} WHERE {obj.GlavniUslov}";
            command.ExecuteNonQuery();
        }
    }
}

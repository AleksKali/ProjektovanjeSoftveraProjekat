using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Proizvodjac : IDomenskiObjekat
    {
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }
        [Browsable(false)]
        public string NazivTabele => "";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string SelectValues => "";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string UslovPretrage => "";
        [Browsable(false)]
        public string WhereUslov => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string InsertColumns => "";
        [Browsable(false)]
        public string OutputValue => "";
        [Browsable(false)]
        public string GlavniUslov => "";
        [Browsable(false)]
        public string AlijasTabele => "";
        [Browsable(false)]
        public string SelectValuesSearch => "";
        [Browsable(false)]
        public string JoinSearch => "";

        public IDomenskiObjekat ReadObjectRow(SqlDataReader result)
        {
            throw new NotImplementedException();
        }

        public IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}

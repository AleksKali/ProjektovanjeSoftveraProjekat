using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string AlijasTabele { get; }
        string InsertValues { get; }
        string InsertColumns { get; }
        string OutputValue { get; }

        string SelectValues { get; }
        string SelectValuesSearch { get; }
        string UpdateValues { get; }

        string UslovPretrage { get; }
        string GlavniUslov { get; }

        string WhereUslov { get; }
        string Join { get; }
        string JoinSearch { get; }
        IDomenskiObjekat ReadObjectRow(SqlDataReader reader);
        IDomenskiObjekat ReadObjectRowSearch(SqlDataReader reader);

        
    }
}

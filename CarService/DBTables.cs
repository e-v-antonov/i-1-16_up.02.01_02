using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarService
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", RegistryData.DBConnectionString);
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingSystem.Database
{
    internal static class Database
    {
        internal static DataRowCollection GetRowsUsingProcedure(string procedureName, List<SqlParameter> parameters)
        {
            throw new NotImplementedException();
        }

        internal static DataRowCollection GetRowsUsingQuery(string query, List<SqlParameter> parameters)
        {
            throw new NotImplementedException();
        }

        internal static DataRow GetRowUsingProcedure(string procedureName, List<SqlParameter> parameters)
        {
            throw new NotImplementedException();
        }

        internal static DataRow GetRowUsingQuery(string query, List<SqlParameter> parameters)
        {
            throw new NotImplementedException();
        }
    }
}

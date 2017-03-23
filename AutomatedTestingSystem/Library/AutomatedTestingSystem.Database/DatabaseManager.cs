using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AutomatedTestingSystem.Database
{
    public static class DatabaseManager
    {
        public static DataRowCollection GetRowsUsingProcedure(string procedureName, IEnumerable<SqlParameter> parameters)
            => Database.GetRowsUsingProcedure(procedureName, parameters);

        public static DataRowCollection GetRowsUsingQuery(string query, IEnumerable<SqlParameter> parameters)
            => Database.GetRowsUsingQuery(query, parameters);

        public static object ExecScalar(string query, IEnumerable<SqlParameter> parameters, CommandType commandType)
            => Database.ExecScalar(query, parameters, commandType);

        public static object ExecProcedure(string procedureName, IReadOnlyCollection<SqlParameter> parameters)
            => Database.ExecScalar(procedureName, parameters, CommandType.StoredProcedure);
        
        public static DataRow GetRowUsingProcedure(string procedureName, IEnumerable<SqlParameter> parameters)
            => Database.GetRowUsingProcedure(procedureName, parameters);

        public static DataRow GetRowUsingQuery(string query, IEnumerable<SqlParameter> parameters)
            => Database.GetRowUsingQuery(query, parameters);
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public abstract class Filter
    {
        public abstract IReadOnlyCollection<SqlParameter> ToSqlParameters();
    }
}

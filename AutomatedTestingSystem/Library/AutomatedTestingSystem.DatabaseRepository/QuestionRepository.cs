using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class QuestionRepository : Repository<Question>
    {
        internal override int Create(Question item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("Text", item.Text),
                new SqlParameter("ControlWorkId", item.ControlWorkId),
                new SqlParameter("QuestiontypeId", item.QuestionTypeId),
                new SqlParameter("DateAdd", item.DateAdd)
            };
            return (int)ExecProcedure(Procedures.Tests.Question_Create, parameters);
        }
    }
}

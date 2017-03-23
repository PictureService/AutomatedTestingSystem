using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class AnswerRepository : Repository<Answer>
    {
        internal override int Create(Answer item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("QuestionId", item.QuestionId),
                new SqlParameter("Text", item.Text),
                new SqlParameter("IsTrue", item.IsTrue)
            };

            return (int)ExecProcedure(Procedures.Tests.Answer_Create, parameters);
        }

        internal override Answer Read(int id)
        {
            Filter filter = new AnswerFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<Answer> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new AnswerFilter();
            }
            else if (filter.GetType() != typeof(AnswerFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<Answer> output = new List<Answer>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.Answer_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new Answer(
                    (int)item["AnswerId"],
                    (int)item["QuestionId"],
                    (string)item["Text"],
                    (bool)item["IsTrue"]
                    ));
            }

            return output;
        }
    }

    public sealed class AnswerFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int QuestionId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("AnswerId", Id),
                new SqlParameter("QuestionId", QuestionId)
            };
            return parameters;
        }
    }
}

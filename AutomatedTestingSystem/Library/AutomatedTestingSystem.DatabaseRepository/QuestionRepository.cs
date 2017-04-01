using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

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

        internal override Question Read(int id)
        {
            Filter filter = new QuestionFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        } 

    


        internal override IReadOnlyCollection<Question> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new QuestionFilter();
            }
            else if (filter.GetType() != typeof(QuestionFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<Question> output = new List<Question>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.Question_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new Question(
                    (string)item["Text"],
                    (int)item["ControlWorkId"],
                    (int)item["QuestionTypeId"],
                    (DateTime)item["DateAdd"]
                    ));
            }
            return output;
        }
    }


    public sealed class QuestionFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int ControlWorkId { get; set; } = -1;
        public int QuestionTypeId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("QuestionId", Id),
                new SqlParameter("ControlWorkId", ControlWorkId),
                new SqlParameter("QuestionTypeId", QuestionTypeId)
            };
            return parameters;
        }
    }
}


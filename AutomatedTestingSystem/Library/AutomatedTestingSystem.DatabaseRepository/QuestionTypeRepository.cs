using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class QuestionTypeRepository : Repository<QuestionType>
    {

        internal override QuestionType Read(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор меньше или равен нулю", "id");
            }

            Filter filter = new QuestionFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<QuestionType> ReadAll(Filter filter)
        {
            if(filter == null)
            {
                filter = new QuestionTypeFilter();
            }
            else if (filter.GetType() != typeof(QuestionTypeFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<QuestionType> output = new List<QuestionType>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.QuestionType_Read, filter.ToSqlParameters());

            foreach(DataRow item in drc)
            {
                output.Add(new QuestionType(
                    (int)item["QuestionTypeId"],
                    (string)item["Name"]
                    ));
            }
            return output;
        }

    }

    public sealed class QuestionTypeFilter : Filter
    {
        public int Id { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("QuestionTypeId", Id)
            };
            return parameters;
        }
    }
}

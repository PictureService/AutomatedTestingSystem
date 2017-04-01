using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class TestTypeRepository : Repository<TestType>
    {
        internal override TestType Read(int id)
        {
            Filter filter = new TestTypeFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<TestType> ReadAll(Filter filter)
        {
            if(filter == null)
            {
                filter = new TestTypeFilter();
            }
            else if (filter.GetType() != typeof(TestTypeFilter))
            {
                throw new ArgumentException("Передаваемый аргумент не соответствует ожидаемому","filter");
            }

            List<TestType> output = new List<TestType>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.QuestionType_Read, filter.ToSqlParameters());

            foreach(DataRow item in drc)
            {
                output.Add(new TestType(
                    (int)item["QuestionTypeId"],
                    (string)item["Text"]
                    ));
            }
            return output;
        }
    }


    public sealed class TestTypeFilter : Filter
    {
        public int Id { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("QuestionTypeId",Id)
            };
            return parameters;
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class ControlWorkResultRepository : Repository<ControlWorkResult>
    {
        internal override int Create(ControlWorkResult item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkId", item.ControlWorkId),
                new SqlParameter("UserId", item.UserId),
                new SqlParameter("CountTrueAnswers", item.CountTrueAnswers)
            };
            return (int)ExecProcedure(Procedures.Tests.ControlWorkResult_Create, parameters);
        }

        internal override ControlWorkResult Read(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор меньше или равен нулю", "id");
            }

            Filter filter = new ControlWorkResultFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<ControlWorkResult> ReadAll(Filter filter)
        {
            if(filter == null)
            {
                filter = new ControlWorkResultFilter();
            }
            else if (filter.GetType() != typeof(ControlWorkResultFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<ControlWorkResult> output = new List<ControlWorkResult>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.ControlWorkResult_Read, filter.ToSqlParameters());

            foreach(DataRow item in drc)
            {
                output.Add(new ControlWorkResult(
                    (int)item["ControlWorkId"],
                    (int)item["UserId"],
                    (int)item["CountTrueAnswers"]
                    ));
            }
            return output;
        }

        internal override void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор равен или меньше нуля", "id");
            }
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkResultId", id)
            };

            ExecProcedure(Procedures.Tests.ControlWorkResult_Delete, parameters);
        }

    }


    public sealed class ControlWorkResultFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int ControlWorkId { get; set; } = -1;
        public int UserId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkResultId", Id),
                new SqlParameter("ControlWorkId", ControlWorkId),
                new SqlParameter("UserId", UserId)
            };
            return parameters;
        }
    }
}

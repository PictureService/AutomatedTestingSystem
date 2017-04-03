using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class ControlWorkRepository : Repository<ControlWork>
    {
        internal override int Create(ControlWork item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("AuthorUserId", item.AuthorUserId),
                new SqlParameter("Name", item.Name),
                new SqlParameter("Description", item.Description),
                new SqlParameter("TestTypeId", item.TestTypeId)
            };
            return (int)ExecProcedure(Procedures.Tests.ControlWorkResult_Create, parameters);
        }

        internal override ControlWork Read(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор меньше или равен нулю", "id");
            }

            Filter filter = new ControlWorkFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<ControlWork> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new ControlWorkFilter();
            }
            else if (filter.GetType() != typeof(ControlWorkFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<ControlWork> output = new List<ControlWork>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Tests.ControlWork_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new ControlWork(
                    (int)item["AuthorUserId"],
                    (string)item["Name"],
                    (string)item["Description"],
                    (int)item["TestTypeId"]
                    ));
            }
            return output;
        }

        internal override void Update(ControlWork item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item","Аргумент не должен содержать значение Null");
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkId", item.Id),
                new SqlParameter("ControlWorkName", item.Name),
                new SqlParameter("Description", item.Description),
                new SqlParameter("TestTypeId", item.TestTypeId)
            };
            ExecProcedure(Procedures.Tests.ControlWork_Update, parameters);
        }

        internal override void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор равен или меньше нуля", "id");
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkId", id)
            };

            ExecProcedure(Procedures.Tests.ControlWork_Delete, parameters);
        }
    }



    public sealed class ControlWorkFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int AuthorUserId { get; set; } = -1;
        public int TestTypeId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkId", Id),
                new SqlParameter("AuthorUserId", AuthorUserId),
                new SqlParameter("TestTypeId", TestTypeId)
            };
            return parameters;
        }
    }

}

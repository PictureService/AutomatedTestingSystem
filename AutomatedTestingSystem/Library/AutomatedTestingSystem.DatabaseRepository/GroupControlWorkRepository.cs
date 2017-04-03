using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class GroupsControlWorksRepository : Repository<GroupsControlWorks>
    {
        internal override int Create(GroupsControlWorks item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupId", item.GroupId),
                new SqlParameter("ControlWorkId", item.ControlWorkId)
            };
            return (int)ExecProcedure(Procedures.Users.GroupControlWork_Create, parameters);
        }


        internal override GroupsControlWorks Read(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор меньше или равен нулю", "id");
            }

            Filter filter = new GroupsControlWorksFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<GroupsControlWorks> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new GroupsControlWorksFilter();
            }
            else if (filter.GetType() != typeof(GroupsControlWorksFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<GroupsControlWorks> output = new List<GroupsControlWorks>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Users.GroupsControlWorks_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new GroupsControlWorks(
                    (int)item["GroupControlWorkId"],
                    (int)item["GroupId"],
                    (int)item["ControlWorkId"]
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
                new SqlParameter("GroupControlWorkId",id)
            };

            ExecProcedure(Procedures.Users.GroupControlWork_Delete, parameters);
        }
    }

    public sealed class GroupsControlWorksFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int GroupId { get; set; } = -1;
        public int ControlWorkId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupControlWorkId", Id),
                new SqlParameter("GroupId", GroupId),
                new SqlParameter("ControlWorkId", ControlWorkId)
            };
            return parameters;
        }
    }
}

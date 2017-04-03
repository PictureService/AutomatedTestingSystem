using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class GroupRepository : Repository<Group>
    {
        internal override int Create(Group item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("Name", item.Name),
                new SqlParameter("GroupTypeId", item.GroupTypeId)
            };
            return (int)ExecProcedure(Procedures.Users.Group_Create, parameters);
        }

        internal override Group Read(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор меньше или равен нулю", "id");
            }

            Filter filter = new GroupFilter
            {
                Id = id 
            };
            return ReadAll(filter).FirstOrDefault();
        }
        internal override IReadOnlyCollection<Group> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new ControlWorkFilter();
            }
            else if (filter.GetType() != typeof(GroupFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<Group> output = new List<Group>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Users.Group_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new Group(
                    (int)item["GroupId"],
                    (string)item["Name"],
                    (int)item["GroupTypeId"]
                    ));
            }
            return output;
        }

        internal override void Update(Group item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item", "Аргумент не должен содержать значение Null");
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupId", item.Id),
                new SqlParameter("GroupName", item.Name),
                new SqlParameter("GroupTypeId", item.GroupTypeId)
            };

            ExecProcedure(Procedures.Users.Group_Update, parameters);
        }

        internal override void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Идентификатор равен или меньше нуля", "id");
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupId",id)
            };

            ExecProcedure(Procedures.Users.Group_Delete, parameters);
        }
    }


    public sealed class GroupFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int GroupTypeId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupId", Id),
                new SqlParameter("GroupTypeId", GroupTypeId)
            };
            return parameters;
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class GroupTypeRepository : Repository<GroupType>
    {
        internal override GroupType Read(int id)
        {
            Filter filter = new ControlWorkFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<GroupType> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new GroupTypeFilter();
            }
            else if (filter.GetType() != typeof(GroupTypeFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<GroupType> output = new List<GroupType>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Users.GroupType_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new GroupType(
                    (int)item["GroupTypeId"],
                    (string)item["Name"]
                    ));
            }
            return output;
        }
    }

    public sealed class GroupTypeFilter : Filter
    {
        public int Id { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("GroupTypeId", Id)
            };
            return parameters;
        }
    }
}

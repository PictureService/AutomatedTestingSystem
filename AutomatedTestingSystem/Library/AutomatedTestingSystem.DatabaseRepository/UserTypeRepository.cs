using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class UserTypeRepository : Repository<UserType>
    {

        internal override UserType Read(int id)
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

        internal override IReadOnlyCollection<UserType> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new UserTypeFilter();
            }
            else if (filter.GetType() != typeof(UserTypeFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<UserType> output = new List<UserType>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Users.UserType_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new UserType(
                    (int)item["UserTypeId"],
                    (string)item["Name"]
                    ));
            }
            return output;
        }


    }

    public sealed class UserTypeFilter : Filter
    {
        public int Id { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("ControlWorkId", Id),
            };
            return parameters;
        }
    }
}

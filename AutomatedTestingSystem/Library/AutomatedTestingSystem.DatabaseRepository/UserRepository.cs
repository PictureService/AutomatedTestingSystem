using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;
using System.Linq;
using System;
using System.Data;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class UserRepository : Repository<User>
    {
        internal override int Create(User item)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("UserTypeId", item.UserTypeId),
                new SqlParameter("GroupId", item.GroupId),
                new SqlParameter("Login", item.Login),
                new SqlParameter("Password", item.Password),
                new SqlParameter("Name", item.Name),
                new SqlParameter("Surname", item.Surname),
                new SqlParameter("Patronymic", item.Patronymic)
            };
            return (int)ExecProcedure(Procedures.Users.User_Create, parameters);
        }

        internal override User Read(int id)
        {
            Filter filter = new UserFilter
            {
                Id = id
            };
            return ReadAll(filter).FirstOrDefault();
        }

        internal override IReadOnlyCollection<User> ReadAll(Filter filter)
        {
            if (filter == null)
            {
                filter = new UserFilter();
            }
            else if (filter.GetType() != typeof(UserFilter))
            {
                throw new ArgumentException("Передаваемый фильтр не соответствует ожидаемому", "filter");
            }

            List<User> output = new List<User>();
            var drc = GetRowsUsingQuery(TableValuedFunctions.Users.User_Read, filter.ToSqlParameters());

            foreach (DataRow item in drc)
            {
                output.Add(new User(
                    (int)item["UserId"],
                    (int)item["UserTypeId"],
                    (int)item["GroupId"],
                    (string)item["Login"],
                    (string)item["Password"],
                    (string)item["Name"],
                    (string)item["Surname"],
                    (string)item["Patronymic"]
                    ));
            }
            return output;
        }

    }


    public sealed class UserFilter : Filter
    {
        public int Id { get; set; } = -1;
        public int UserTypeId { get; set; } = -1;
        public int GroupId { get; set; } = -1;

        public override IReadOnlyCollection<SqlParameter> ToSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("UserId", Id),
                new SqlParameter("UserTypeId", UserTypeId),
                new SqlParameter("GroupId", GroupId)
            };
            return parameters;
        }
    }
}

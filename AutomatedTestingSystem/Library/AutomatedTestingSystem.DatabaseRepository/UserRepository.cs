using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;

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
    }
}

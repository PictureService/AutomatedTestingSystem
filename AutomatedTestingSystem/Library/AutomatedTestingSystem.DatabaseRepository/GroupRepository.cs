using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;

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
    }
}

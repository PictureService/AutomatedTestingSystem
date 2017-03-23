using System.Collections.Generic;
using System.Data.SqlClient;
using static AutomatedTestingSystem.Database.DatabaseManager;
using AutomatedTestingSystem.Database;

namespace AutomatedTestingSystem.DatabaseRepository
{
    internal sealed class GroupControlWorkRepository : Repository<GroupsControlWorks>
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
    }
}

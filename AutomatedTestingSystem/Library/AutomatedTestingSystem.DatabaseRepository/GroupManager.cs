using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Создать обект типа <see cref="Group"/>
        /// Возвращает идентификатор объекта
        /// </summary>
        /// <param name="name">Имя группы</param>
        /// <param name="groupTypeId">Идентификатор типа группы</param>
        /// <returns>Возвращает идентификатор объекта</returns>
        public static int GroupCreate(string name, int groupTypeId)
            => new GroupRepository().Create(new Group(name, groupTypeId));

        /// <summary>
        /// Получить объект типа <see cref="Group"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="Group"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="Group"/></returns>
        public static Group GetGroup(int id)
            => new GroupRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="Group"/>, отфильтрованную с помощью <see cref="GroupFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="Group"/></returns>
        public static IReadOnlyCollection<Group> GetGroups(Filter filter)
            => new GroupRepository().ReadAll(filter);

        /// <summary>
        /// Обновить объект типа <see cref="Group"/> в базе
        /// </summary>
        /// <param name="groupId">Идентификато объекта типа <see cref="Group"/></param>
        /// <param name="name">Имя группы</param>
        /// <param name="groupTypeId">Идентификатор типа группы</param>
        public static void GroupUpdate(int groupId, string name, int groupTypeId)
            => new GroupRepository().Update(new Group(groupId, name, groupTypeId));

        /// <summary>
        /// Удалить объект типа <see cref="Group"/> из базы
        /// </summary>
        /// <param name="groupId">Идентификато объекта типа <see cref="Group"/></param>
        public static void GroupDelete(int groupId)
            => new GroupRepository().Delete(groupId);
    }
}

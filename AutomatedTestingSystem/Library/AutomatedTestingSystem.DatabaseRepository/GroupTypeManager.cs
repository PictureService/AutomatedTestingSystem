using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Получить объект типа <see cref="GroupType"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="GroupType"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="GroupType"/></returns>
        public static GroupType GetGroupType(int id)
            => new GroupTypeRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="GroupType"/>, отфильтрованную с помощью <see cref="GroupTypeFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="GroupType"/></returns>
        public static IReadOnlyCollection<GroupType> GetGroupTypes(Filter filter)
            => new GroupTypeRepository().ReadAll(filter);
    }
}

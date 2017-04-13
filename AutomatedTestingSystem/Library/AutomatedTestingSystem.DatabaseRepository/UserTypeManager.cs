using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Получить объект типа <see cref="UserType"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="UserType"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="UserType"/></returns>
        public static UserType GetUserType(int id)
            => new UserTypeRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="UserType"/>, отфильтрованную с помощью <see cref="UserTypeFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="UserType"/></returns>
        public static IReadOnlyCollection<UserType> GetUserTypes(Filter filter)
            => new UserTypeRepository().ReadAll(filter);
    }
}

using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Получить объект типа <see cref="TestType"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="TestType"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="TestType"/></returns>
        public static TestType GetTestType(int id)
            => new TestTypeRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="TestType"/>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="TestType"/></returns>
        public static IReadOnlyCollection<TestType> GetTestTypes(Filter filter)
            => new TestTypeRepository().ReadAll(filter);
    }
}

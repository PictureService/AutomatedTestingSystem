using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Создать объект типа <see cref="ControlWork"/>
        /// Возвращает идентификатор объекта
        /// </summary>
        /// <param name="authorUserId">Идентификатор объекта <see cref="User"/></param>
        /// <param name="name">Имя теста</param>
        /// <param name="description">Описание теста</param>
        /// <param name="testTypeId">Идентификатор типа теста</param>
        /// <returns>Возвращает идентификатор объекта</returns>
        public static int ControlWorkCreate(int authorUserId, string name, string description, int testTypeId)
            => new ControlWorkRepository().Create(new ControlWork(authorUserId, name, description, testTypeId));

        /// <summary>
        /// Получить объект типа <see cref="ControlWork"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="ControlWork"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="ControlWork"/></returns>
        public static ControlWork GetControlWork(int id)
            => new ControlWorkRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="ControlWork"/>, отфильтрованную с помощью <see cref="ControlWorkFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="ControlWork"/></returns>
        public static IReadOnlyCollection<ControlWork> GetControlWorks(Filter filter)
            => new ControlWorkRepository().ReadAll(filter);

        /// <summary>
        /// Обновить объект типа <see cref="ControlWork"/> в базе
        /// </summary>
        /// <param name="controlWorkId">Идентификатор объекта типа <see cref="ControlWork"/></param>
        /// <param name="authorUserId">Идентификатор объекта <see cref="User"/></param>
        /// <param name="name">Имя теста</param>
        /// <param name="description">Описание теста</param>
        /// <param name="testTypeId">Идентификатор типа теста</param>
        public static void ControlWorkUpdate(int controlWorkId, int authorUserId, string name, string description, int testTypeId)
            => new ControlWorkRepository().Update(new ControlWork(controlWorkId, authorUserId, name, description, testTypeId));

        /// <summary>
        /// Удалить объект типа <see cref="ControlWork"/> из базы
        /// </summary>
        /// <param name="controlWorkId">Идентификатор объекта типа <see cref="ControlWork"/></param>
        public static void ControlWorkDelete(int controlWorkId)
            => new ControlWorkRepository().Delete(controlWorkId);

    }
}

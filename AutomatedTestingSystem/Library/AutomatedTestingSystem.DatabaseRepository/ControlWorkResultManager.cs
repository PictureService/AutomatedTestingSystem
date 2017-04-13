using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Создать объект типа <see cref="ControlWorkResult"/>
        /// Возвращает идентификатор объекта
        /// </summary>
        /// <param name="controlWorkId">Идентификатор объекта <see cref="ControlWork"/></param>
        /// <param name="userId">Идентификатор объекта <see cref="User"/></param>
        /// <param name="countTrueAnswers">Количество правильных ответов</param>
        /// <returns></returns>
        public static int ControlWorkResultCreate(int controlWorkId, int userId, int countTrueAnswers)
            => new ControlWorkResultRepository().Create(new ControlWorkResult(controlWorkId, userId, countTrueAnswers));

        /// <summary>
        /// Получить объект типа <see cref="ControlWorkResult"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="ControlWorkResult"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="ControlWorkResult"/></returns>
        public static ControlWorkResult GetControlWorkResult(int id)
            => new ControlWorkResultRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="ControlWorkResult"/>, отфильтрованную с помощью <see cref="ControlWorkResultFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="ControlWorkResult"/></returns>
        public static IReadOnlyCollection<ControlWorkResult> GetControlWorkResults(Filter filter)
            => new ControlWorkResultRepository().ReadAll(filter);

        /// <summary>
        /// Удалить объект типа <see cref="ControlWorkResult"/> из базы
        /// </summary>
        /// <param name="controlWorkResultId">Идентификатор объекта типа <see cref="ControlWorkResult"/></param>
        public static void ControlWorkResultDelete(int controlWorkResultId)
            => new ControlWorkResultRepository().Delete(controlWorkResultId);
    }
}

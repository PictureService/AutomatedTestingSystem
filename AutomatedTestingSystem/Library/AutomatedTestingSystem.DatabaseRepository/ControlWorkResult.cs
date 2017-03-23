namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Результат тестирования
    /// </summary>
    public sealed class ControlWorkResult
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Идентификатор теста в базе
        /// </summary>
        internal int ControlWorkId { get; private set; }

        /// <summary>
        /// Идентификатор пользователя в базе
        /// </summary>
        internal int UserId { get; private set; }

        /// <summary>
        /// Количество правильных ответов
        /// </summary>
        internal int CountTrueAnswers { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="ControlWorkResult"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="controlWorkId">Идентификатор теста в базе</param>
        /// <param name="userId">Идентификатор пользователя в базе</param>
        /// <param name="countTrueAnswers">Количество правильных ответов</param>
        internal ControlWorkResult(int id, int controlWorkId, int userId, int countTrueAnswers)
        {
            Id = id;
            ControlWorkId = ControlWorkId;
            UserId = userId;
            CountTrueAnswers = countTrueAnswers;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="ControlWorkResult"/>
        /// </summary>
        /// <param name="controlWorkId">Идентификатор теста в базе</param>
        /// <param name="userId">Идентификатор пользователя в базе</param>
        /// <param name="countTrueAnswers">Количество правильных ответов</param>
        internal ControlWorkResult(int controlWorkId, int userId, int countTrueAnswers)
        {
            ControlWorkId = controlWorkId;
            UserId = userId;
            CountTrueAnswers = countTrueAnswers;
        }
    }
}

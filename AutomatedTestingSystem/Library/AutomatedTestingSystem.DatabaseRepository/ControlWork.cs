namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Тестовое задание/проверочная работа
    /// </summary>
    public sealed class ControlWork
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }
        /// <summary>
        /// Идентификатор автора в базе
        /// </summary>
        internal int AuthorUserId { get; private set; }
        /// <summary>
        /// Название теста
        /// </summary>
        internal string Name { get; private set; }
        /// <summary>
        /// Описание теста
        /// </summary>
        internal string Description { get; private set; }
        /// <summary>
        /// Идентификатор типа теста
        /// </summary>
        internal int TestTypeId { get; private set; }
        /// <summary>
        /// Конструктор для существующего объекта <see cref="ControlWork"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="authorUserId">Идентификатор автора в базе</param>
        /// <param name="name">Название теста</param>
        /// <param name="description">Описание теста</param>
        /// <param name="testTypeId">Идентификатор типа теста</param>
        internal ControlWork(int id, int authorUserId, string name, string description, int testTypeId)
        {
            Id = id;
            AuthorUserId = authorUserId;
            Name = name;
            Description = description;
            TestTypeId = TestTypeId;
        }
        /// <summary>
        /// Конструктор для нового объекта
        /// </summary>
        /// <param name="authorUserId">Идентификатор автора в базе</param>
        /// <param name="name">Название теста</param>
        /// <param name="description">Описание теста</param>
        /// <param name="testTypeId">Идентификатор типа теста</param>
        internal ControlWork(int authorUserId, string name, string description, int testTypeId)
        {
            AuthorUserId = authorUserId;
            Name = name;
            Description = description;
            TestTypeId = TestTypeId;
        }
    }
}

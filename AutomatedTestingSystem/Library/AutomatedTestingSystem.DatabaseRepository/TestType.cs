namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Тип теста
    /// </summary>
    public sealed class TestType
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Название типа теста
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="TestType"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="name">Название типа теста</param>
        internal TestType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="TestType"/>
        /// </summary>
        /// <param name="name">Название типа теста</param>
        internal TestType(string name)
        {
            Name = name;
        }
    }
}

namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Тип группы
    /// </summary>
    public sealed class GroupType
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Название типа группы
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="GroupType"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="name">Название типа группы</param>
        internal GroupType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="GroupType"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="name">Название типа группы</param>
        internal GroupType(string name)
        {
            Name = name;
        }
    }
}

namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Группа пользователей
    /// </summary>
    public sealed class Group
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Имя группы
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Идентификатор типа группы
        /// </summary>
        internal int GroupTypeId { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="Group"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="name">Имя группы</param>
        /// <param name="groupTypeId">Идентификатор типа группы</param>
        internal Group(int id, string name, int groupTypeId)
        {
            Id = id;
            Name = name;
            GroupTypeId = groupTypeId;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="Group"/>
        /// </summary>
        /// <param name="name">Имя группы</param>
        /// <param name="groupTypeId">Идентификатор типа группы</param>
        internal Group(string name, int groupTypeId)
        {
            Name = name;
            GroupTypeId = groupTypeId;
        }
    }
}

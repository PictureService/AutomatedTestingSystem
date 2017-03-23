namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Тип пользователя
    /// </summary>
    public sealed class UserType
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Название типа пользователя
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="UserType"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        internal UserType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="UserType"/>
        /// </summary>
        /// <param name="name"></param>
        internal UserType(string name)
        {
            Name = name;
        }
    }
}

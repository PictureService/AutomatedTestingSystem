namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Данные пользователя
    /// </summary>
    public sealed class User
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Идентификатор типа пользователя в базе
        /// </summary>
        internal int UserTypeId { get; private set; }

        /// <summary>
        /// Идентификатор группы в базе
        /// </summary>
        internal int GroupId { get; private set; }

        /// <summary>
        /// Логин учётной записи пользователя
        /// </summary>
        internal string Login { get; private set; }

        /// <summary>
        /// Пароль учётной записи пользователя
        /// </summary>
        internal string Password { get; private set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        internal string Name { get; private set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        internal string Surname { get; private set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        internal string Patronymic { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="User"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="userTypeId">Идентификатор типа пользователя в базе</param>
        /// <param name="groupId">Идентификатор группы в базе</param>
        /// <param name="login">Логин учётной записи пользователя</param>
        /// <param name="password">Пароль учётной записи пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        internal User(int id, int userTypeId, int groupId, string login, string password, string name, string surname, string patronymic)
        {
            Id = id;
            UserTypeId = userTypeId;
            GroupId = groupId;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="User"/>
        /// </summary>
        /// <param name="userTypeId">Идентификатор типа пользователя в базе</param>
        /// <param name="groupId">Идентификатор группы в базе</param>
        /// <param name="login">Логин учётной записи пользователя</param>
        /// <param name="password">Пароль учётной записи пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        internal User(int userTypeId, int groupId, string login, string password, string name, string surname, string patronymic)
        {
            UserTypeId = userTypeId;
            GroupId = groupId;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
    }
}

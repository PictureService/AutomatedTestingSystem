using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Создать объект типа <see cref="User"/>.
        /// Возвращает идентификатор объекта.
        /// </summary>
        /// <param name="userTypeId">Идентификатор объекта типа <see cref="UserType"/></param>
        /// <param name="groupId">Идентификатор объекта типа <see cref="Group"/></param>
        /// <param name="login">Логин учётной записи пользователя</param>
        /// <param name="password">Пароль учётной записи пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        /// <returns>Возвращает идентификатор объекта</returns>
        public static int UserCreate(int userTypeId, int groupId, string login, string password, string name, string surname, string patronymic)
            => new UserRepository().Create(new User(userTypeId, groupId, login, password, name, surname, patronymic));

        /// <summary>
        /// Получить объект типа <see cref="User"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="User"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="User"/></returns>
        public static User GetUser(int id)
            => new UserRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="User"/>, отфильтрованную с помощью <see cref="UserFilter"/>
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="User"/></returns>
        public static IReadOnlyCollection<User> GetUsers(Filter filter)
            => new UserRepository().ReadAll(filter);

        /// <summary>
        /// Обновить объект типа <see cref="User"/> в базе
        /// </summary>
        /// <param name="userId">Идентификатор объекта типа <see cref="User"/></param>
        /// <param name="userTypeId">Идентификатор объекта типа <see cref="UserType"/></param>
        /// <param name="groupId">Идентификатор объекта типа <see cref="Group"/></param>
        /// <param name="login">Логин учётной записи пользователя</param>
        /// <param name="password">Пароль учётной записи пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        public static void UserUpdate(int userId, int userTypeId, int groupId, string login, string password, string name, string surname, string patronymic)
            => new UserRepository().Update(new User(userId, userTypeId, groupId, login, password, name, surname, patronymic));

        /// <summary>
        /// Удалить объект типа <see cref="User"/> из базы
        /// </summary>
        /// <param name="answerId">Идентификатор объекта типа <see cref="User"/></param>
        public static void UserDelete(int userId)
            => new AnswerRepository().Delete(userId);
    }
}

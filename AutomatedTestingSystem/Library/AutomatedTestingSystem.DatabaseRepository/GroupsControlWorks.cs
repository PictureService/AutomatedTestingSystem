namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Связь между групой и тестами
    /// </summary>
    public sealed class GroupsControlWorks
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Идентификатор группы в базе
        /// </summary>
        internal int GroupId { get; private set; }

        /// <summary>
        /// Идентификатор теста в базе
        /// </summary>
        internal int ControlWorkId { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="GroupsControlWorks"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="groupId">Идентификатор группы в базе</param>
        /// <param name="controlWorkId">Идентификатор теста в базе</param>
        internal GroupsControlWorks(int id, int groupId, int controlWorkId)
        {
            Id = id;
            GroupId = groupId;
            ControlWorkId = controlWorkId;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="GroupsControlWorks"/>
        /// </summary>
        /// <param name="groupId">Идентификатор группы в базе</param>
        /// <param name="controlWorkId">Идентификатор теста в базе</param>
        internal GroupsControlWorks(int groupId, int controlWorkId)
        {
            GroupId = groupId;
            ControlWorkId = controlWorkId;
        }
    }
}

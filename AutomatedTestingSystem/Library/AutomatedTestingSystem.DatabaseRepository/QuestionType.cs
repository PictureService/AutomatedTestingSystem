namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Тип вопроса
    /// </summary>
    public sealed class QuestionType
    {
        /// <summary>
        /// Идентефикатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }
        /// <summary>
        /// Название типа вопроса
        /// </summary>
        internal string Name { get; private set;}

        /// <summary>
        /// Конструктор для существующего объекта <see cref="QuestionType"/>
        /// </summary>
        /// <param name="id">Идентефикатор объекта в базе</param>
        /// <param name="name">Тип вопроса</param>
        internal QuestionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="QuestionType"/>    
        /// </summary>
        /// <param name="name">Тип вопроса</param>
        internal QuestionType(string name)
        {
            Name = name;
        }
    }
}

namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Ответ на вопрос
    /// </summary>
    /// <seealso cref="Question"/>
    public sealed class Answer
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Идентификатор вопроса в базе
        /// </summary>
        internal int QuestionId { get; private set; }

        /// <summary>
        /// Текст ответа на вопрос
        /// </summary>
        internal string Text { get; private set; }

        /// <summary>
        /// Является ли ответ верным
        /// </summary>
        internal bool IsTrue { get; private set; }
        
        /// <summary>
        /// Конструктор для существующего объекта <see cref="Answer"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="questionId">Идентификатор вопроса в базе</param>
        /// <param name="text">Текст ответа на вопрос</param>
        /// <param name="isTrue">Является ли ответ верным</param>
        internal Answer(int id, int questionId, string text, bool isTrue)
        {
            Id = id;
            QuestionId = questionId;
            Text = text;
            IsTrue = isTrue;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="Answer"/>
        /// </summary>
        /// <param name="questionId">Идентификатор вопроса в базе</param>
        /// <param name="text">Текст ответа на вопрос</param>
        /// <param name="isTrue">Является ли ответ верным</param>
        internal Answer(int questionId, string text, bool isTrue)
        {
            QuestionId = questionId;
            Text = text;
            IsTrue = isTrue;
        }
    }
}

using System;

namespace AutomatedTestingSystem.DatabaseRepository
{
    /// <summary>
    /// Один из вопросов теста
    /// </summary>
    public sealed class Question
    {
        /// <summary>
        /// Идентификатор объекта в базе
        /// </summary>
        internal int Id { get; private set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        internal string Text { get; private set; }

        /// <summary>
        /// Идентификатор теста, которому принадлежит вопрос
        /// </summary>
        internal int ControlWorkId { get; private set; }

        /// <summary>
        /// Идентификатор типа теста
        /// </summary>
        internal int QuestionTypeId { get; private set; }

        /// <summary>
        /// Дата добавления вопроса
        /// </summary>
        internal DateTime DateAdd { get; private set; }

        /// <summary>
        /// Конструктор для существующего объекта <see cref="Question"/>
        /// </summary>
        /// <param name="id">Идентификатор объекта в базе</param>
        /// <param name="text">Текст вопроса</param>
        /// <param name="controlWorkId">Идентификатор теста, которому принадлежит вопрос</param>
        /// <param name="questionTypeId">Идентификатор типа теста</param>
        /// <param name="dateAdd">Дата добавления вопроса</param>
        internal Question(int id, string text, int controlWorkId, int questionTypeId, DateTime dateAdd)
        {
            Id = id;
            Text = text;
            ControlWorkId = controlWorkId;
            QuestionTypeId = questionTypeId;
            DateAdd = dateAdd;
        }

        /// <summary>
        /// Конструктор для нового объекта <see cref="Question"/>
        /// </summary>
        /// <param name="text">Текст вопроса</param>
        /// <param name="controlWorkId">Идентификатор теста, которому принадлежит вопрос</param>
        /// <param name="questionTypeId">Идентификатор типа теста</param>
        /// <param name="dateAdd">Дата добавления вопроса</param>
        internal Question(string text, int controlWorkId, int questionTypeId, DateTime dateAdd)
        {
            Text = text;
            ControlWorkId = controlWorkId;
            QuestionTypeId = questionTypeId;
            DateAdd = dateAdd;
        }
    }
}

using System;
using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Создать объект типа <see cref="Question"/>
        /// Возвращает идентификатор объекта
        /// </summary>
        /// <param name="text">Текст вопроса</param>
        /// <param name="controlWorkId">Идентификатор объекта <see cref="ControlWork"/></param>
        /// <param name="questionTypeId">Идентификатор объекта <see cref="QuestionType"/></param>
        /// <param name="dateAdd">Дата добавления вопроса</param>
        /// <returns>Возвращает идентификатор объекта</returns>
        public static int QuestionCreate(string text, int controlWorkId, int questionTypeId, DateTime dateAdd)
            => new QuestionRepository().Create(new Question(text, controlWorkId, questionTypeId, dateAdd));

        /// <summary>
        /// Получить объект типа <see cref="Question"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="Question"/></param>
        /// <returns>Возвращает готовый объект типа <see cref="Question"/></returns>
        public static Question GetQuestion(int id)
            => new QuestionRepository().Read(id);

        /// <summary>
        /// Получить коллекцию объектов типа <see cref="Question"/>, отфильтрованную с помощью <see cref="QuestionFilter"/> 
        /// </summary>
        /// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
        /// <returns>Возвращает коллекцию объектов типа <see cref="Question"/></returns>
        public static IReadOnlyCollection<Question> GetQuestions(Filter filter)
            => new QuestionRepository().ReadAll(filter);

        /// <summary>
        /// Обновить объект типа <see cref="Question"/> в базе
        /// </summary>
        /// <param name="questionId">Идентификатор объекта типа <see cref="Question"/></param>
        /// <param name="text">Текст вопроса</param>
        /// <param name="controlWorkId">Идентификатор объекта <see cref="ControlWork"/></param>
        /// <param name="questionTypeId">Идентификатор объекта <see cref="QuestionType"/></param>
        /// <param name="dateAdd">Дата добавления вопроса</param>
        public static void QuestionUpdate(int questionId, string text, int controlWorkId, int questionTypeId, DateTime dateAdd)
            => new QuestionRepository().Update(new Question(questionId, text, controlWorkId, questionId, dateAdd));

        /// <summary>
        /// Удалить объект типа <see cref="Question"/> из базы
        /// </summary>
        /// <param name="questionId">Идентификатор объекта типа <see cref="Question"/></param>
        public static void QuestionDelete(int questionId)
            => new QuestionRepository().Delete(questionId);


    }
}

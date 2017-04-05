using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
	public partial class DatabaseManager
	{
		/// <summary>
		/// Создать объект типа <see cref="Answer"/>.
		/// Возвращает идентификатор объекта.
		/// </summary>
		/// <param name="questionId">Идентификатор объекта <see cref="Question"/></param>
		/// <param name="text">Текст ответа</param>
		/// <param name="isTrue">Признак того, является ли ответ верным</param>
		/// <returns>Возвращает идентификатор объекта</returns>
		public static int AnswerCreate(int questionId, string text, bool isTrue)
			=> new AnswerRepository().Create(new Answer(questionId, text, isTrue));

		/// <summary>
		/// Получить объект типа <see cref="Answer"/> по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор объекта типа <see cref="Answer"/></param>
		/// <returns>Возвращает готовый объект типа <see cref="Answer"/></returns>
		public static Answer AnswerReadById(int id)
			=> new AnswerRepository().Read(id);

		/// <summary>
		/// Получить коллекцию объектов типа <see cref="Answer"/>, отфильтрованную с помощью <see cref="AnswerFilter"/>
		/// </summary>
		/// <param name="filter">Фильтр для отбора необходимых значений. Null, если необходимо получить все значения.</param>
		/// <returns>Возвращает коллекцию объектов типа <see cref="Answer"/></returns>
		public static IReadOnlyCollection<Answer> ReadAll(Filter filter)
			=> new AnswerRepository().ReadAll(filter);

		/// <summary>
		/// Обновить объект типа <see cref="Answer"/> в базе
		/// </summary>
		/// <param name="answerId">Идентификатор объекта типа <see cref="Answer"/></param>
		/// <param name="questionId">Идентификатор объекта <see cref="Question"/></param>
		/// <param name="text">Текст ответа</param>
		/// <param name="isTrue">Признак того, является ли ответ верным</param>
		public static void AnswerUpdate(int answerId, int questionId, string text, bool isTrue)
			=> new AnswerRepository().Update(new Answer(answerId, questionId, text, isTrue));

		/// <summary>
		/// Удалить объект типа <see cref="Answer"/> из базы
		/// </summary>
		/// <param name="answerId">Идентификатор объекта типа <see cref="Answer"/></param>
		public static void AnswerDelete(int answerId)
			=> new AnswerRepository().Delete(answerId);
	}
}

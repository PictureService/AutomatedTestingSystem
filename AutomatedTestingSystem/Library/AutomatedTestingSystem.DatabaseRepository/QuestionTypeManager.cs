using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public partial class DatabaseManager
    {
        /// <summary>
        /// Получить объект типа <see cref="QuestionType"/> по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта типа <see cref="QuestionType"/></param>
        /// <returns></returns>
        public static QuestionType GetQuestionType(int id)
            => new QuestionTypeRepository().Read(id);

        /// <summary>
        /// Получить объект типа <see cref="QuestionType"/>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Возвращает готовый объект типа <see cref="QuestionType"/></returns>
        public static IReadOnlyCollection<QuestionType> GetQuestionTypes(Filter filter)
            => new QuestionTypeRepository().ReadAll(filter);
    }
}

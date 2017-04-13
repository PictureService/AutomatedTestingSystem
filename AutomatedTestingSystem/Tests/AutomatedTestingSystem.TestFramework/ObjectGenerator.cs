using AutomatedTestingSystem.TestFramework.IEnumerableExtensions;
using System.Collections.Generic;
using System.Linq;

namespace AutomatedTestingSystem.TestFramework
{
	public static class ObjectGenerator
	{
		public static ATSDbContext DbContext = new ATSDbContext();

		public static Answer GetAnswer (int? id)
		{
			if (id == null)
			{
				return DbContext.Answers.FirstRandom();
			}
			else
			{
				return DbContext.Answers.First(x => x.Id == id);
			}
		}

		public static IReadOnlyCollection<Answer> GetAnswers
			=> DbContext.Answers.ToList();
	}
}

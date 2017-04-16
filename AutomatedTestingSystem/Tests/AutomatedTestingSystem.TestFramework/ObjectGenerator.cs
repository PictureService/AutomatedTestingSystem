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

        public static ControlWork GetControlWork(int? id)
        {
            if (id == null)
            {
                return DbContext.ControlWorks.FirstRandom();
            }
            else
            {
                return DbContext.ControlWorks.First(x => x.Id == id);
            }
        }

        public static ControlWorkResult GetControlWorkResult(int? id)
        {
            if (id == null)
            {
                return DbContext.ControlWorkResults.FirstRandom();
            }
            else
            {
                return DbContext.ControlWorkResults.First(x => x.Id == id);
            }
        }

        public static Question GetQuestion(int? id)
        {
            if (id == null)
            {
                return DbContext.Questions.FirstRandom();
            }
            else
            {
                return DbContext.Questions.First(x => x.Id == id);
            }
        }

        public static QuestionType GetQuestionType(int? id)
        {
            if (id == null)
            {
                return DbContext.QuestionTypes.FirstRandom();
            }
            else
            {
                return DbContext.QuestionTypes.First(x => x.Id == id);
            }
        }

        public static TestType GetTestType(int? id)
        {
            if (id == null)
            {
                return DbContext.TestTypes.FirstRandom();
            }
            else
            {
                return DbContext.TestTypes.First(x => x.Id == id);
            }
        }

        public static Group GetGroup(int? id)
        {
            if (id == null)
            {
                return DbContext.Groups.FirstRandom();
            }
            else
            {
                return DbContext.Groups.First(x => x.Id == id);
            }
        }

        public static GroupsControlWork GeGroupsControlWork(int? id)
        {
            if (id == null)
            {
                return DbContext.GroupsControlWorks.FirstRandom();
            }
            else
            {
                return DbContext.GroupsControlWorks.First(x => x.Id == id);
            }
        }

        public static GroupType GetGroupType(int? id)
        {
            if (id == null)
            {
                return DbContext.GroupTypes.FirstRandom();
            }
            else
            {
                return DbContext.GroupTypes.First(x => x.Id == id);
            }
        }

        public static User GetUser(int? id)
        {
            if (id == null)
            {
                return DbContext.Users.FirstRandom();
            }
            else
            {
                return DbContext.Users.First(x => x.Id == id);
            }
        }

        public static UserType GetUserType(int? id)
        {
            if (id == null)
            {
                return DbContext.UserTypes.FirstRandom();
            }
            else
            {
                return DbContext.UserTypes.First(x => x.Id == id);
            }
        }

        public static IReadOnlyCollection<Answer> GetAnswers
			=> DbContext.Answers.ToList();

        public static IReadOnlyCollection<ControlWork> ControlWorks
            => DbContext.ControlWorks.ToList();

        public static IReadOnlyCollection<ControlWorkResult> GetControlWorkResults
            => DbContext.ControlWorkResults.ToList();

        public static IReadOnlyCollection<Question> GetQuestions
           => DbContext.Questions.ToList();

        public static IReadOnlyCollection<QuestionType> GetQuestionTypes
            => DbContext.QuestionTypes.ToList();

        public static IReadOnlyCollection<TestType> GetTestTypes
            => DbContext.TestTypes.ToList();

        public static IReadOnlyCollection<Group> GetGroups
            => DbContext.Groups.ToList();

        public static IReadOnlyCollection<GroupsControlWork> GetGroupsControlWorks
            => DbContext.GroupsControlWorks.ToList();

        public static IReadOnlyCollection<GroupType> GetGroupTypes
           => DbContext.GroupTypes.ToList();

        public static IReadOnlyCollection<User> GetUsers
            => DbContext.Users.ToList();

        public static IReadOnlyCollection<UserType> GetUserTypes
            => DbContext.UserTypes.ToList();

    
    }
}

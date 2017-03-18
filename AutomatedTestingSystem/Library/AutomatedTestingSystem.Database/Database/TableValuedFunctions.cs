namespace AutomatedTestingSystem.Database
{
    /// <summary>
    /// Класс, представляющий список табличных функций
    /// </summary>
    public static class TableValuedFunctions
    {
        /// <summary>
        /// Схема Tests
        /// </summary>
        public static class Tests
        {
            /// <summary>
            /// Получение списка ответов
            /// </summary>
            public const string Answer_Read = "SELECT * FROM [Tests].[Answer_Read](@AnswerId, @QuestionId)";
            /// <summary>
            /// Получение списка вопросов
            /// </summary>
            public const string ControlWork_Read = "SELECT * FROM [Tests].[ControlWork_Read](@ControlWorkId, @AuthorUserId, @TestTypeId)";
            /// <summary>
            /// Получение списка результатов
            /// </summary>
            public const string ControlWorkResult_Read = "SELECT * FROM [Tests].[ControlWorkResult_Read](@ControlWorkResultId, @ControlWorkId, @UserId)";
            /// <summary>
            /// Получение списка вопросов
            /// </summary>
            public const string Question_Read = "SELECT * FROM [Tests].[Question_Read](@QuestionId, @ControlWorkId, @QuestionTypeId)";
            /// <summary>
            /// Получение списка типов вопросов
            /// </summary>
            public const string QuestionType_Read = "SELECT * FROM [Tests].[QuestionType_Read](@QuestionTypeId)";
            /// <summary>
            /// Получение списка типов теста
            /// </summary>
            public const string TestType_Read = "SELECT * FROM [Tests].[TestType_Read](@TestTypeId)";

        }
        /// <summary>
        /// Схема Users
        /// </summary>
        public static class Users
        {
            /// <summary>
            /// Получение списка групп
            /// </summary>
            public const string Group_Read = "SELECT * FROM [Users].[Group_Read](@GroupId, @GroupTypeId)";
            /// <summary>
            /// Получение списка связей: к каким тестам группа имеет доступ
            /// </summary>
            public const string GroupsControlWorks_Read = "SELECT * FROM [Users].[GroupsControlWorks_Read](@GroupControlWorkId, @GroupId, @ControlWorkId)";
            /// <summary>
            /// Получение списка типов групп
            /// </summary>
            public const string GroupType_Read = "SELECT * FROM [Users].[GroupType_Read](@GroupTypeID)";
            /// <summary>
            /// Получение списка юзеров
            /// </summary>
            public const string User_Read = "SELECT * FROM [Users].[User_Read](@UserId, @UserTypeId, @GroupId)";
            /// <summary>
            /// Получение списка типов юзеров
            /// </summary>
            public const string UserType_Read = "SELECT * FROM [Users].[UserType_Read](@UserTypeId)";
  
        }
    }
}

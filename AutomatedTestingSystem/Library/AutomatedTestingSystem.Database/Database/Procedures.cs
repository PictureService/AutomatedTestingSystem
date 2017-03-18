namespace AutomatedTestingSystem.Database
{
    /// <summary>
    /// Класс, представляющий список процедур
    /// </summary>
    public static class Procedures
    {
        /// <summary>
        /// Схема Tests
        /// </summary>
        public static class Tests
        {
            /// <summary>
            /// Создание ответа на вопрос
            /// </summary>
            public const string Answer_Create = "[Tests].[Answer_Create]";
            /// <summary>
            /// Удаление ответа
            /// </summary>
            public const string Answer_Delete = "[Tests].[Answer_Delete]";
            /// <summary>
            /// Изменение ответа
            /// </summary>
            public const string Answer_Update = "[Tests].[Answer_Update]";

            /// <summary>
            /// Создание вопроса
            /// </summary>
            public const string ControlWork_Create = "[Tests].[ControlWork_Create]";
            /// <summary>
            /// Удаление вопроса
            /// </summary>
            public const string ControlWork_Delete = "[Tests].[ControlWork_Delete]";
            /// <summary>
            /// Изменение вопроса
            /// </summary>
            public const string ControlWork_Update = "[Tests].[ControlWork_Update]";
            /// <summary>
            /// Создание результата прохождения теста
            /// </summary>
            public const string ControlWorkResult_Create = "[Tests].[ControlWorkResult_Create]";
            /// <summary>
            /// Удаление результата прохождения теста
            /// </summary>
            public const string ControlWorkResult_Delete = "[Tests].[ControlWorkResult_Delete]";

            /// <summary>
            /// Создание вопроса
            /// </summary>
            public const string Question_Create = "[Tests].[Question_Create]";
            /// <summary>
            /// Удаление вопроса
            /// </summary>
            public const string Question_Delete = "[Tests].[Question_Delete]";
            /// <summary>
            /// Изменение вопроса
            /// </summary>
            public const string Question_Update = "[Tests].[Question_Update]";
        }

        /// <summary>
        /// Схема Users
        /// </summary>
        public static class Users
        {
            /// <summary>
            /// Создание группы
            /// </summary>
            public const string Group_Create = "[Users].[Group_Create]";
            /// <summary>
            /// Удаление группы
            /// </summary>
            public const string Group_Delete = "[Users].[Group_Delete]";
            /// <summary>
            /// Изменение группы
            /// </summary>
            public const string Group_Update = "[Users].[Group_Update]";

            /// <summary>
            /// Создание связи между группой и тестом (связь, к каким тестам группа имеет доступ)
            /// </summary>
            public const string GroupControlWork_Create = "[Users].[GroupControlWork_Create]";
            /// <summary>
            /// Удаление связи между группой и тестом
            /// </summary>
            public const string GroupControlWork_Delete = "[Users].[GroupControlWork_Delete]";

            /// <summary>
            /// Создание пользователя
            /// </summary>
            public const string User_Create = "[Users].[User_Create]";
            /// <summary>
            /// Удаление пользователя
            /// </summary>
            public const string User_Delete = "[Users].[User_Delete]";
            /// <summary>
            /// Изменение пользователя
            /// </summary>
            public const string User_Update = "[Users].[User_Update]";
        }
    }
}

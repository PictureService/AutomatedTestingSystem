namespace AutomatedTestingSystem.Database
{
    public static class Procedures
    {
        public static class Tests
        {
            public const string Answer_Create = "[Tests].[Answer_Create]";
            public const string Answer_Delete = "[Tests].[Answer_Delete]";
            public const string Answer_Update = "[Tests].[Answer_Update]";

            public const string ControlWork_Create = "[Tests].[ControlWork_Create]";
            public const string ControlWork_Delete = "[Tests].[ControlWork_Delete]";
            public const string ControlWork_Update = "[Tests].[ControlWork_Update]";

            public const string ControlWorkResult_Create = "[Tests].[ControlWorkResult_Create]";
            public const string ControlWorkResult_Delete = "[Tests].[ControlWorkResult_Delete]";

            public const string Question_Create = "[Tests].[Question_Create]";
            public const string Question_Delete = "[Tests].[Question_Delete]";
            public const string Question_Update = "[Tests].[Question_Update]";
        }

        public static class Users
        {
            public const string Group_Create = "[Users].[Group_Create]";
            public const string Group_Delete = "[Users].[Group_Delete]";
            public const string Group_Update = "[Users].[Group_Update]";

            public const string GroupControlWork_Create = "[Users].[GroupControlWork_Create]";
            public const string GroupControlWork_Delete = "[Users].[GroupControlWork_Delete]";

            public const string User_Create = "[Users].[User_Create]";
            public const string User_Delete = "[Users].[User_Delete]";
            public const string User_Update = "[Users].[User_Update]";
        }
    }
}

namespace AutomatedTestingSystem.Database
{
    public static class TableValuedFunctions
    {
        public static class Tests
        {
            public const string Answer_Read = "SELECT * FROM [Tests].[Answer_Read](@AnswerId, @QuestionId)";
            public const string ControlWork_Read = "SELECT * FROM [Tests].[ControlWork_Read](@ControlWorkId, @AuthorUserId, @TestTypeId)";
            public const string ControlWorkResult_Read = "SELECT * FROM [Tests].[ControlWorkResult_Read](@ControlWorkResultId, @ControlWorkId, @UserId)";
            public const string Question_Read = "SELECT * FROM [Tests].[Question_Read](@QuestionId, @ControlWorkId, @QuestionTypeId)";
            public const string QuestionType_Read = "SELECT * FROM [Tests].[QuestionType_Read](@QuestionTypeId)";
            public const string TestType_Read = "SELECT * FROM [Tests].[TestType_Read](@TestTypeId)";

        }
        public static class Users
        {
            public const string Group_Read = "SELECT * FROM [Users].[Group_Read](@GroupId, @GroupTypeId)";
            public const string GroupsControlWorks_Read = "SELECT * FROM [Users].[GroupsControlWorks_Read](@GroupControlWorkId, @GroupId, @ControlWorkId)";
            public const string GroupType_Read = "SELECT * FROM [Users].[GroupType_Read](@GroupTypeID)";
            public const string User_Read = "SELECT * FROM [Users].[User_Read](@UserId, @UserTypeId, @GroupId)";
            public const string UserType_Read = "SELECT * FROM [Users].[UserType_Read](@UserTypeId)";
        }
    }
}

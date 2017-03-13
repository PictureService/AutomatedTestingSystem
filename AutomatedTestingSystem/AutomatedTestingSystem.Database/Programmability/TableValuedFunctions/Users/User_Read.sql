CREATE FUNCTION [Users].[User_Read]
(
	@UserId INT,
	@UserTypeId INT,
	@GroupId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [UserId],
		[UserTypeId],
		[GroupId],
		[Login] AS [UserLogin],
		[Password] AS [UserPassword],
		[Name] AS [UserName],
		[Surname] AS [UserSurname],
		[Patronymic] AS [UserPatronymic]
FROM	[Users].[User]
WHERe	(@UserId = -1 OR [Id] = @UserId)
	AND (@UserTypeId = -1 OR [UserTypeId] = @UserTypeId)
	AND (@GroupId = -1 OR [GroupId] = @GroupId)


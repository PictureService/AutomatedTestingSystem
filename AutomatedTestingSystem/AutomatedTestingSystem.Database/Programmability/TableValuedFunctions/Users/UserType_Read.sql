CREATE FUNCTION [Users].[UserType_Read]
(
	@UserTypeId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [UserTypeId],
		[Name] AS [UserTypeName]
FROM [Users].[UserType]
WHERE (@UserTypeId = -1 OR [Id] = @UserTypeId)

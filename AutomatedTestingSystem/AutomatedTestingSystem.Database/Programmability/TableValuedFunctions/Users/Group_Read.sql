CREATE FUNCTION [Users].[Group_Read]
(
	@GroupId INT,
	@GroupTypeId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [GroupId],
		[GroupTypeId],
		[Name] AS [GroupName]
FROM	[Users].[Group]
WHERE	(@GroupId = -1 OR [Id] = @GroupId)
	AND (@GroupTypeId = -1 OR [GroupTypeId] = @GroupTypeId)
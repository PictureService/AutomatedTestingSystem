CREATE FUNCTION [Users].[GroupType_Read]
(
	@GroupTypeId INT
)
RETURNS  TABLE
AS
RETURN
SELECT	[Id] AS [GroupTypeId],
		[Name] AS [GroupTypeName]
FROM	[Users].[GroupType]
WHERE	(@GroupTypeId = -1 OR [Id] = @GroupTypeId)

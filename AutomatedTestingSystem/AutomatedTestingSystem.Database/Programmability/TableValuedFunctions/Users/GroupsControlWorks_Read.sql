CREATE FUNCTION [Users].[GroupsControlWorks_Read]
(
	@GroupControlWorkId INT,
	@GroupId INT,
	@ControlWorkId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [GroupControlWorkId],
		[GroupId],
		[ControlWorkId]
FROM	[Users].[GroupsControlWorks]
WHERE	(@GroupControlWorkId = -1 OR [Id] = @GroupControlWorkId)
	AND (@GroupId = -1 OR [GroupId] = @GroupId)
	AND (@ControlWorkId = -1 OR [ControlWorkId] = @ControlWorkId)

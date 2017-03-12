CREATE FUNCTION [Tests].[ControlWork_Read]
(
	@ControlWorkId INT,
	@AuthorUserId INT,
	@TestTypeId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [ControlWorkId],
		[AuthorUserId],
		[TestTypeId],
		[Name] AS [ControlWorkName],
		[Description] AS [ControlWorkDescription]
FROM	[Tests].[ControlWork]
WHERE	(@ControlWorkId = -1 OR [Id] = @ControlWorkId) 
	AND (@AuthorUserId = -1 OR [AuthorUserId] = @AuthorUserId)
	AND (@TestTypeId = -1 OR [TestTypeId] = @TestTypeId)
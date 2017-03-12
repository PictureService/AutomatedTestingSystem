CREATE FUNCTION [Tests].[ControlWorkResult_Read]
(
	@ControlWorkResultId INT,
	@ControlWorkId INT,
	@UserId INT
)
RETURNS  TABLE
AS
RETURN
SELECT	[Id] AS [ControlWorkResultId],
		[ControlWorkId],
		[UserId],
		[CountTrueAnswers]
FROM	[Tests].[ControlWorkResult]
WHERE	(@ControlWorkResultId = -1 OR [Id] = @ControlWorkResultId)
	AND (@ControlWorkId = -1 OR [ControlWorkId] = @ControlWorkId)
	AND (@UserId = -1 OR [UserId] = @UserId)

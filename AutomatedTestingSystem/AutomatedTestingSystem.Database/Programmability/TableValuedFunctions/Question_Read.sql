CREATE FUNCTION [Tests].[Question_Read]
(
	@QuestionId INT,
	@ControlWorkId INT,
	@QuestionTypeId INT
)
RETURNS TABLE
AS
RETURN
SELECT	[Id] AS [QuestionId],
		[ControlWorkId],
		[QuestionTypeId],
		[Text] AS [QuestionText],
		[DateAdd] AS [QuestionDateAdd]
FROM	[Tests].[Question]
WHERE	(@QuestionId = -1 OR [Id] = @QuestionId)
	AND (@ControlWorkId = -1 OR [ControlWorkId] = @ControlWorkId)
	AND (@QuestionTypeId = -1 OR [QuestionTypeId] = @QuestionTypeId)

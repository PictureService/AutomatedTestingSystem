CREATE FUNCTION [Tests].[Answer_Read]
(
	@AnswerId INT,
	@QuestionId INT
)
RETURNS TABLE
AS
RETURN 
SELECT	[Id] AS [AnswerId],
		[QuestionId],
		[Text] AS [AnswerText],
		[IsTrue] AS [AnswerIsTrue]
FROM	[Tests].[Answer]
WHERE	(@AnswerId = -1 OR [Id] = @AnswerId)
	AND (@QuestionId = -1 OR [QuestionId] = @QuestionId)
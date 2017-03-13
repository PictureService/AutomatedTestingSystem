CREATE FUNCTION [Tests].[QuestionType_Read]
(
	@QuestionTypeId INT
)
RETURNS  TABLE
AS
RETURN
SELECT	[Id] AS [QuestionTypeId],
		[Name] AS [QuestionTypeName]
FROM	[Tests].[QuestionType]
WHERE	(@QuestionTypeId = -1 OR [Id] = @QuestionTypeId)
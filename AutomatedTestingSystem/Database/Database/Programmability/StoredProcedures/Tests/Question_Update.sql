CREATE PROCEDURE [Tests].[Question_Update]
(
	@QuestionId INT,
	@QuestionText NVARCHAR(500),
	@QuestionTypeId INT
)
AS
BEGIN
	UPDATE	[Tests].[Question]
	SET		[Text] = @QuestionText,
			[QuestionTypeId] = @QuestionTypeId
	WHERE	[Id] = @QuestionId
END

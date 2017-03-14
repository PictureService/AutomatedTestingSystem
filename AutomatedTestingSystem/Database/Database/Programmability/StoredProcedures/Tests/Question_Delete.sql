CREATE PROCEDURE [Tests].[Question_Delete]
(
	@QuestionId INT
)
AS
BEGIN
	DELETE	[Tests].[Question]
	WHERE	[Id] = @QuestionId
END

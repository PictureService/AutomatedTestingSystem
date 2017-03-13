CREATE PROCEDURE [Tests].[Answer_Create]
(
	@QuestionId INT,
	@Text NVARCHAR(100),
	@IsTrue BIT
)
AS
BEGIN
	INSERT [Tests].[Answer]
		(
			[QuestionId],
			[Text],
			[IsTrue]
		)
	VALUES
		(
			@QuestionId,
			@Text,
			@IsTrue
		)

	SELECT SCOPE_IDENTITY()
END
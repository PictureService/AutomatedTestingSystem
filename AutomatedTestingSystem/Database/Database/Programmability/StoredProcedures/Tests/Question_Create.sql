CREATE PROCEDURE [Tests].[Question_Create]
(
	@Text NVARCHAR(500),
	@ControlWorkId INT,
	@QuestionTypeId INT,
	@DateAdd DATETIME
)
AS
BEGIN
	INSERT [Tests].[Question]
		(
			[Text],
			[ControlWorkId],
			[QuestionTypeId],
			[DateAdd]
		)
	VALUES
		(
			@Text,
			@ControlWorkId,
			@QuestionTypeId,
			@DateAdd
		)
	SELECT SCOPE_IDENTITY()
END

CREATE PROCEDURE [Tests].[ControlWorkResult_Create]
(
	@ControlWorkId INT,
	@UserId INT,
	@CountTrueAnsers INT
)
AS
BEGIN
	INSERT [Tests].[ControlWorkResult]
		(
			[ControlWorkId],
			[UserId],
			[CountTrueAnswers]
		)
	VALUES
		(
			@ControlWorkId,
			@UserId,
			@CountTrueAnsers
		)
	SELECT SCOPE_IDENTITY()
END

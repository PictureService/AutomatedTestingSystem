CREATE PROCEDURE [Tests].[Answer_Update]
(
	@AnswerId INT,
	@Text NVARCHAR(100),
	@IsTrue BIT
)
AS
BEGIN
	UPDATE	[Tests].[Answer]
	SET		[Text] = @Text,
			[IsTrue] = @IsTrue
	WHERE	[Id] = @AnswerId
END

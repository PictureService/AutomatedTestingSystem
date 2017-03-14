CREATE PROCEDURE [Tests].[Answer_Delete]
(
	@AnswerId INT
)
AS
BEGIN
	DELETE	[Tests].[Answer]
	WHERE	[Id] = @AnswerId
END
CREATE PROCEDURE [Users].[User_Delete]
(
	@UserId INT
)
AS
BEGIN
	DELETE	[Users].[User]
	WHERE	[Id] = @UserId
END

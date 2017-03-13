CREATE PROCEDURE [Users].[GroupControlWork_Delete]
(
	@GroupControlWorkId INT
)
AS
BEGIN
	DELETE	[Users].[GroupsControlWorks]
	WHERE	[Id] = @GroupControlWorkId
END

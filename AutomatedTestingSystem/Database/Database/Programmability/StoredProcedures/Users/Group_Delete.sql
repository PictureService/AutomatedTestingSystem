CREATE PROCEDURE [Users].[Group_Delete]
(
	@GroupId INT
)
AS
BEGIN
	DELETE	[Users].[Group]
	WHERE	[Id] = @GroupId
END
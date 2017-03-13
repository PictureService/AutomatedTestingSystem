CREATE PROCEDURE [Users].[GroupControlWork_Create]
(
	@GroupId INT,
	@ControlWorkId INT
)
AS
BEGIN
	INSERT [Users].[GroupsControlWorks]
		(
			[GroupId],
			[ControlWorkId]
		)
	VALUES
		(
			@GroupId,
			@ControlWorkId
		)

	SELECT SCOPE_IDENTITY()
END

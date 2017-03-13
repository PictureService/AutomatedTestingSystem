CREATE PROCEDURE [Users].[Group_Create]
(
	@Name NVARCHAR(100),
	@GroupTypeId INT
)
AS
BEGIN
	INSERT [Users].[Group]
		(
			[Name],
			[GroupTypeId]
		)
	VALUES
		(
			@Name,
			@GroupTypeId
		)
	SELECT SCOPE_IDENTITY()
END

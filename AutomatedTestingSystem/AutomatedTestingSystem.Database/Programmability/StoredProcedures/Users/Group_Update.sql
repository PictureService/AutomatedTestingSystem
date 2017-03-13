CREATE PROCEDURE [Users].[Group_Update]
(
	@GroupId INT,
	@GroupName NVARCHAR(100),
	@GroupTypeId INT
)
As
BEGIN
	UPDATE	[Users].[Group]
	SET		[Name] = @GroupName,
			[GroupTypeId] = @GroupTypeId
	WHERE	[Id] = @GroupId
END
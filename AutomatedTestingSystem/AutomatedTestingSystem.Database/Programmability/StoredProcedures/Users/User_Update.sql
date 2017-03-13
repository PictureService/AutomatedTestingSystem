CREATE PROCEDURE [Users].[User_Update]
(
	@UserId INT,
	@UserTypeId INT,
	@GroupId INT,
	@Login NVARCHAR(200),
	@Password NVARCHAR(50),
	@UserName NVARCHAR(150),
	@Surname NVARCHAR(150),
	@Patronymic NVARCHAR(150)
)
AS
BEGIN
	UPDATE	[Users].[User]
	SEt		[UserTypeId] = @UserTypeId,
			[GroupId] = @GroupId,
			[Login] = @Login,
			[Password] = @Password,
			[Name] = @UserName,
			[Surname] = @Surname,
			[Patronymic] = @Patronymic
	WHERE	[Id] = @UserId
END
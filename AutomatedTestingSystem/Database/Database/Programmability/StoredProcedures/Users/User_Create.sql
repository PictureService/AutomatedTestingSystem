CREATE PROCEDURE [Users].[User_Create]
(
	@UserTypeId INT,
	@GroupId INT,
	@Login NVARCHAR(200),
	@Password NVARCHAR(50),
	@Name NVARCHAR(150),
	@Surname NVARCHAR(150),
	@Patronymic NVARCHAR(150)
)
AS
BEGIN
	INSERT [Users].[User]
		(
			[UserTypeId],
			[GroupId],
			[Login],
			[Password],
			[Name],
			[Surname],
			[Patronymic]
		)
	VALUES 
		(
			@UserTypeId,
			@GroupId,
			@Login,
			@Password,
			@Name,
			@Surname,
			@Patronymic
		)

	SELECT SCOPE_IDENTITY()
END

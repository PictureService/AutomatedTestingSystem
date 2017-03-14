CREATE PROCEDURE [Tests].[ControlWork_Create]
(
	@AuthorUserId INT,
	@Name NVARCHAR(100),
	@Description NVARCHAR(400),
	@TestTypeId INT
)
AS
BEGIN
	INSERT [Tests].[ControlWork]
		(
			[AuthorUserId],
			[Name],
			[Description],
			[TestTypeId]
		)
	VALUES
		(
			@AuthorUserId,
			@Name,
			@Description,
			@TestTypeId
		)

	SELECT SCOPE_IDENTITY()
END

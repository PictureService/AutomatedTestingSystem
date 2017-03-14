CREATE PROCEDURE [Tests].[ControlWork_Update]
(
	@ControlWorkId INT,
	@ControlWorkName NVARCHAR(100),
	@Description NVARCHAR(400),
	@TestTypeId INT
)
AS
BEGIN
	UPDATE	[Tests].[ControlWork]
	SET		[Name] = @ControlWorkName,
			[Description] = @Description,
			[TestTypeId] = @TestTypeId
	WHERE	[Id] = @ControlWorkId
END

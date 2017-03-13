CREATE PROCEDURE [Tests].[ControlWork_Delete]
(
	@ControlWorkId INT
)
AS
BEGIN
	DELETE	[Tests].[ControlWork]
	WHERE	[Id] = @ControlWorkId
END
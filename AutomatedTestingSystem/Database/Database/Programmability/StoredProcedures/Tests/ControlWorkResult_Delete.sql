CREATE PROCEDURE [Tests].[ControlWorkResult_Delete]
(
	@ControlWorkResultId INT
)
AS
BEGIN
	DELETE	[Tests].[ControlWorkResult]
	WHERE	[Id] = @ControlWorkResultId
END

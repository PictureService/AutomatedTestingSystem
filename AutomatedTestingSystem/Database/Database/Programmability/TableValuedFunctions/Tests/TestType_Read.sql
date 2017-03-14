CREATE FUNCTION [Tests].[TestType_Read]
(
	@TestTypeId INT
)
RETURNS  TABLE
AS
RETURN
SELECT	[Id] AS [TestTypeId],
		[Name] AS [TestTypeName]
FROM	[Tests].[TestType]
WHERE	(@TestTypeId = -1 OR [Id] = @TestTypeId)
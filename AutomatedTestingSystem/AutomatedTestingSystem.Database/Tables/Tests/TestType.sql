CREATE TABLE [Tests].[TestType]
(
	[Id]		INT				NOT NULL, 
    [Name]		NVARCHAR(50)	NOT NULL,
	CONSTRAINT [PK_TestType] PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Тип теста. Например зачет, экзамен.',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'TestType',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'TestType',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название типа теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'TestType',
    @level2type = N'COLUMN',
    @level2name = N'Name'
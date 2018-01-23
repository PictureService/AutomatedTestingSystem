CREATE TABLE [Tests].[ControlWork]
(
	[Id]			INT				NOT NULL IDENTITY, 
    [AuthorUserId]	INT				NOT NULL, 
    [Name]			NVARCHAR(100)	NOT NULL, 
    [Description]	NVARCHAR(400)	NULL, 
    [TestTypeId]	INT				NOT NULL,
	CONSTRAINT [PK_ControlWork] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_ControlWork_User] FOREIGN KEY ([AuthorUserId]) REFERENCES [Users].[User]([Id]),
	CONSTRAINT [FK_ControlWork_TestType] FOREIGN KEY ([TestTypeId]) REFERENCES [Tests].[TestType]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Непосредственно тесты, которые должны будут создавать одни пользователи и проходить другие.',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор автора теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = N'COLUMN',
    @level2name = N'AuthorUserId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Описание теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = N'COLUMN',
    @level2name = N'Description'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWork',
    @level2type = N'COLUMN',
    @level2name = N'TestTypeId'
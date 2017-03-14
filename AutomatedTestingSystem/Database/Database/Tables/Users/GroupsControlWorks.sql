CREATE TABLE [Users].[GroupsControlWorks]
(
	[Id]			INT NOT NULL, 
    [GroupId]		INT NOT NULL, 
    [ControlWorkId]	INT NOT NULL,
	CONSTRAINT [PK_GroupsControlWork] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_GroupsControlWorks_Group] FOREIGN KEY ([GroupId]) REFERENCES [Users].[Group]([Id]), 
    CONSTRAINT [FK_GroupsControlWorks_ControlWork] FOREIGN KEY ([ControlWorkId]) REFERENCES [Tests].[ControlWork]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Связь, к каким тестам группа имеет доступ',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupsControlWorks',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор связи',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupsControlWorks',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupsControlWorks',
    @level2type = N'COLUMN',
    @level2name = N'GroupId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор теста',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupsControlWorks',
    @level2type = N'COLUMN',
    @level2name = N'ControlWorkId'
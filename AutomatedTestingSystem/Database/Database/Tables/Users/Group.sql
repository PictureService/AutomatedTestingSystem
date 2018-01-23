CREATE TABLE [Users].[Group]
(
	[Id]			INT				NOT NULL IDENTITY, 
    [Name]			NVARCHAR(100)	NOT NULL, 
    [GroupTypeId]	INT				NOT NULL,
	CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Group_GroupType] FOREIGN KEY ([GroupTypeId]) REFERENCES [Users].[GroupType]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Группа пользователя. Используется для иерархичного вывода списка пользователей.',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'Group',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'Group',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'Group',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Тип группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'Group',
    @level2type = N'COLUMN',
    @level2name = N'GroupTypeId'
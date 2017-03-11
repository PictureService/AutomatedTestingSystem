CREATE TABLE [Users].[GroupType]
(
	[Id]	INT				NOT NULL, 
    [Name]	NVARCHAR(50)	NOT NULL,
	CONSTRAINT [PK_GroupType] PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupType',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название типа группы',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupType',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Тип группы пользователя. Например студенты, преподаватели, администраторы.',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'GroupType',
    @level2type = NULL,
    @level2name = NULL
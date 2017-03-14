CREATE TABLE [Users].[UserType]
(
	[Id]	INT				NOT NULL, 
    [Name]	NVARCHAR(50)	NOT NULL,
	CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Тип пользователя. Например администратор, преподаватель, студент.',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'UserType',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'UserType',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название типа пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'UserType',
    @level2type = N'COLUMN',
    @level2name = N'Name'
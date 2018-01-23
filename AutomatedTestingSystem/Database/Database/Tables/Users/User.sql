CREATE TABLE [Users].[User]
(
	[Id]			INT				NOT NULL IDENTITY, 
    [UserTypeId]	INT				NOT NULL, 
    [GroupId]		INT				NOT NULL, 
    [Login]			NVARCHAR(200)	NOT NULL, 
    [Password]		NVARCHAR(50)	NOT NULL, 
    [Name]			NVARCHAR(150)	NOT NULL, 
    [Surname]		NVARCHAR(150)	NOT NULL, 
    [Patronymic]	NVARCHAR(150)	NULL,
	CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_User_UserType] FOREIGN KEY ([UserTypeId]) REFERENCES [Users].[UserType]([Id]), 
    CONSTRAINT [FK_User_Group] FOREIGN KEY ([GroupId]) REFERENCES [Users].[Group]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Список пользователей, любых, которые могут присутствовать в системе',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'UserTypeId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор группы пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'GroupId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Логин пользователя, под которым он сможет авторизоваться',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Login'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Пароль пользователя, который он будет использовать для прохождения авторизации.',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Password'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Имя пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Фамилия пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Surname'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Отчество пользователя',
    @level0type = N'SCHEMA',
    @level0name = N'Users',
    @level1type = N'TABLE',
    @level1name = N'User',
    @level2type = N'COLUMN',
    @level2name = N'Patronymic'
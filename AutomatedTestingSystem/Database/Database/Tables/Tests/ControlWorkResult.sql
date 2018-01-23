CREATE TABLE [Tests].[ControlWorkResult]
(
	[Id]				INT NOT NULL IDENTITY, 
    [ControlWorkId]		INT NOT NULL, 
    [UserId]			INT NOT NULL, 
    [CountTrueAnswers]	INT NOT NULL,
	CONSTRAINT [PK_ControlWorkResult] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_ControlWorkResult_User] FOREIGN KEY ([UserId]) REFERENCES [Users].[User]([Id]), 
    CONSTRAINT [FK_ControlWorkResult_ControlWork] FOREIGN KEY ([ControlWorkId]) REFERENCES [Tests].[ControlWork]([Id])

)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Результат прохождения теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWorkResult',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор результата прохождения теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWorkResult',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор теста',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWorkResult',
    @level2type = N'COLUMN',
    @level2name = N'ControlWorkId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор пользователя, прошедшего тест',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWorkResult',
    @level2type = N'COLUMN',
    @level2name = N'UserId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Количество правильных ответов в процентном соотношении',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'ControlWorkResult',
    @level2type = N'COLUMN',
    @level2name = N'CountTrueAnswers'
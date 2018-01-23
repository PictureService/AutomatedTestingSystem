CREATE TABLE [Tests].[Question]
(
	[Id]				INT				NOT NULL IDENTITY, 
    [Text]				NVARCHAR(500)	NOT NULL, 
    [ControlWorkId]		INT				NOT NULL, 
    [QuestionTypeId]	INT				NOT NULL, 
    [DateAdd]			DATETIME		NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Question_ControlWork] FOREIGN KEY ([ControlWorkId]) REFERENCES [Tests].[ControlWork]([Id]),
	CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY ([QuestionTypeId]) REFERENCES [Tests].[QuestionType]([Id])  
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Вопрос, который добавляется к тесту и на который пользователи должны будут давать ответы.',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Текст вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = N'COLUMN',
    @level2name = N'Text'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор теста, к которому относится вопрос',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = N'COLUMN',
    @level2name = N'ControlWorkId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = N'COLUMN',
    @level2name = N'QuestionTypeId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Дата добавления вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Question',
    @level2type = N'COLUMN',
    @level2name = N'DateAdd'
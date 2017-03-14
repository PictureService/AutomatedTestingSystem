CREATE TABLE [Tests].[Answer]
(
	[Id]			INT				NOT NULL, 
    [QuestionId]	INT				NOT NULL, 
    [Text]			NVARCHAR(100)	NOT NULL, 
    [IsTrue]		BIT				NOT NULL,
	CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Answer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [Tests].[Question]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Возможный ответ на вопрос к тесту',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Answer',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор ответа',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Answer',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор вопроса, к которому принадлежит ответ',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Answer',
    @level2type = N'COLUMN',
    @level2name = N'QuestionId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Текст ответа',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Answer',
    @level2type = N'COLUMN',
    @level2name = N'Text'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Является ли ответ правильным',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'Answer',
    @level2type = N'COLUMN',
    @level2name = N'IsTrue'
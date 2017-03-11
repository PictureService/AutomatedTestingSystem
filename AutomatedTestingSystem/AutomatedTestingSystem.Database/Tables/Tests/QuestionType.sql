CREATE TABLE [Tests].[QuestionType]
(
	[Id]		INT				NOT NULL, 
    [Name]		NVARCHAR(50)	NOT NULL,
	CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Название типа вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'QuestionType',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор типа вопроса',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'QuestionType',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Тип вопроса, который добавляется к тесту. Например "вопрос с выбором варианта ответа", "вопрос с вводом ответа", "несколько правильных ответов".',
    @level0type = N'SCHEMA',
    @level0name = N'Tests',
    @level1type = N'TABLE',
    @level1name = N'QuestionType',
    @level2type = NULL,
    @level2name = NULL
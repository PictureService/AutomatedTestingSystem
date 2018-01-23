INSERT INTO [Users].[GroupType] ([Id], [Name]) VALUES (1, N'Администраторы')
INSERT INTO [Users].[GroupType] ([Id], [Name]) VALUES (2, N'Преподаватели')
INSERT INTO [Users].[GroupType] ([Id], [Name]) VALUES (3, N'Студенты')

SET IDENTITY_INSERT [Users].[Group] ON
INSERT INTO [Users].[Group] ([Id], [Name], [GroupTypeId]) VALUES (1, N'Администраторы', 1)
INSERT INTO [Users].[Group] ([Id], [Name], [GroupTypeId]) VALUES (2, N'Преподаватели кафедры АИС', 2)
INSERT INTO [Users].[Group] ([Id], [Name], [GroupTypeId]) VALUES (3, N'Преподаватели кафедры ПОАС', 2)
INSERT INTO [Users].[Group] ([Id], [Name], [GroupTypeId]) VALUES (4, N'Студенты кафедры ПОАС', 3)
INSERT INTO [Users].[Group] ([Id], [Name], [GroupTypeId]) VALUES (5, N'Студенты кафедры АИС', 3)
SET IDENTITY_INSERT [Users].[Group] OFF

INSERT INTO [Users].[UserType] ([Id], [Name]) VALUES (1, N'Администратор')
INSERT INTO [Users].[UserType] ([Id], [Name]) VALUES (2, N'Преподаватель')
INSERT INTO [Users].[UserType] ([Id], [Name]) VALUES (3, N'Студент')

SET IDENTITY_INSERT [Users].[User] ON
INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (1, 1, 1, N'admin', N'admin', N'Федоров', N'Иван', N'Петрович')

INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (3, 2, 2, N'teacher1@test.ru', N'teacher1', N'Иванов', N'Геннадий', N'Константинович')
INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (6, 2, 3, N'teacher2@test.ru', N'teacher2', N'Смирнова', N'Наталья', N'Максимовна')
INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (7, 2, 2, N'teacher3@test.ru', N'teacher3', N'Самойлов', N'Кирилл', N'Геннадьевич')

INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (8, 3, 4, N'student1@test.ru', N'student1', N'Керимов', N'Григорий', N'Артурович')
INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (9, 3, 4, N'student2@test.ru', N'student2', N'Шабалин', N'Иосиф', N'Виссарионович')
INSERT INTO [Users].[User] ([Id], [UserTypeId], [GroupId], [Login], [Password], [Name], [Surname], [Patronymic]) VALUES (10, 3, 5, N'student3@test.ru', N'student3', N'Гедин', N'Касим', N'Нардинович')
SET IDENTITY_INSERT [Users].[User] OFF

INSERT INTO [Tests].[TestType] ([Id], [Name]) VALUES (1, N'Зачет')
INSERT INTO [Tests].[TestType] ([Id], [Name]) VALUES (2, N'Экзамен')

INSERT INTO [Tests].[QuestionType] ([Id], [Name]) VALUES (1, N'Вопрос с выбором варианта ответа')
INSERT INTO [Tests].[QuestionType] ([Id], [Name]) VALUES (2, N'Вопрос с вводом ответа')
INSERT INTO [Tests].[QuestionType] ([Id], [Name]) VALUES (3, N'Вопрос с выбором нескольких вариантов ответа')

SET IDENTITY_INSERT [Tests].[ControlWork] ON
INSERT INTO [Tests].[ControlWork] ([Id], [AuthorUserId], [Name], [Description], [TestTypeId]) VALUES (3, 3, N'Зачет', NULL, 1)
INSERT INTO [Tests].[ControlWork] ([Id], [AuthorUserId], [Name], [Description], [TestTypeId]) VALUES (4, 3, N'Экзамен', NULL, 2)
INSERT INTO [Tests].[ControlWork] ([Id], [AuthorUserId], [Name], [Description], [TestTypeId]) VALUES (5, 6, N'Зачет', NULL, 1)
INSERT INTO [Tests].[ControlWork] ([Id], [AuthorUserId], [Name], [Description], [TestTypeId]) VALUES (6, 7, N'Экзамен', NULL, 2)
SET IDENTITY_INSERT [Tests].[ControlWork] OFF

SET IDENTITY_INSERT [Tests].[ControlWorkResult] ON
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (1, 3, 8, 70)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (2, 3, 9, 50)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (3, 3, 10, 20)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (4, 4, 8, 90)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (5, 4, 10, 100)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (6, 5, 9, 50)
INSERT INTO [Tests].[ControlWorkResult] ([Id], [ControlWorkId], [UserId], [CountTrueAnswers]) VALUES (7, 6, 9, 60)
SET IDENTITY_INSERT [Tests].[ControlWorkResult] OFF

SET IDENTITY_INSERT [Tests].[Question] ON
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (2, N'Сколько планет в солнечной системе?', 3, 3, N'2017-01-23 00:00:00')
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (3, N'Как называется звезда солнечной системы?', 3, 2, N'2017-01-23 00:00:00')
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (4, N'Как называется наша планета?', 3, 1, N'2017-01-23 00:00:00')
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (5, N'Профессия преподавателя?', 4, 2, N'2017-01-23 00:00:00')
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (6, N'Вам нужен зачет?', 5, 2, N'2017-01-23 00:00:00')
INSERT INTO [Tests].[Question] ([Id], [Text], [ControlWorkId], [QuestionTypeId], [DateAdd]) VALUES (7, N'Как называется предмет?', 6, 2, N'2017-01-23 00:00:00')
SET IDENTITY_INSERT [Tests].[Question] OFF

SET IDENTITY_INSERT [Tests].[Answer] ON
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (1, 2, N'7', 0)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (3, 2, N'8', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (4, 2, N'9', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (5, 2, N'10', 0)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (6, 3, N'Солнце', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (7, 4, N'Солнце', 0)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (8, 4, N'Меркурий', 0)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (9, 4, N'Марс', 0)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (10, 4, N'Земля', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (11, 5, N'Преподаватель', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (12, 6, N'Да', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (13, 7, N'Базы данных', 1)
INSERT INTO [Tests].[Answer] ([Id], [QuestionId], [Text], [IsTrue]) VALUES (14, 7, N'БД', 1)
SET IDENTITY_INSERT [Tests].[Answer] OFF

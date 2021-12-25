SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (1, N'Гусев А. Р.', N'Стол Ron', 7600, N'Пушкинская 134, 27', N'89123456789', N'Accepted')
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (2, N'Максимов М. Д.', N'Кресло Ессей', 22000, N'Ленина 16, 229', N'89234567891', N'Completed')
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (3, N'Максимов М. Д.', N'Кресло Ладога 2', 10800, N'Ленина 16, 229', N'89234567891', N'In queue')
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (4, N'Щербакова В. Г.', N'Кресло Балатон', 19000, N'Молодёжная 4,12', N'89345678912', N'In queue')
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (5, N'Киселева В. И.', N'Комфортный диван книжка Антонио-4', 15400, N'Союзная 24, 13', N'89567891234', N'In queue')
INSERT INTO [dbo].[Orders] ([ID], [BuyerName], [ProductName], [Price], [Address], [PhoneNumber], [Status]) VALUES (6, N'Дубинина М. К.', N'Тахта Релакс-1', 11500, N'Автозаводская 4, 13', N'89789123456', N'In queue')
SET IDENTITY_INSERT [dbo].[Orders] OFF

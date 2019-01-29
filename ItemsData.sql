SET IDENTITY_INSERT [dbo].[Items] ON 
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (1, N'Chicken Tenders', CAST(3.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (2, N'Chicken Tenders w/ Fries', CAST(4.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (3, N'Chicken Tenders w/ Onion', CAST(5.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (4, N'Grilled Cheese Sandwich', CAST(2.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (5, N'Grilled Cheese Sandwich w/ Fries', CAST(3.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (6, N'Grilled Cheese Sandwich w/ Onion', CAST(4.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (7, N'Lettuce and Tomato Burger', CAST(1.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (8, N'Soup', CAST(2.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (9, N'Onion Rings', CAST(2.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (10, N'Fries', CAST(1.99 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (11, N'Sweet Potato Fries', CAST(2.49 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (12, N'Sweet Tea', CAST(1.79 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (13, N'Botttle Water', CAST(1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Items] ([ItemID], [Name], [Price]) VALUES (14, N'Canned Drinks', CAST(1.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
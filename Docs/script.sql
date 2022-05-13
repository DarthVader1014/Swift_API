USE [Swift001]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Firstname], [Lastname], [Username], [Password]) VALUES (1, N'Nkosana', N'Mncube', N'nkosana982@gmail.com', N'123abc456')
INSERT [dbo].[Customers] ([Id], [Firstname], [Lastname], [Username], [Password]) VALUES (2, N'Jay', N'Mallmen', N'jaymallmen@gmail.com', N'rdutffuh')
INSERT [dbo].[Customers] ([Id], [Firstname], [Lastname], [Username], [Password]) VALUES (1002, N'fggfd', N'fgsfgjfgjfg', N'gjfdgjfgfgfg', N'fhsdrhgfd')
INSERT [dbo].[Customers] ([Id], [Firstname], [Lastname], [Username], [Password]) VALUES (1003, N'James', N'Bond', N'james@gmail.com', N'123abc')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (1, N'Russell Hobbs Electronic Microwave Silver', CAST(2299.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/1/0/10115435_hfco_e880.jpg', N'This impressive Russell Hobbs 36L capacity electronic and grill microwave is a must-have for easy cooking! With 8 auto menus, grill and combination cooking and 5 power levels.')
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (2, N'Russell Hobbs 20L Flatbed Microwave Oven', CAST(1599.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/r/h/rhfbm20l_d458.jpg', N'Flatbed technology removes the need for a turntable, maximising the 20L internal space so that square plates and casserole dishes can be reheated or defrosted.')
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (3, N'Russell Hobbs 20lt Manual Microwave', CAST(1199.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/r/u/russell_hobbs_20lmanual_m_wave_43bf.jpg', N'The elegant Russell Hobbs Classic 20L Manual Microwave with Mirror Finish is the ideal cooking companion in the kitchen. Designed for ease of use, it features a manual control panel with a rotary timer.')
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (4, N'Samsung 28L Solo Electronic Microwave', CAST(2400.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/m/e/me6104st_8f24.jpg', N'Serve perfectly cooked fresh vegetables, pasta and more with ease in the ME6104ST1 Solo microwave.')
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (5, N'Samsung 32lt Solo Microwave Silver', CAST(1999.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/m/e/me0113m_54bc.jpg', N'A variety of fresh and healthy meals are at your fingertips with 9 pre-set cook modes on Samsung''s Mirror Grill.')
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [Image], [Description]) VALUES (8, N'Samsung 40L Electronic Microwave Silver ', CAST(1540.00 AS Decimal(10, 2)), 1, N'https://www.everyshop.co.za/media/catalog/product/cache/ea1c1d49663f18175f3f3520f39859aa/m/e/me9144st_9937.jpg', N'At Samsung, we pride ourselves on improving every product we make with innovative technologies. Our Triple Distribution System.')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO

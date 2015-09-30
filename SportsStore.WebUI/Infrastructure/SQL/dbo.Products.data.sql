SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES 
(1, 'Kayak', 'A boat for one person', 'Watersports', 275.00),
(2, 'Lifejacket', 'Protective and fashionable', 'Watersports', 48.95),
(3, 'Soccer Ball', 'FIFA-approved size and weight', 'Soccer', 19.50),
(4, 'Corner Flags', 'Give your playing field a professional touch', 'Soccer', 34.95),
(5, 'Stadium', 'Flat-packed 35,000-seat stadium', 'Soccer', 79500.00),
(6, 'Thinking Cap', 'Improve your brain efficiency by 75%', 'Chess', 16.00),
(7, 'Unsteady Chair', 'Secretly give your opponent a disadvantage', 'Chess', 29.95),
(8, 'Human Chess Board', 'A fun game for the family', 'Chess', 75.00),
(9, 'Bling-Bling King', 'Gold-plated, diamond-studded King', 'Chess', 1200.00)
SET IDENTITY_INSERT [dbo].[Products] OFF

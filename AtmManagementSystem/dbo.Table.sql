CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Date] DATE NULL, 
    [Purpose] VARCHAR(50) NULL, 
    [Amount] INT NULL, 
    [Username] VARCHAR(50)
	FOREIGN KEY ([Username]) REFERENCES [dbo].[Accounts.tb] ([Username])

)

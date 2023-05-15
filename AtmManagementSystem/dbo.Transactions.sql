CREATE TABLE [dbo].[Transactions] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Date]     DATE         NULL,
    [Name]     VARCHAR (50) NULL,
    [Amount]   INT          NULL,
    [Username] VARCHAR (50) NULL,
    [Type] VARCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Username]) REFERENCES [dbo].[Accounts.tb] ([Username])
);


CREATE TABLE [dbo].[Cards] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NULL,
    [CardNumber] VARCHAR (16) NULL,
    [Expiry]     DATE         NULL,
    [CVV]        INT          NULL,
    [Balance]    INT          NULL default 0,
    [Username]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Username]) REFERENCES [dbo].[Accounts.tb] ([Username])
);


CREATE TABLE [dbo].[Accounts.tb] (
    [Id]         VARCHAR (50)  NOT NULL,
    [Name]       VARCHAR (25)  NULL,
    [FName]      VARCHAR (30)  NULL,
    [Address]    VARCHAR (150) NULL,
    [Phone]      VARCHAR (18)  NULL,
    [Username]   VARCHAR (50)  NULL,
    [Password]   VARCHAR (50)  NULL,
    [Occupation] VARCHAR (20)  NULL,
    [Balance] INT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);


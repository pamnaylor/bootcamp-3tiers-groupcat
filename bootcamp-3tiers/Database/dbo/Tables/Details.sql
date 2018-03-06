CREATE TABLE [dbo].[Details] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (100) NULL,
    [LastName]    VARCHAR (100) NULL,
    [Age]         INT           NULL,
    [Nationality] VARCHAR (100) NULL,
    CONSTRAINT [PK_Details] PRIMARY KEY CLUSTERED ([Id] ASC)
);


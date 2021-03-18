CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [RegisteredOn] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


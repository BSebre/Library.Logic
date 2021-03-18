CREATE TABLE [dbo].[Articles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [TopicId] INT NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Text] NVARCHAR(2000) NOT NULL, 
    [PublishedOn] DATETIME NOT NULL, 
    [Image] NVARCHAR(50) NOT NULL, 
    [Author] NVARCHAR(50) NOT NULL
)

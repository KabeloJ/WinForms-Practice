CREATE TABLE [dbo].[Requests]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Body] VARCHAR(MAX) NULL, 
    [URL] VARCHAR(500) NULL, 
    [Method] INT NOT NULL, 
    [Response] NVARCHAR(MAX) NULL, 
    [FolderId] INT NULL, 
    [ModifiedDate] DATETIME NOT NULL
)

CREATE TABLE [dbo].[Folders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] VARCHAR(50) NOT NULL, 
    [FolderId] INT NULL
)

﻿CREATE TABLE [dbo].[RequestItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [RequestId] VARCHAR(50) NOT NULL, 
    [ItemType] VARCHAR(50) NOT NULL, 
    [Key] VARCHAR(2000) NULL, 
    [Value] VARCHAR(5000) NULL
)

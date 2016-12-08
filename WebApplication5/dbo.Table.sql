CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Img] IMAGE NULL, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(1500) NULL, 
    [Country] VARCHAR(50) NULL, 
    [Hotel] VARCHAR(1000) NULL, 
    [Prise] MONEY NULL
)

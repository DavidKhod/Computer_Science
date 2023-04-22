CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Class] NVARCHAR(20) NOT NULL, 
    [city] NVARCHAR(50) NOT NULL, 
    [avgGrade] FLOAT NOT NULL, 
    [email] NVARCHAR(100) NOT NULL, 
    [gender] NVARCHAR(10) NOT NULL
)

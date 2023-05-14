CREATE TABLE [dbo].[UserTb]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(500, 1), 
    [Username] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [Phone] NCHAR(10) NOT NULL, 
    [Password] NCHAR(50) NOT NULL 
)


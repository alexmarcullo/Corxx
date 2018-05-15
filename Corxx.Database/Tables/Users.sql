CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(60) NOT NULL, 
    [LastName] VARCHAR(60) NOT NULL, 
    [Email] VARCHAR(200) NOT NULL, 
    [DateTimeInserted] DATETIME NOT NULL, 
    CONSTRAINT [CK_Users_Email] UNIQUE (Email) 
)

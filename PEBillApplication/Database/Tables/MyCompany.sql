CREATE TABLE [dbo].[MyCompany]
(
	[Id] INT NOT NULL, 
    [Name] NCHAR(255) NOT NULL, 
    [Code] NCHAR(50) NOT NULL, 
    [Address] NCHAR(255) NOT NULL
    CONSTRAINT PK_MyCompany_Id primary key (Id)
);

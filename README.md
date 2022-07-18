# PEBillApplication 🧾
![Image text](https://github.com/GTeasera/FopBillApplication/blob/main/logo.png)

First of all, short story tell. In my IT Academy, I took a task to make an desctop application in WPF. After that a went to my close friends and parents and asked 
them for idea. One of them gave me an idea to make application for FOP to generate bills using DataBase, i think, it will be a SQL Server.
<br> So, it this repository, you can check my work and result of my work!

> If you want to use this, you should download <a href="https://www.microsoft.com/en-US/download/details.aspx?id=101064">SQL Server Express</a>
```TSQL
CREATE TABLE [dbo].[MyCompany]
(
	[Id] INT NOT NULL, 
    [Name] NCHAR(255) NOT NULL, 
    [Code] NCHAR(50) NOT NULL, 
    [Address] NCHAR(255) NOT NULL
    CONSTRAINT PK_MyCompany_Id primary key (Id)
);
```

## New Design:
![Image text](https://github.com/GTeasera/FopBillApplication/blob/main/new%20design.png)

## Old Design:
![Image text](https://github.com/GTeasera/PEBillApplication/blob/main/preview.png)

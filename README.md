# PEBillApplication 🧾
Let me start with a short story. At my IT academy, I got an assignment to make a desktop application in WPF. After that I went to my close friends and parents and asked them for an idea. One of them gave me the idea to make an application for individual entrepreneurs to generate invoices using a database, I think it will be SQL Server.
<br> So, in this repository, you can check my work and result of my work!

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

![Image text](https://github.com/GTeasera/PEBillApplication/blob/main/preview.png)

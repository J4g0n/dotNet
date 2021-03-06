USE [Northwind]
GO
/****** Object:  Trigger [dbo].[logInsertActionOnEmployee]    Script Date: 10/06/2015 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[logInsertActionOnEmployee]
   ON  [Northwind].[dbo].[Employees] 
   AFTER INSERT, UPDATE, DELETE
AS 
	insert into Northwind.dbo.EmpHistorique (
		dateOperation,
		typeOperation,
		employeId
	) values (
		GETDATE(),
		'INSERT',
		(select EmployeeID from inserted)
	);

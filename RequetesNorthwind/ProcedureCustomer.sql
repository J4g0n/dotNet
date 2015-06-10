-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SalesRevenueByCustomer
	@CustomerID varchar(5),
	@Sales int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select @Sales = Sum(od.UnitPrice * od.Quantity) 
	from Customers as c
	join Orders as o
	on c.CustomerID = o.CustomerID
	join [Order Details] as od
	on od.OrderID = o.OrderID
	where c.CustomerID like @CustomerID
	group by c.CustomerID;
END
GO

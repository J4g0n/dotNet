USE [Northwind]
GO

DECLARE	@return_value int,
		@Sales int

EXEC	@return_value = [dbo].[SalesRevenueByCustomer]
		@CustomerID = 'VINET',
		@Sales = @Sales OUTPUT

SELECT	@Sales as N'@Sales'

SELECT	'Return Value' = @return_value

GO

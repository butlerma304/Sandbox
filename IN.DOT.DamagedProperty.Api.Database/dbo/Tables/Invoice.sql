CREATE TABLE [dbo].[Invoice]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[InvoiceID] INT NULL, 
	[CustomerName] NVARCHAR(50) NULL, 
	[InvoiceNumber] NVARCHAR(50) NULL, 
	[InvoiceTypeID] INT NULL
)

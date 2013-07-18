﻿CREATE TABLE [dbo].[Invoice]
(
	[ID] UNIQUEIDENTIFIER NOT NULL, 
	[InvoiceID] INT  IDENTITY (1, 1) NOT NULL, 
	[CustomerName] NVARCHAR(256) NULL, 
	[InvoiceNumber] NVARCHAR(256) NULL, 
	[InvoiceTypeID] INT NULL
	CONSTRAINT [PK_Invoice] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)  
GO

ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [DF_Invoice_ID] DEFAULT (NEWID()) for [ID]
 GO
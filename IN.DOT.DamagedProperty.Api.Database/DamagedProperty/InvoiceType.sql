﻿CREATE TABLE [dbo].[InvoiceType]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[InvoiceTypeID] INT NOT NULL, 
	[Description] NVARCHAR(50) NOT NULL
	CONSTRAINT [PK_InvoiceType] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InvoiceType] ADD CONSTRAINT [DF_InvoiceType_ID] DEFAULT (NEWID()) for [ID]
 GO
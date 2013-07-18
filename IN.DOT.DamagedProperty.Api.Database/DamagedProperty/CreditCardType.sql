CREATE TABLE [dbo].[CreditCardType]
(
	[ID] UNIQUEIDENTIFIER NOT NULL DEFAULT (NEWSEQUENTIALID()) PRIMARY KEY, 
	[CreditCardTypeID] INT NULL, 
	[Description] NVARCHAR(50) NULL
)
GO

ALTER TABLE [dbo].[CreditCardType] ADD CONSTRAINT [PK_CreditCardType] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
	  ON [PRIMARY]
GO
 
 ALTER TABLE [dbo].[CreditCardType] ADD CONSTRAINT [DF_CreditCardType_ID] DEFAULT (NEWID()) for [ID]
 GO


INSERT [dbo].[CreditCardType] ([CreditCardTypeID],[Description]) VALUES (1,N'Visa')
INSERT [dbo].[CreditCardType] ([CreditCardTypeID],[Description]) VALUES (1,N'MasterCard')
INSERT [dbo].[CreditCardType] ([CreditCardTypeID],[Description]) VALUES (1,N'Discover')
INSERT [dbo].[CreditCardType] ([CreditCardTypeID],[Description]) VALUES (1,N'American Express')



GO
CREATE TABLE [dbo].[CreditCard]
(
	[ID] UNIQUEIDENTIFIER NOT NULL , 
	[UserID]  UNIQUEIDENTIFIER NOT NULL,
	[CreditCardTypeID]  UNIQUEIDENTIFIER NOT NULL,
	[CardNumber] NVARCHAR(50) NOT NULL, 
	[ExpirationDate] DATETIME NOT NULL, 
	[CVV] INT NOT NULL
	CONSTRAINT [PK_CreditCard] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CreditCard] ADD CONSTRAINT [DF_CreditCard_ID] DEFAULT (NEWID()) for [ID]
 GO


 
 ALTER TABLE [dbo].[CreditCard]	WITH CHECK ADD CONSTRAINT [FK_CreditCard_CreditCardType] FOREIGN KEY ([CreditCardTypeID])
 REFERENCES [dbo].[CreditCardType] ([ID])
 ON DELETE CASCADE
 GO
 
 ALTER TABLE [dbo].[CreditCard]	WITH CHECK ADD CONSTRAINT [FK_CreditCard_User] FOREIGN KEY ([UserID])
 REFERENCES [dbo].[User] ([ID])
 ON DELETE CASCADE
 GO


 
 

 
INSERT [dbo].[CreditCard] ([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'792401ba-ee26-4f6d-a025-0473f2d2da51',N'39eb079a-53e7-4ec7-bbf8-ca61dbc64186',N'4567-2323-2345-4673',N'11/2015',723)
INSERT [dbo].[CreditCard] ([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'2ef4a763-a72d-4268-9df8-f5328f497175',N'39eb079a-53e7-4ec7-bbf8-ca61dbc64186',N'4321-4367-3753-4564',N'3/2014',907)
INSERT [dbo].[CreditCard] ([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'b2d565c1-4d45-4ecc-89a6-2a2f206eb206',N'880eb1ad-15f2-4815-8609-3941b600edc3',N'5010-0723-1234-4563',N'5/2014',823)
INSERT [dbo].[CreditCard]([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'b05bd787-7d44-4581-a141-c893efee7601',N'26cc465d-e521-480c-b6bd-6755ee21ab2e',N'6009-2103-2323-5642',N'3/2014',213)
INSERT [dbo].[CreditCard]([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'0d21cfdc-d657-4c1a-bce1-56f2a6f4f6f2',N'880eb1ad-15f2-4815-8609-3941b600edc3',N'5010-0722-3331-2121',N'5/2014',323)
INSERT [dbo].[CreditCard] ([UserID],[CreditCardTypeID],[CardNumber] ,[ExpirationDate],[CVV]) VALUES (N'ea46bee1-c39c-4418-b599-7d1c1f9e2f40',N'262071df-5a57-496d-9c71-25d2fbc57dde',N'3723-234-2343-8921',N'6/2014',898)
 

CREATE TABLE [dbo].[BillingInfo]
(
	[ID] UNIQUEIDENTIFIER NOT NULL  , 
	[UserID] UNIQUEIDENTIFIER NOT NULL, 
	[AddressID]UNIQUEIDENTIFIER NOT NULL, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[MiddleNme] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[Email] NVARCHAR(50) NOT NULL, 
	[PhoneNumber] NVARCHAR(50) NOT NULL, 
	[DisplayName] NVARCHAR(50) NOT NULL, 
	[IsActive] BIT NULL, 
	[CreateBy] NVARCHAR(50) NULL, 
	[CreateDate] DATETIME NULL, 
	[LastModifiedBy] NVARCHAR(16) NULL, 
	[LastModifiedDate] DATETIME NULL 
	CONSTRAINT [PK_BillingInfo] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
 ALTER TABLE [dbo].[BillingInfo] ADD CONSTRAINT [DF_BillingInfo_ID] DEFAULT (NEWID()) for [ID]
 GO
 ALTER TABLE [dbo].[BillingInfo] ADD CONSTRAINT [DF_BillingInfo_CreateDate] DEFAULT (GETDATE()) for [CreateDate]
 GO
 ALTER TABLE [dbo].[BillingInfo] ADD CONSTRAINT [DF_BillingInfo_LastModifiedDate] DEFAULT (GETDATE()) for [LastModifiedDate]
 GO

 
 ALTER TABLE [dbo].[BillingInfo]	WITH CHECK ADD CONSTRAINT [FK_BillingInfo_user] FOREIGN KEY ([UserID])
 REFERENCES [dbo].[User] ([ID])
 ON DELETE CASCADE
 GO


INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'792401ba-ee26-4f6d-a025-0473f2d2da51',N'21b610f3-5055-4e52-a7d6-ce89299e3e81',N'Jane',N'Michelle',N'Doe',N'Doe.Jane@giggle.com',N'1-212-312-4548',N'Jane M. Doe',0,N'Admin',cURRENT_TIMESTAMP,N'Jane Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'2ef4a763-a72d-4268-9df8-f5328f497175',N'07516143-8ea8-4a96-9137-4fec77267ca0',N'Sam',N'Jason',N'Ranger',N'Ranger.Sam@giggle.com',N'1-317-534-4538',N'Sam Ranger',0,N'Admin',cURRENT_TIMESTAMP,N'Same Ranger',CURRENT_TIMESTAMP)
INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'b2d565c1-4d45-4ecc-89a6-2a2f206eb206',N'25971d1b-2443-4c96-9d8e-84b765c7c7ce',N'Sonic',N'P.',N'Hedge',N'Hedge.Sonice@wiggle.com',N'1-317-333-4578',N'Sonic Hedge',1,N'Admin',cURRENT_TIMESTAMP,N'Sonic Hedge',CURRENT_TIMESTAMP)
INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'b05bd787-7d44-4581-a141-c893efee7601',N'bdbe1a9d-bfa8-4688-b87b-23efa403a73a',N'Ralph',N'R.',N'Doe', N'Doe.Ralph@giggle.com',N'1-317-907-4588',N'Ralph Doe',0,N'Admin',cURRENT_TIMESTAMP,N'Ralph Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'0d21cfdc-d657-4c1a-bce1-56f2a6f4f6f2',N'767ce0b0-a90b-462e-8ee4-d7c5b6c902dd',N'Bob',N'Z.',N'James',N'Bob.James@gmail.com',N'1-212-706-5788',N'Bob Z. James',1,N'Admin',cURRENT_TIMESTAMP,N'Bob James',CURRENT_TIMESTAMP)
INSERT [dbo].[BillingInfo] ([UserID],[AddressID],[FirstName],[MiddleNme],[LastName],[Email],[PhoneNumber],[DisplayName],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'ea46bee1-c39c-4418-b599-7d1c1f9e2f40',N'8389e2a8-2ea7-4418-a5dd-490518374c59',N'Shaoron',N'',N'Mills',N'Sharon.Mills@giggle.com',N'1-603-555-8567',N'Sharron Mills',1,N'Admin',cURRENT_TIMESTAMP,N'Shararon Mills',CURRENT_TIMESTAMP)


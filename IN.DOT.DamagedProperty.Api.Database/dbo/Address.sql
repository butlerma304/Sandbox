CREATE TABLE [dbo].[Address]
(
	[ID] UNIQUEIDENTIFIER NOT NULL  ,
	[UserID]  UNIQUEIDENTIFIER NOT NULL,
	[AddressLine1] NVARCHAR(50) NULL, 
	[AddressLine2] NVARCHAR(50) NULL, 
	[City] NVARCHAR(50) NULL, 
	[StateProvidenceID] INT NULL, 
	[ZipCode] NCHAR(10) NULL, 
	[CreateBy] NVARCHAR(50) NULL, 
	[CreateDate] DATETIME NULL, 
	[LastModifiedBy] NVARCHAR(16) NULL, 
	[LastModifiedDate] DATETIME NULL
	CONSTRAINT [PK_Address] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	 WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) 
GO
 
 
 ALTER TABLE [dbo].[Address] ADD CONSTRAINT [DF_Address_ID] DEFAULT (NEWID()) for [ID]
 GO

 ALTER TABLE [dbo].[Address] ADD CONSTRAINT [DF_Address_CreateDate] DEFAULT (GETDATE()) for [CreateDate]
 GO
 ALTER TABLE [dbo].[Address] ADD CONSTRAINT [DF_Address_LastModifiedDate] DEFAULT (GETDATE()) for [LastModifiedDate]
 GO

 ALTER TABLE [dbo].[Address]	WITH CHECK ADD CONSTRAINT [FK_Address_User] FOREIGN KEY ([UserID])
 REFERENCES [dbo].[User] ([ID])
 ON DELETE CASCADE
 GO


 
 

 
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'792401ba-ee26-4f6d-a025-0473f2d2da51',N'2345 Oleny',N'Apt 3',N'Indianapolis',3,N'46217',N'Admin',cURRENT_TIMESTAMP,N'Jane Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'2ef4a763-a72d-4268-9df8-f5328f497175',N'4509 Paine Ave',N'',N'Indianapolis',3,N'46211',N'Admin',cURRENT_TIMESTAMP,N'Same Ranger',CURRENT_TIMESTAMP)
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'b2d565c1-4d45-4ecc-89a6-2a2f206eb206',N'9201 Texas',N'Ste. 4',N'Fishers',3,N'46218',N'Admin',cURRENT_TIMESTAMP,N'Sonic Hedge',CURRENT_TIMESTAMP)
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'b05bd787-7d44-4581-a141-c893efee7601',N'4578 Grace',N'Ste 45',N'Indianapolis',3,N'46254',N'Admin',cURRENT_TIMESTAMP,N'Ralph Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'0d21cfdc-d657-4c1a-bce1-56f2a6f4f6f2',N'931 Meridian',N'',N'Lafeyette ',3,N'46216',N'Admin',cURRENT_TIMESTAMP,N'Bob James',CURRENT_TIMESTAMP)
INSERT [dbo].[Address] ([UserID],[AddressLine1],[AddressLine2],[City],[StateProvidenceID],[ZipCode],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'ea46bee1-c39c-4418-b599-7d1c1f9e2f40',N'8181 Indianola',N'',N'Indianapolis',3,N'462187',N'Admin',cURRENT_TIMESTAMP,N'Shararon Mills',CURRENT_TIMESTAMP)
 

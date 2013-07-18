CREATE TABLE [dbo].[User] (
	[ID] UNIQUEIDENTIFIER NOT NULL , 
	[Username]             NVARCHAR (256)   NOT NULL,
	[Email]                NVARCHAR (256)   NOT NULL,
	[HasTemporaryPassword] BIT              NOT NULL, 
	[Password] NVARCHAR(50) NOT NULL, 
	[PasswordHash] NVARCHAR(MAX)  NULL, 
	[IsActive] BIT NOT NULL, 
	[CreateBy] NVARCHAR(50) NULL, 
	[CreateDate] DATETIME NULL, 
	[LastModifiedBy] NVARCHAR(16) NULL, 
	[LastModifiedDate] DATETIME NULL 
	CONSTRAINT [PK_User] PRIMARY KEY NONCLUSTERED
	([ID] ASC)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User] ADD CONSTRAINT [DF_User_ID] DEFAULT (NEWID()) for [ID]
 GO

ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_HasTemporaryPassword] DEFAULT 0 FOR [HasTemporaryPassword]
 GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsActive] DEFAULT 0 FOR [IsActive]

ALTER TABLE [dbo].[User] ADD CONSTRAINT [DF_User_CreateDate] DEFAULT (GETDATE()) for [CreateDate]
 GO
 ALTER TABLE [dbo].[User] ADD CONSTRAINT [DF_User_LastModifiedDate] DEFAULT (GETDATE()) for [LastModifiedDate]
 GO


 
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Jane Doe',N'Doe.Jane@giggle.com',0,N'Password',N'Xor84900',1,N'Admin',cURRENT_TIMESTAMP,N'Jane Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Sam Ranger Doe',N'Ranger.Sam@giggle.com',0,N'Password',N'Xo434900',1,N'Admin',cURRENT_TIMESTAMP,N'Same Ranger',CURRENT_TIMESTAMP)
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Sonic Hedge',N'Hedge.Sonice@wiggle.com',0,N'Password',N'Hkek:00',1,N'Admin',cURRENT_TIMESTAMP,N'Sonic Hedge',CURRENT_TIMESTAMP)
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Ralph Doe',N'Doe.Ralph@giggle.com',0,N'Password',N'9Qr45dfl',1,N'Admin',cURRENT_TIMESTAMP,N'Ralph Doe',CURRENT_TIMESTAMP)
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Bob James',N'Bob.James@gmail.com',0,N'Password',N'Powx&9s0',1,N'Admin',cURRENT_TIMESTAMP,N'Bob James',CURRENT_TIMESTAMP)
INSERT [dbo].[User] ([Username],[Email],[HasTemporaryPassword],[Password],[PasswordHash],[IsActive],[CreateBy],[CreateDate],[LastModifiedBy],[LastModifiedDate]) VALUES (N'Shaoron Mills',N'Sharon.Mills@giggle.com',0,N'Password',N'Xor32wd3900',1,N'Admin',cURRENT_TIMESTAMP,N'Shararon Mills',CURRENT_TIMESTAMP)


SET IDENTITY_INSERT [User] OFF





SET IDENTITY_INSERT [User] ON
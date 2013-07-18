CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId]        INT     NOT NULL,
	[RoleId]        INT     NOT NULL,
	CONSTRAINT [PK_webpages_UsersInRoles] 
		PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC)
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
	CONSTRAINT [FK_webpages_UsersInRoles_webpages_Roles] 
		FOREIGN KEY([RoleId])
		REFERENCES [dbo].[webpages_Roles] ([RoleId]),
	CONSTRAINT [FK_webpages_UsersInRoles_User] 
		FOREIGN KEY([UserId])
		REFERENCES [dbo].[User] ([Id])
		ON DELETE CASCADE
) ON [PRIMARY];
GO
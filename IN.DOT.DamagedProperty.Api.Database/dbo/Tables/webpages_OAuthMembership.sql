﻿CREATE TABLE [dbo].[webpages_OAuthMembership](
    [Provider]              NVARCHAR(30)    NOT NULL,
    [ProviderUserId]        NVARCHAR(100)   NOT NULL,
    [UserId]                INT             NOT NULL,
    CONSTRAINT [PK_webpages_OAuthMembership] 
        PRIMARY KEY CLUSTERED ([Provider] ASC, [ProviderUserId] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
    CONSTRAINT [FK_webpages_OAuthMembership_User] 
        FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
        ON DELETE CASCADE
) ON [PRIMARY];
GO
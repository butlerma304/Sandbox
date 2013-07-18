﻿CREATE TABLE [dbo].[webpages_Membership](
    [UserId]                                    INT             NOT NULL,
    [CreateDate]                                DATETIME        NULL,
    [ConfirmationToken]                         NVARCHAR(128)   NULL,
    [IsConfirmed]                               BIT             NULL
        CONSTRAINT [DF_webpages_Membership_IsConfirmed] DEFAULT 0,
    [LastPasswordFailureDate]                   DATETIME        NULL,
    [PasswordFailuresSinceLastSuccess]          INT             NOT NULL
        CONSTRAINT [DF_webpages_Membership_PasswordFailuresSinceLastSuccess] DEFAULT 0,
    [Password]                                  NVARCHAR(128)   NOT NULL,
    [PasswordChangedDate]                       DATETIME        NULL,
    [PasswordSalt]                              NVARCHAR(128)   NOT NULL,
    [PasswordVerificationToken]                 NVARCHAR(128)   NULL,
    [PasswordVerificationTokenExpirationDate]   DATETIME        NULL,
    CONSTRAINT [PK_webpages_Membership] 
        PRIMARY KEY CLUSTERED ([UserId] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
    CONSTRAINT [FK_webpages_Membership_User] 
        FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
        ON DELETE CASCADE
) ON [PRIMARY];
GO
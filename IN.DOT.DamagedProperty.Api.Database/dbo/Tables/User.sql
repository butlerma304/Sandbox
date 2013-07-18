﻿CREATE TABLE [dbo].[User] (
    [Id]                   INT              IDENTITY (1, 1) NOT NULL,
    [Username]             NVARCHAR (256)   NOT NULL,
    [Email]                NVARCHAR (256)   NOT NULL,
    [HasTemporaryPassword] BIT              NOT NULL 
        CONSTRAINT [DF_User_HasTemporaryPassword] DEFAULT 0, 
    CONSTRAINT [PK_User] 
        PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_User_Username] 
        UNIQUE NONCLUSTERED ([Username] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
GO
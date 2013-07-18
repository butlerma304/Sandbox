CREATE TABLE [dbo].[User] (
    [ID]                   INT              IDENTITY (1, 1) NOT NULL,
    [Username]             NVARCHAR (256)   NOT NULL,
    [Email]                NVARCHAR (256)   NOT NULL,
    [HasTemporaryPassword] BIT              NOT NULL 
        CONSTRAINT [DF_User_HasTemporaryPassword] DEFAULT 0, 
    [Password] NVARCHAR(50) NOT NULL, 
    [PasswordHash] NVARCHAR(MAX) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_User] 
        PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UQ_User_Username] 
        UNIQUE NONCLUSTERED ([Username] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
GO

ALTER TABLE [dbo].[User] ADD CONSTRAINT [DF_User_ID] DEFAULT (NEWID()) for [ID]
 GO
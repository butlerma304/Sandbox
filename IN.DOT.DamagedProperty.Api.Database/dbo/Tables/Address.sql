CREATE TABLE [dbo].[Address]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[UserID] INT NULL,
    [AddressID] INT NULL, 
    [AddressLine1] NCHAR(10) NULL, 
    [AddressLine2] NCHAR(10) NULL, 
    [City] NCHAR(10) NULL, 
    [StateProvidenceID] NCHAR(10) NULL, 
    [ZipCode] NCHAR(10) NULL, 
	[CreateBy] NVARCHAR(50) NULL, 
	[CreateDate] DATETIME NULL, 
	[LastModifiedBy] NVARCHAR(16) NULL, 
	[LastModifiedDate] DATETIME NULL
    
)

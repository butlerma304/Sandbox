CREATE TABLE [dbo].[BillingInfo]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[UserID] INT NULL, 
	[AddressID] INT NOT NULL, 
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
)

CREATE TABLE [dbo].[CreditCard]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [CreditCardID] NVARCHAR(50) NOT NULL, 
    [CardNumber] NVARCHAR(50) NOT NULL, 
    [UserID] INT NOT NULL, 
    [ExpirationDate] DATETIME NOT NULL, 
    [CVV] INT NULL
)

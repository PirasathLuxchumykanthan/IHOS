CREATE TABLE [dbo].[blazor.Connection]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [SecurityKey] UNIQUEIDENTIFIER NOT NULL, 
    [Expires] DATETIME NOT NULL, 
    [DeviceType] INT NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [TwoLetterISO639] NCHAR(2) NOT NULL, 
    [StockStatus] INT NOT NULL, 
    [TimeZone] NCHAR(8) NOT NULL
)

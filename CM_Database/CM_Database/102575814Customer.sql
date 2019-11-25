CREATE TABLE [dbo].[102575814Customer]
(
	[CustNo.] INT NOT NULL,
	[CustName] NVARCHAR(50) NOT NULL,
	[CustAddress] NVARCHAR(100) NOT NULL,
	[CustPcode] INT NOT NULL,
	[InterestCode] NVARCHAR(2) NOT NULL FOREIGN KEY REFERENCES [dbo].[102575814Interest],
	PRIMARY KEY ([CustNo.], [InterestCode])

)

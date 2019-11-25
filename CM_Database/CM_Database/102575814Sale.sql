CREATE TABLE [dbo].[102575814Sale]
(
	[DateRecorded] DATE NOT NULL,
	[Price] FLOAT NOT NULL,
	[CustNo.] INT NOT NULL,
	[RecordID] NVARCHAR(5) NOT NULL,
	[InterestCode] NVARCHAR(2) NOT NULL
	PRIMARY KEY ([DateRecorded], [CustNo.], [RecordID], [InterestCode]),
	FOREIGN KEY ([RecordID]) REFERENCES [dbo].[102575814Record],
	FOREIGN KEY ([CustNo.], [InterestCode]) REFERENCES [dbo].[102575814Customer]
)

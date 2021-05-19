CREATE TABLE [dbo].[FinePosts]
(
	[FinePostId] INT IDENTITY(1,1) NOT NULL,
	[FineId] INT NOT NULL,
	[FinerId] INT NOT NULL,
	[FineeId] INT NOT NULL

	PRIMARY KEY CLUSTERED ([FinePostId] ASC)
	FOREIGN KEY ([FineId]) REFERENCES Fines([FineId]),
	FOREIGN KEY ([FinerId]) REFERENCES Users(UserId),
	FOREIGN KEY ([FineeId]) REFERENCES Users(UserId)
)

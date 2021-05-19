CREATE TABLE [dbo].[Votes]
(
	[VoteId] INT IDENTITY(1,1) NOT NULL,
	[FinePostId] INT NOT NULL,
	[UserId] INT NOT NULL

	PRIMARY KEY CLUSTERED ([VoteId] ASC)
	FOREIGN KEY ([FinePostId]) REFERENCES FinePosts([FinePostId]),
	FOREIGN KEY ([UserId]) REFERENCES Users([UserId])
)

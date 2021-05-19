﻿CREATE TABLE [dbo].[Users]
(
	[UserId] INT IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR (255) NULL,
	[ProfileImage] VARCHAR (MAX) NULL,
	[Active] BIT
	PRIMARY KEY CLUSTERED ([UserId] ASC)
)

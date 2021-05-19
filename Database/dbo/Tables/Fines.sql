CREATE TABLE [dbo].[Fines] (
    [FineId]    INT           IDENTITY (1, 1) NOT NULL,
    [FineTitle] VARCHAR (255) NULL,
    [FineText]  VARCHAR (255) NULL,
    [Active] BIT,
    [DateCreated] DateTime
    PRIMARY KEY CLUSTERED ([FineId] ASC)
);


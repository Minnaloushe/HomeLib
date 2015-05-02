CREATE TABLE [dbo].[Categories] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [SystemName] NVARCHAR (255)   NULL,
    [Name]       NVARCHAR (255)   NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);


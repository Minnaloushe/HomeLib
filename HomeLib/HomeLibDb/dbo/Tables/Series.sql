﻿CREATE TABLE [dbo].[Series] (
    [Id]   UNIQUEIDENTIFIER NOT NULL,
    [Name] NVARCHAR (255)   NULL,
    CONSTRAINT [PK_Series] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Settings] (
    [Name]  NVARCHAR (255)  NOT NULL,
    [Value] NVARCHAR (4000) NOT NULL, 
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_Settings] PRIMARY KEY ([Id])
);


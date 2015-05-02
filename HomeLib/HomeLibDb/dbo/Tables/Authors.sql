CREATE TABLE [dbo].[Authors] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [FirstName]  NVARCHAR (255)   NULL,
    [MiddleName] NVARCHAR (255)   NULL,
    [LastName]   NVARCHAR (255)   NULL,
    CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Authors_FullName]
    ON [dbo].[Authors]([LastName] ASC, [FirstName] ASC, [MiddleName] ASC);


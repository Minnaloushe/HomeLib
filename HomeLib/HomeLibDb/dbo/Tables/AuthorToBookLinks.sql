CREATE TABLE [dbo].[AuthorToBookLinks] (
    [AuthorId] UNIQUEIDENTIFIER NOT NULL,
    [BookId]   UNIQUEIDENTIFIER NOT NULL,
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_AuthorToBookLinks] PRIMARY KEY NONCLUSTERED ([Id]),
    CONSTRAINT [FK_AuthorToBookLinks_Authors] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Authors] ([Id]),
    CONSTRAINT [FK_AuthorToBookLinks_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]) 
);


GO

CREATE UNIQUE CLUSTERED INDEX [IX_AuthorToBookLinks_Column] ON [dbo].[AuthorToBookLinks] ([BookId], [AuthorId]) 

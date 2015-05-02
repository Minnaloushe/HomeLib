CREATE TABLE [dbo].[BookCategoriesToBookLinks] (
    [CategoryId] UNIQUEIDENTIFIER NOT NULL,
    [BookId]     UNIQUEIDENTIFIER NOT NULL,
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_BookCategoriesToBookLinks] PRIMARY KEY NONCLUSTERED ([Id]),
    CONSTRAINT [FK_BookCategoriesToBookLinks_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_BookCategoriesToBookLinks_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);


GO

CREATE UNIQUE CLUSTERED INDEX [IX_BookCategoriesToBookLinks_BookId_CategoryId] ON [dbo].[BookCategoriesToBookLinks] ([BookId], [CategoryId])

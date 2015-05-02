CREATE TABLE [dbo].[BookCategoriesToBookLinks] (
    [CategoryId] UNIQUEIDENTIFIER NOT NULL,
    [BookId]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_BookCategoriesToBookLinks] PRIMARY KEY CLUSTERED ([CategoryId] ASC, [BookId] ASC),
    CONSTRAINT [FK_BookCategoriesToBookLinks_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_BookCategoriesToBookLinks_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);


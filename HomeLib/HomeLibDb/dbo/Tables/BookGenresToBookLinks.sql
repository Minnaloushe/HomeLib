CREATE TABLE [dbo].[BookGenresToBookLinks] (
    [GenreId] UNIQUEIDENTIFIER NOT NULL,
    [BookId]  UNIQUEIDENTIFIER NOT NULL,
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_BookGenresToBookLinks] PRIMARY KEY NONCLUSTERED ([Id]),
    CONSTRAINT [FK_BookGenresToBookLinks_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_BookGenresToBookLinks_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id])
);


GO

CREATE UNIQUE CLUSTERED INDEX [IX_BookGenresToBookLinks_GenreId_BookId] ON [dbo].[BookGenresToBookLinks] ([BookId], [GenreId])

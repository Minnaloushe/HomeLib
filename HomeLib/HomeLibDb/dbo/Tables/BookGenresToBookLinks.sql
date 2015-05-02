CREATE TABLE [dbo].[BookGenresToBookLinks] (
    [GenreId] UNIQUEIDENTIFIER NOT NULL,
    [BookId]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_BookGenresToBookLinks] PRIMARY KEY CLUSTERED ([GenreId] ASC, [BookId] ASC),
    CONSTRAINT [FK_BookGenresToBookLinks_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_BookGenresToBookLinks_Genres] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id])
);


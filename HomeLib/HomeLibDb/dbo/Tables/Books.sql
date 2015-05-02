CREATE TABLE [dbo].[Books] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [Title]         NVARCHAR (255)   NULL,
    [SerieIndex]    INT              NULL,
    [FileIndex]     BIGINT           NOT NULL,
    [ArchivedSize]  BIGINT           NOT NULL,
    [FileName]      NVARCHAR (255)   NULL,
    [Reserved8]     INT              NOT NULL,
    [Format]        NVARCHAR (255)   NULL,
    [Date]          DATETIME         NOT NULL,
    [Language]      NVARCHAR (255)   NULL,
    [Reserved12]    INT              NULL,
    [ArchiveFileId] UNIQUEIDENTIFIER NULL,
    [SerieId]       UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Books_ArchiveFiles] FOREIGN KEY ([ArchiveFileId]) REFERENCES [dbo].[ArchiveFiles] ([Id]),
    CONSTRAINT [FK_Books_Series] FOREIGN KEY ([SerieId]) REFERENCES [dbo].[Series] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Books_Title]
    ON [dbo].[Books]([Title] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Books_Format]
    ON [dbo].[Books]([Format] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Books_Language]
    ON [dbo].[Books]([Language] ASC);


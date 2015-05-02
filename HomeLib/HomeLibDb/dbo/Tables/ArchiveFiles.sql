CREATE TABLE [dbo].[ArchiveFiles] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [FileName] NVARCHAR (255)   NULL,
    [Size]     BIGINT           NOT NULL,
    CONSTRAINT [PK_ArchiveFiles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_ArchiveFiles_FileName]
    ON [dbo].[ArchiveFiles]([FileName] ASC);


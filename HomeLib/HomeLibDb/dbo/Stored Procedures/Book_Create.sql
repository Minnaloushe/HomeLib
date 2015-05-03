CREATE PROCEDURE [dbo].[Book_Create]
	@Id uniqueidentifier,
	@Title nvarchar(255),
	@SerieIndex int,
	@FileIndex bigint,
	@ArchivedSize bigint,
	@FileName nvarchar(255),
	@Reserved8 int,
	@Format nvarchar(255),
	@Date datetime,
	@Language nvarchar(255),
	@Reserved12 int,
	@ArchiveFileId uniqueidentifier,
	@SerieId uniqueidentifier
AS
	INSERT INTO [dbo].[Books] ([Id], [Title], [SerieIndex], [FileIndex], [ArchivedSize], [FileName], [Reserved8], [Format], [Date], [Language], [Reserved12], [ArchiveFileId], [SerieId])
	VALUES (@Id, @Title, @SerieIndex, @FileIndex, @ArchivedSize, @FileName, @Reserved8, @Format, @Date, @Language, @Reserved12, @ArchiveFileId, @SerieId)

RETURN 0
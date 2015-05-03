CREATE PROCEDURE [dbo].[Book_Update]
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
	UPDATE [dbo].[Books]
	SET [Title] = @Title, 
		[SerieIndex] = @SerieIndex, 
		[FileIndex] = @FileIndex, 
		[ArchivedSize] = @ArchivedSize, 
		[FileName] = @FileName, 
		[Reserved8] = @Reserved8, 
		[Format] = @Format, 
		[Date] = @Date, 
		[Language] = @Language, 
		[Reserved12] = @Reserved12, 
		[ArchiveFileId] = @ArchiveFileId, 
		[SerieId] = @SerieId
	WHERE [Id] = @Id;

	SELECT @@ROWCOUNT
RETURN 0
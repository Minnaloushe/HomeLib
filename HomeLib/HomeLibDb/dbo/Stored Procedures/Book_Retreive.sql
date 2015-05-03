CREATE PROCEDURE [dbo].[Book_Retreive]
	@Id uniqueidentifier
AS
	SELECT 
		[Id],
		[Title],
		[SerieIndex],
		[FileIndex],
		[ArchivedSize],
		[FileName],
		[Reserved8],
		[Format],
		[Date],
		[Language],
		[Reserved12],
		[ArchiveFileId],
		[SerieId]
	FROM [dbo].[Books]
	WHERE [id] = @Id
RETURN 0
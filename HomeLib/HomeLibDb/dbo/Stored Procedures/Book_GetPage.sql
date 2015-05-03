CREATE PROCEDURE [dbo].[Book_GetPage]
	@pageSize int,
	@skip int
AS

	SELECT [Id], [Title], [SerieIndex], [FileIndex], [ArchivedSize], [FileName], [Reserved8], [Format], [Date], [Language], [Reserved12], [ArchiveFileId], [SerieId]
	FROM [dbo].[Books]
	ORDER BY [Title]
	OFFSET @pageSize  * @skip ROWS
	FETCH NEXT @pageSize ROWS ONLY;
	
RETURN 0
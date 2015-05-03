CREATE PROCEDURE [dbo].[ArchiveFile_GetPage]
	@pageSize int,
	@skip int
AS

	SELECT [Id], [FileName], [Size]
	FROM [dbo].[ArchiveFiles]
	ORDER BY [FileName]
	OFFSET @pageSize  * @skip ROWS
	FETCH NEXT @pageSize ROWS ONLY;
	
RETURN 0
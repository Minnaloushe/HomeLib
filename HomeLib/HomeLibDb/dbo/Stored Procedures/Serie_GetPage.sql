
CREATE PROCEDURE [dbo].[Serie_GetPage]
	@pageSize int,
	@skip int
AS

	SELECT [Id], [Name]
	FROM [dbo].[Series]
	ORDER BY [Name]
	OFFSET @pageSize  * @skip ROWS
	FETCH NEXT @pageSize ROWS ONLY;
	
RETURN 0
CREATE PROCEDURE [dbo].[Author_GetPage]
	@pageSize int,
	@skip int
AS

	SELECT 
		[Id],
		[FirstName],
		[MiddleName],
		[LastName]
	FROM [dbo].[Authors]
	ORDER BY [LastName], [FirstName], [MiddleName]
	OFFSET @pageSize  * @skip ROWS
	FETCH NEXT @pageSize ROWS ONLY;
	
RETURN 0
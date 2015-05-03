CREATE PROCEDURE [dbo].[Author_Retreive]
	@Id uniqueidentifier
AS
	SELECT 
		[Id],
		[FirstName],
		[MiddleName],
		[LastName]
	FROM [dbo].[Authors]
	WHERE [id] = @Id
RETURN 0
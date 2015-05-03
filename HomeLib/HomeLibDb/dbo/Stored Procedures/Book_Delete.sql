CREATE PROCEDURE [dbo].[Book_Delete]
	@Id uniqueidentifier
AS
	DELETE
	FROM [dbo].[Books]
	WHERE [Id] = @Id;

	SELECT @@ROWCOUNT

RETURN 0
CREATE PROCEDURE [dbo].[Serie_Delete]
	@Id uniqueidentifier
AS
	DELETE
	FROM [dbo].[Series]
	WHERE [Id] = @Id;

	SELECT @@ROWCOUNT

RETURN 0
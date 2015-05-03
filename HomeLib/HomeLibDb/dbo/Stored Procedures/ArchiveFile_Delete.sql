CREATE PROCEDURE [dbo].[ArchiveFile_Delete]
	@Id uniqueidentifier
AS
	DELETE
	FROM [dbo].[ArchiveFiles]
	WHERE [Id] = @Id;

	SELECT @@ROWCOUNT

RETURN 0
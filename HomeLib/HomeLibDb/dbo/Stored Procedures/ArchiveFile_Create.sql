
CREATE PROCEDURE [dbo].[ArchiveFile_Create]
	@Id uniqueidentifier,
	@FileName nvarchar(255),
	@Size bigint
AS
	INSERT INTO [dbo].[ArchiveFiles] ([Id], [FileName], [Size])
	VALUES (@Id, @FileName, @Size)

RETURN 0
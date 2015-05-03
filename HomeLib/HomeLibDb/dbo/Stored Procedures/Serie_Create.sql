
CREATE PROCEDURE [dbo].[Serie_Create]
	@Id uniqueidentifier,
	@Name nvarchar(255)
AS
	INSERT INTO [dbo].[Series] ([Id], [Name])
	VALUES (@Id, @Name)

RETURN 0
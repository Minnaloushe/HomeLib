
CREATE PROCEDURE [dbo].[Author_Update]
	@Id uniqueidentifier,
	@FirstName nvarchar(255),
	@MiddleName nvarchar(255),
	@LastName nvarchar(255)
AS
	UPDATE [dbo].[Authors]
	SET [FirstName] = @FirstName,
		[MiddleName] = @MiddleName,
		[LastName] = @LastName
	WHERE [Id] = @Id;

RETURN 0
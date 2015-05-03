
CREATE PROCEDURE [dbo].[Author_Create]
	@Id uniqueidentifier,
	@FirstName nvarchar(255),
	@MiddleName nvarchar(255),
	@LastName nvarchar(255)
AS
	INSERT INTO [dbo].[Authors] ([Id], [FirstName], [MiddleName], [LastName])
	VALUES (@Id, @FirstName, @MiddleName, @LastName)

RETURN 0
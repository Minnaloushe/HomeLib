﻿CREATE PROCEDURE [dbo].[Author_Delete]
	@Id uniqueidentifier
AS
	DELETE
	FROM [dbo].[Authors]
	WHERE [Id] = @Id;

	SELECT @@ROWCOUNT

RETURN 0
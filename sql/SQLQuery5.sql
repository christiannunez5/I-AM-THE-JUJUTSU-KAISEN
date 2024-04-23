USE [appsdev730]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[UserLogsSP]
		@logDate = N'04-17-2024'

SELECT	'Return Value' = @return_value

GO

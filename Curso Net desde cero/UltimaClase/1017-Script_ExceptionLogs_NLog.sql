USE [TecGurus]
GO
CREATE TABLE ApplicationsLogs
(

	[LogId]				INT				IDENTITY(1,1) NOT NULL,
	[Application]		NVARCHAR(MAX)	NOT NULL,
	[Level]				NVARCHAR(MAX)	NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,
	[Message]			NVARCHAR(MAX)	NOT NULL,
	[StackTrace]		NVARCHAR(MAX)	NOT NULL,
	[InnerException]	NVARCHAR(MAX)	NOT NULL,
	[AdditionalInfo]	NVARCHAR(MAX)	NOT NULL,
	[LoggedOnDate]		DATETIME		NOT NULL	CONSTRAINT [df_logs_loggedondate]  DEFAULT (GETUTCDATE()),

	CONSTRAINT [pk_logs] PRIMARY KEY CLUSTERED([LogId])

)
GO
ALTER PROCEDURE [dbo].[InsertLog] 
(
	@application NVARCHAR(MAX),
	@level NVARCHAR(MAX),	
	@type NVARCHAR(MAX),
	@message NVARCHAR(MAX),
	@stackTrace NVARCHAR(MAX),
	@innerException NVARCHAR(MAX),
	@additionalInfo NVARCHAR(MAX)
)
AS
BEGIN

	INSERT INTO ApplicationsLogs
	(
		[Application],
		[Level],	
		[Type],
		[Message],
		[StackTrace],
		[InnerException],
		[AdditionalInfo]
	)
	VALUES
	(
		@application,
		@level,		
		@type,
		@message,
		@stackTrace,
		@innerException,
		@additionalInfo
	)
END
GO
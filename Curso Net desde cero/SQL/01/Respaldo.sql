--Ctrl + E, sirve para ejecutar

-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Books>
-- =============================================
CREATE TABLE Books(

	  IdBook			INT				NOT NULL	IDENTITY(1,1)	--Es el autoincremento, se le dice el valor inicial y el como se aumenta
	, NameBook			NVARCHAR(255)	NOT NULL	UNIQUE			-- Registro unico, no se puede repetir
	, DatePublishBook	DATE			NOT NULL
	, NumberPages		SMALLINT		NULL
	, SalePrice			NUMERIC(6,2)	NULL		DEFAULT(0)
	, PurchasePrice		DECIMAL(8,4)	NULL		DEFAULT(0)
	, IsAvaible			BIT							DEFAULT(1)

	PRIMARY KEY (IdBook) -- Se especifica la clave primaria
)
GO

-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Insert Book>
-- =============================================
CREATE PROCEDURE sp_add_books(
 @NameBook			NVARCHAR(255),
 @DatePublish		DATE,
 @NumberPages		SMALLINT,
 @SalePrice			NUMERIC(6,2),
 @PurchasePrice		DECIMAL(8,4),
 @IsAvaible			BIT
)	
AS
BEGIN
	INSERT dbo.Books( NameBook, DatePublishBook, NumberPages, SalePrice, PurchasePrice, IsAvaible)
	VALUES (
	 @NameBook		
	,@DatePublish	
	,@NumberPages	
	,@SalePrice		
	,@PurchasePrice	
	,@IsAvaible
	);
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Update Book>
-- =============================================
CREATE PROCEDURE sp_update_books(
 @Id				INT,
 @NameBook			NVARCHAR(255)	NULL,
 @DatePublish		DATE			NULL,
 @NumberPages		SMALLINT		NULL,
 @SalePrice			NUMERIC(6,2)	NULL,
 @PurchasePrice		DECIMAL(8,4)	NULL,
 @IsAvaible			BIT				NULL
)	-- Se especifica que los parametros pueden ser nulos
AS
BEGIN
	UPDATE dbo.Books
	SET
	  NameBook			= COALESCE(@NameBook,NameBook)				--COALESCE, se recomienda en los Update, ya que si no nos mandan un valor,
    , DatePublishBook	= COALESCE(@DatePublish,DatePublishBook)	-- se toma el que ya tiene
    , NumberPages		= COALESCE(@NumberPages,NumberPages)
    , SalePrice			= COALESCE(@SalePrice,SalePrice)
    , PurchasePrice		= COALESCE(@PurchasePrice,PurchasePrice)
    , IsAvaible			= COALESCE(@IsAvaible,IsAvaible)	
	WHERE IdBook = @Id;
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Delete Book>
-- =============================================
CREATE PROCEDURE sp_delete_books(
 @Id INT
)	
AS
BEGIN
	DELETE dbo.Books WHERE IdBook = @Id;
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Get all Books>
-- =============================================
CREATE PROCEDURE sp_get_all_books	
AS
BEGIN
	SELECT 
	  BK.IdBook
	, BK.NameBook
	, BK.DatePublishBook
	, BK.NumberPages
	, BK.SalePrice
	, BK.PurchasePrice
	, BK.IsAvaible
	FROM dbo.Books BK WITH(NOLOCK);	
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Get Book By Id>
-- =============================================
CREATE PROCEDURE sp_get_book_by_id(
	@Id INT
)	
AS
BEGIN
	SELECT 
	  BK.IdBook
	, BK.NameBook
	, BK.DatePublishBook
	, BK.NumberPages
	, BK.SalePrice
	, BK.PurchasePrice
	, BK.IsAvaible
	FROM dbo.Books BK WITH(NOLOCK)
	WHERE IdBook = @Id;
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Get Book By NameBook>
-- =============================================
CREATE PROCEDURE sp_get_books_by_namebook(
	@NameBook NVARCHAR(255)
)	
AS
BEGIN
	SELECT 
	  BK.IdBook
	, BK.NameBook
	, BK.DatePublishBook
	, BK.NumberPages
	, BK.SalePrice
	, BK.PurchasePrice
	, BK.IsAvaible
	FROM dbo.Books BK WITH(NOLOCK)
	WHERE  UPPER(RTRIM(LTRIM(Bk.NameBook))) LIKE '%'+UPPER(RTRIM(LTRIM(@NameBook)))+'%';
END
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Get Paged List of Books>
-- =============================================
CREATE PROCEDURE sp_get_books_paged_list(
 @Page INT,
 @Size INT,
 @Sortcolumn NVARCHAR(50) = NULL,
 @OrderDirection BIT = NULL,
 @FindNameBook NVARCHAR(255) = NULL,
 @TotalRow INT = O OUTPUT
 )
AS
BEGIN
    
	DECLARE @offset INT;
    DECLARE @newsize INT;
	SET @Sortcolumn = COALESCE(@Sortcolumn,'IdBook');
	SET @OrderDirection = COALESCE(@OrderDirection,1);

    IF(@Page=0)
       BEGIN
            SET @offset = @Page
            SET @newsize = @Size
       END
    ELSE 
      BEGIN
        SET @offset = @Page+1
        SET @newsize = @Size-1
      END
    SET NOCOUNT ON
   
    SELECT 
	  BO.IdBook,
	  BO.NameBook,
	  BO.PurchasePrice,
	  BO.SalePrice,
	  BO.DatePublishBook,
	  BO.IsAvaible,	  
	 ROW_NUMBER() OVER (ORDER BY @Sortcolumn )  [RowNumber]
	 INTO #TemporalPagedSet
     FROM [dbo].[Books] BO WITH(NOLOCK);
    
	--select * from #TemporalPagedSet

	SET @Sortcolumn = IIF(@OrderDirection = 1,@Sortcolumn+'Asc',@Sortcolumn+'Desc');

	--select @Sortcolumn
	SELECT 
	  PG.RowNumber,
	  PG.IdBook,
	  PG.NameBook,
	  PG.PurchasePrice,
	  PG.SalePrice,
	  PG.DatePublishBook,
	  PG.IsAvaible
	FROM #TemporalPagedSet PG
	WHERE 
	PG.RowNumber BETWEEN @offset AND (@offset + @newsize)
	AND
	(@FindNameBook IS NULL OR UPPER(RTRIM(LTRIM(PG.NameBook))) LIKE '%'+UPPER(RTRIM(LTRIM(@FindNameBook)))+'%')
	ORDER BY
		 CASE WHEN @Sortcolumn = 'IdBookAsc'			THEN PG.IdBook END ASC
		,CASE WHEN @Sortcolumn = 'NameBookAsc'			THEN PG.NameBook END ASC
		,CASE WHEN @Sortcolumn = 'PurchasePriceAsc'		THEN PG.PurchasePrice END ASC
		,CASE WHEN @Sortcolumn = 'SalePriceAsc'			THEN PG.SalePrice END ASC
		,CASE WHEN @Sortcolumn = 'DatePublishBookAsc'	THEN PG.DatePublishBook END ASC
		,CASE WHEN @Sortcolumn = 'IsAvaibleAsc'			THEN PG.IsAvaible END DESC
		,CASE WHEN @Sortcolumn = 'IdBookDesc'			THEN PG.IdBook END DESC
		,CASE WHEN @Sortcolumn = 'NameBookDesc'			THEN PG.NameBook END DESC
		,CASE WHEN @Sortcolumn = 'PurchasePriceDesc'	THEN PG.PurchasePrice END DESC
		,CASE WHEN @Sortcolumn = 'SalePriceDesc'		THEN PG.SalePrice END DESC
		,CASE WHEN @Sortcolumn = 'DatePublishBookDesc'	THEN PG.DatePublishBook END DESC
		,CASE WHEN @Sortcolumn = 'IsAvaibleDesc'		THEN PG.IsAvaible END DESC
		
		

	DROP TABLE #TemporalPagedSet;

	SET @TotalRow = (SELECT COUNT(IdBook) FROM Books WITH(NOLOCK));

END
GO

--Ctrl+K+C, comentar // Ctrl+K+U, descomentar
--DROP PROCEDURE sp_add_books;    
--DROP PROCEDURE sp_update_books;
--DROP PROCEDURE sp_delete_books;
--DROP PROCEDURE sp_get_all_books;
--DROP PROCEDURE sp_get_book_by_id;
--DROP PROCEDURE sp_get_books_by_namebook;
--DROP PROCEDURE sp_get_books_paged_list;
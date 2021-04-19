USE [TecGurus]
GO
/****** Object:  StoredProcedure [dbo].[sp_get_books_paged_list]    Script Date: 12/03/2021 08:21:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Dominguez>
-- Create date: <15-02-2020>
-- Description:	<Get Paged List of Books>
-- =============================================
ALTER PROCEDURE [dbo].[sp_get_books_paged_list](
 @Page INT,
 @Size INT,
 @Sortcolumn NVARCHAR(50) = NULL,
 @OrderDirection BIT = NULL,
 @FindNameBook NVARCHAR(255) = NULL,
 @TotalRow INT = O OUTPUT
 )
AS
BEGIN
    
	DECLARE @initial INT;
    DECLARE @limit INT;
	SET @Sortcolumn = COALESCE(@Sortcolumn,'IdBook');
	SET @OrderDirection = COALESCE(@OrderDirection,1);

	IF(@Size = 1)
		BEGIN
			SET @Size  = (SELECT COUNT(IdBook) FROM Books WITH(NOLOCK))
		END

    IF(@Page=0)
       BEGIN
            SET @initial = @Page
            SET @limit = @Size
       END
    ELSE 
      BEGIN
        SET @initial = @Page*@Size+1
        SET @limit = @initial+@Size-1
      END
    SET NOCOUNT ON

	--SELECT @initial ;
	--SELECT @limit ;
   
    SELECT 
	  BO.IdBook,
	  BO.NameBook,
	  BO.NumberPages,
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
	  PG.IsAvaible,
	  PG.NumberPages
	FROM #TemporalPagedSet PG
	WHERE 
	PG.RowNumber BETWEEN @initial AND (@limit)
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

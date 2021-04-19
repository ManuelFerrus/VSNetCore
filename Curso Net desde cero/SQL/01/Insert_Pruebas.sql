USE [TecGurus]
GO

INSERT Books (NameBook, DatePublishBook, NumberPages, SalePrice, PurchasePrice, IsAvaible)
	VALUES ('NAME BOOK', '2021-02-12', 50, 5555.66, 5555.6666, 1),
			('NAME BOOK TWO', '2021-02-12', 50, 5555.66, 5555.6666, 1),
			('NAME BOOK THREE', '2021-02-12', 50, 5555.66, 5555.6666, 1),
			('NAME BOOK FOUR', '2021-02-12', 50, 5555.66, 5555.6666, 1);
GO

SELECT * FROM Books;
--truncate TABLE Books;


EXECUTE sp_add_books 'NAME BOOK FIVE', '2021-02-12', 50, 5555.66, 5555.6666, 1 -- Se ejecuta el store procedure, pero sin los parentesis
--Para ver el arbol de los SP, es en Programmability / Stored Procedures


UPDATE Books SET NameBook = 'NAME BOOK ONE' WHERE IdBook = 1 

DECLARE @NameBook NVARCHAR (255);
									--Si es nula, que varieble regresa
UPDATE Books SET NameBook = COALESCE(@NameBook, NameBook) WHERE IdBook = 1  -- Si le mandamos nulo, el campo no se afecta

DECLARE @NameBook2 NVARCHAR (255);
SET @NameBook2='NAME BOOK TRY';
									--Si es nula, que varieble regresa
UPDATE Books SET NameBook = COALESCE(@NameBook2, NameBook) WHERE IdBook = 1  -- Si le mandamos nulo, el campo no se afecta

SELECT * FROM Books WHERE IdBook = 3;
EXECUTE sp_get_book_by_id 3;
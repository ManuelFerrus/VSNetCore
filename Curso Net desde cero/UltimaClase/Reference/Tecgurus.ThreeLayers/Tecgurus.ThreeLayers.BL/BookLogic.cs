using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tecgurus.ThreeLayers.DL;
using Tecgurus.ThreeLayers.Ent;
using Tecgurus.ThreeLayers.Tools;

namespace Tecgurus.ThreeLayers.BL
{
    public class BookLogic
    {
        public bool AddBook(BookEnt book)
        {
            var result = false;
            
            using (var scope = new TransactionScope())
            {
                using (var data = new BookData())
                {
                    //Regla: el nombre de los libros debe de guardarse en mayusculas 
                    book.NameBook = book.NameBook.ToUpper().Trim();

                    //Regla: debe de ser mayor o igual a un 10 porciento del precio de compra                
                    if ((Convert.ToDouble(book.PurchasePrice) > 9999.9999) || Convert.ToDouble(book.PurchasePrice) <= (book.SalePrice * 1.10))
                    {
                        book.PurchasePrice = Convert.ToDecimal(book.SalePrice * 1.10);
                    }

                    result = data.AddBook(book);

                }

                scope.Complete();
            }

            return result;
        }

        public bool UpdateBook(int id, BookEnt book)
        {
            var success = false;
            using (var scope = new TransactionScope())
            {
                using (var data = new BookData())
                {
                    //Regla: el nombre de los libros debe de guardarse en mayusculas 
                    book.NameBook = book.NameBook.ToUpper().Trim();

                    //Regla: debe de ser mayor o igual a un 10 porciento del precio de compra                
                    if (Convert.ToDouble(book.PurchasePrice) <= (book.SalePrice * 1.10))
                    {
                        book.PurchasePrice = Convert.ToDecimal(book.SalePrice * 1.10);
                    }

                    var result = data.UpdateBook(id, book);
                    success = result;
                }

                if (success)
                {
                    try
                    {

                        MessageSender.SendMessageConfigurationManager("epdc.dom@gmail.com", "Actualización de libro", $"Nombre: {book.NameBook} Precio de venta {book.PurchasePrice} ");
                        scope.Complete();

                    }
                    catch (Exception ex)
                    {
                        success = false;                     
                        CustomLogger.logger.Error(ex);
                        CustomLogger.loggerDataBase.Error(ex);
                    }

                }

                
            }
            return success;

        }

        public bool DeleteBook(int id)
        {
            var success = false;

            var book = GetBookById(id);

            using (var data = new BookData())
            {
                var result = data.DeleteBook(id);
                success = result;
            }

            if (success)
            {
                try
                {
                    MessageSender.SendMessageConfigurationManager("epdc.dom@gmail.com", "Eliminación de libro de la base de datos", $"Nombre: {book.NameBook}");

                }
                catch (Exception ex)
                {
                    CustomLogger.logger.Error(ex);
                    CustomLogger.loggerDataBase.Error(ex);
                }

            }

            return success;

        }

        public List<BookEnt> GetAllBooks()
        {
            var list = new List<BookEnt>();
            using (var data = new BookData())
            {
                list = data.GetAllBooks();
            }

            return list;

        }

        public BookEnt GetBookById(int id)
        {
            var book = new BookEnt();
            using (var data = new BookData())
            {
                book = data.GetBookById(id);
            }

            return book;
        }

        public List<BookEnt> GetBookByName(string nameBook)
        {
            var books = new List<BookEnt>();
            using (var data = new BookData())
            {
                books = data.GetBookByName(nameBook);
            }

            return books;
        }


        public List<BookEnt> GetPagedBooks(int page, int size, string sortColumn, bool orderDirection, string nameBook, out int total)
        {
            var books = new List<BookEnt>();
            var totalRows = 0;
            using (var data = new BookData())
            {
                books = data.GetPagedBooks(page, size, sortColumn, orderDirection, nameBook, out totalRows);
            }

            total = totalRows;

            return books;

        }

    }
}

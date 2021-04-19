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

            //Se inicializa la transacccion
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
                if (result)
                {
                    try
                    {

                        //TODO: Ver. la configuracion del correo
                        //MessageSender.SendMessageConfigurationManager("manuel.ferrus.developer@gmail.com", "Actualización de libro", $"Nombre: {book.NameBook} Precio de venta {book.PurchasePrice} ");
                        scope.Complete(); // si no se alcanza el scope comple, el rollback es implicito
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        result = false;
                        CustomLogger.logger.Error(ex);
                    }
                }
            }
            return result;
        }

        public bool UpdateBook(int id, BookEnt book)
        {
            var success = false;
           
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

                    }
                    catch (Exception ex)
                    {
                        success = false;
                        CustomLogger.logger.Error(ex);
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

    }
}

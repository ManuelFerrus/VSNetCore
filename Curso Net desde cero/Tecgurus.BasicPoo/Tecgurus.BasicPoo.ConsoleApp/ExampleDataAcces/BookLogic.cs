using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleDataAcces
{
    public class BookLogic
    {
        public bool AddBook(Book book)
        {
            using (var data = new BookData())
            {
                var result = data.AddBook(book);
                return result;
            }
        }

        public bool UpdateBook(int id, Book book)
        {
            var success = false;
            using (var data = new BookData())
            {
                var result = data.UpdateBook(id, book);
                success = result;
            }

            return success;

        }

        public bool DeleteBook(int id)
        {
            using (var data = new BookData())
            {
                var result = data.DeleteBook(id);
                return result;
            }

        }

        public List<Book> GetAllBooks()
        {
            var list = new List<Book>();
            using (var data = new BookData()) // se utiliza el using, para que al finalizar el garbage collection destruya el objeto
            {
                list = data.GetAllBooks(); // se consulta el metodo de la clase Bookdata
            }//al finalizar, cierra la conexion a la BD, entra por el dispose

            return list;

        }

        public Book GetBookById(int id)
        {
            var book = new Book();
            using (var data = new BookData())
            {
                book = data.GetBookById(id);
            }

            return book;
        }

    }
}

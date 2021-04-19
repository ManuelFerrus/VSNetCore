using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecgurus.ThreeLayers.ExampleApp.DL;
using Tecgurus.ThreeLayers.ExampleApp.Entities;
using Tecgurus.ThreeLayers.ExampleApp.Tools;

namespace Tecgurus.ThreeLayers.ExampleApp.BL
{
    public class BookLogic
    {
        public bool AddBook(Book book)
        {
            using (var data = new BookData())
            {
                var result = data.AddBook(book);

                if (result)
                {
                    var message = new MessageSender();
                    //se tiene que validar que el valor ingresado si sea un correo
                    //message.SendMessage("manuel.ferrus.developer@gmail.com", "Se agregó nuevo libro", JsonConvert.SerializeObject(book));
                    message.SendMessageAppConfig("manuel.ferrus.developer@gmail.com", "Se agregó nuevo libro", JsonConvert.SerializeObject(book));
                }

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
            using (var data = new BookData())
            {
                list = data.GetAllBooks();
            }

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

        public List<Book> GetBookByName(string nameBook)
        {
            var books = new List<Book>();
            using (var data = new BookData())
            {
                books = data.GetBookByName(nameBook);
            }

            return books;
        }

    }
}

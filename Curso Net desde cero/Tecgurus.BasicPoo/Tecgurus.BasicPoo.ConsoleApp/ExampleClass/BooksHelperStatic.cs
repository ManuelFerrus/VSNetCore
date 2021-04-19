using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.BasicPoo.ConsoleApp.ExampleClass
{
    public static class BooksHelperStatic
    {

        public static List<Book> GetRandomBooks(int sizeCollection)
        {

            var books = new List<Book>();

            var rand = new Random();

            while (books.Count < sizeCollection)
            {
                books.Add(new Book
                {
                    IdBook = books.Count + 1
              ,
                    NameBook = $"Libro N°{books.Count + 1}"
              ,
                    DatePublishBook = DateTime.Now
              ,
                    NumberPage = rand.Next()
              ,
                    Avaible = rand.Next(0, 2) > 0
              ,
                    PurchasePrice = (rand.NextDouble() * (676.89 - 45.89) + 45.89)
              ,
                    SalePrice = (float)(rand.NextDouble() * (99.8990 - 45.8956) + 45.8956)
                });
            }

            return books;

        }
    }
}

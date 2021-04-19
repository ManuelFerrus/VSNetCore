using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tecgurus.ThreeLayers.Ent;

namespace Tecgurus.ThreeLayers.BL
{

    public static class BookEntHelper
    {

        /// <summary>
        /// Método estatico
        /// Genera lista de libros de forma aleatoria
        /// </summary>
        /// <param name="sizeCollection"></param>
        /// <returns></returns>
        public static List<BookEnt> GetRandomBooks(int sizeCollection)
        {

            var books = new List<BookEnt>();

            var rand = new Random();

            while (books.Count < sizeCollection)
            {
                books.Add(new BookEnt
                {

                    NameBook = $"Libro N°{books.Count + 1}"
              ,
                    DatePublishBook = RandomDay()
              ,
                    NumberPages = (short)rand.Next(short.MaxValue - short.MinValue)
              ,
                    IsAvaible = rand.Next(0, 2) > 0
              ,
                    SalePrice = (rand.NextDouble() * (9999.99 - 49.99) + 49.99)
              ,
                    PurchasePrice = (decimal)(rand.NextDouble() * (9999.9999 - 49.9999) + 49.9999)
                });
            }

            return books;

        }

        static DateTime RandomDay()
        {
            var rand = new Random();
            DateTime start = new DateTime(1970, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }
    }
}

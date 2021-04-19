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

        private static Random random = new Random();

        /// <summary>
        /// Método estatico
        /// Genera lista de libros de forma aleatoria
        /// </summary>
        /// <param name="sizeCollection"></param>
        /// <returns></returns>
        public static List<BookEnt> GetRandomBooks(int sizeCollection)
        {

            var books = new List<BookEnt>();

            //var rand = new Random();

            while (books.Count < sizeCollection)
            {
                books.Add(new BookEnt
                {

                    NameBook = $"Libro {RandomString(15)}"
              ,
                    DatePublishBook = RandomDay()
              ,
                    NumberPages = (short)random.Next(50,byte.MaxValue)
              ,
                    IsAvaible = random.Next(0, 2) > 0
              ,
                    SalePrice = Math.Round((random.NextDouble() * (8999.99 - 49.99) + 49.99),2)
              ,
                    PurchasePrice = Math.Round((decimal)(random.NextDouble() * (89999.9999 - 49.9999) + 49.9999),4)
                });
            }

            return books;

        }

        public static DateTime RandomDay()
        {
            
            DateTime start = new DateTime(1970, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                       
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

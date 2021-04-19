using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecgurus.ExamplePoo.ConsoleApp.ExampleDataAcces;


namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleDataAcces
{
    public static class ExampleDataAccesProgram
    {
        public static void DoMain()
        {
            AddBooks();
            ReadBooks();
            Console.ReadKey();
        }
        
        static void ReadBooks()
        {


            var bookl = new BookLogic();

            var lisboks = bookl.GetAllBooks();

            foreach (var item in lisboks)
            {

                Console.WriteLine(JsonConvert.SerializeObject(item, Formatting.Indented));
            }
        }

        static void AddBooks()
        {
            var listToAdd = BooksHelperStatic.GetRandomBooks(5);
            var logic = new BookLogic();
            foreach (var item in listToAdd)
            {
                logic.AddBook(item);
                Console.WriteLine("Done!");
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecgurus.BasicPoo.ConsoleApp.ExampleClass;

namespace Tecgurus.BasicPoo.ConsoleApp.ExampleClass
{
    public static class ExampleClassProgram
    {
        public static void DoMain()
        {

            //CreateObjects();

            //CreateCollectionsWithStaticHelper();

            //CreateCollectionsWithHelper();

            //CreateObjectGps();

            CreateCollections();
            Console.ReadKey();
        }

        static void CreateObjects()
        {

            var bookOne = new Book();
            var bookTwo = new Book(2, "La metamorosis", 45.50);
            var bookThree = new Book(3, "Laberinto", "14/11/2020");
            var bookFour = new Book(4, "Laberinto 2", new DateTime(1987, 6, 17));
            var bookFive = new Book
            {
                Avaible = true
                ,
                DatePublishBook = new DateTime(2001, 7, 18)
                ,
                IdBook = 5
                ,
                NameBook = "El libro"
                ,
                NumberPage = 50
                ,
                PurchasePrice = 56.78


            };

            bookOne.IdBook = 1;
            bookOne.DatePublishBook = new DateTime(2008, 7, 19);

            var idBookOne = bookOne.IdBook;
            Console.WriteLine(idBookOne);

            var books = new List<Book>();
            var users = new List<User>();
            var dates = new List<DateTime>();


            books.Add(bookThree);
            books.Add(bookFour);
            books.Add(bookFive);
            books.Add(new Book(6, "La metamorosis 8", 47.89));
            books.Add(bookOne);
            books.Add(bookTwo);

            Console.WriteLine($"Total de libros:{books.Count()}");

            books = books.OrderBy(i => i.IdBook).ToList();

            foreach (var item in books)
            {
                //Console.WriteLine($"Id : {item.IdBook} Nombre: {item.NameBook} Fecha: {item.DatePublishBook}");

                if (!string.IsNullOrEmpty(item.NameBook))
                {
                    Console.WriteLine(JsonConvert.SerializeObject(item, Formatting.Indented));
                }
            }

            Console.WriteLine(JsonConvert.SerializeObject(books.OrderBy(i => i.IdBook), Formatting.Indented));

            Console.WriteLine(JsonConvert.SerializeObject(books.OrderByDescending(i => i.IdBook), Formatting.Indented));
        }

        public static void CreateCollections()
        {
            var list = new List<Book>();
            //var listTwo = new List<int>();
            //var listStrings = new List<string>();

            //var book = new Book
            //{

            //    IdBook = 1,
            //    DatePublishBook = DateTime.Now,
            //    NameBook = "One Book",
            //    NumberPage = 67,
            //    PurchasePrice = 34.87D,
            //    SalePrice = 55.88F,
            //    Avaible = true

            //};

            //list.Add(book);


            list.Add(new Book
            {

                IdBook = 7,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 1,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 2,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 3,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 4,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 5,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });
            list.Add(new Book
            {

                IdBook = 6,
                DatePublishBook = DateTime.Now,
                NameBook = "One Book",
                NumberPage = 67,
                PurchasePrice = 34.87D,
                SalePrice = 55.88F,
                Avaible = true

            });


            //Mostrar lista list en forma de Json
            //foreach (var book0 in list) 
            //foreach (var book0 in list.OrderBy(n => n.IdBook)) //order by es parte de linQ
            //{
            //    Console.WriteLine($"{JsonConvert.SerializeObject(book0, Formatting.Indented)}");
            //}
            var searchBook = list.Where(b => b.IdBook.Equals(7)).FirstOrDefault(); //regresa el elemento fuente
            var searchBooks = list.Where(b => b.IdBook.Equals(7)); //regresa la lista
            Console.WriteLine($"{JsonConvert.SerializeObject(searchBook, Formatting.Indented)}");
            //Mostrar "presione una telca para continuar"
            //Console.WriteLine("presione una tecla para continuar");
            //Console.ReadLine();

            //var bookHelper = new BooksHelper();

            //var listRamOne = bookHelper.GetRandomBooks(5);

            //Mostrar lista listRamOne en forma de Json
            //foreach (var book2 in listRamOne)
            //{
            //    Console.WriteLine($"{JsonConvert.SerializeObject(book2, Formatting.Indented)}");
            //}
            //Mostrar "presione una telca para continuar"
            //Console.WriteLine("presione una tecla para continuar");
            //Console.ReadLine();

            //var listRamTwo = BooksHelperStatic.GetRandomBooks(6);



            //foreach (var book1 in listRamTwo)
            //{
            //    Console.WriteLine($"{ JsonConvert.SerializeObject(book1, Formatting.Indented)}");
            //}

            //Mostrar "presione una telca para continuar"
            //Console.WriteLine("presione una tecla para continuar");
            //Console.ReadLine();
            //var listOrderby = listRamTwo.OrderBy(n => n.SalePrice).ToList();//vamos ordenando la lista por el precio ASCENDENTE
            //var listOrderby = listRamTwo.OrderByDescending(n => n.SalePrice).ToList();//vamos ordenando la lista por el precio ASCENDENTE

            //foreach (var book1 in listOrderby)
            //{
            //    Console.WriteLine($"{ JsonConvert.SerializeObject(book1, Formatting.None)}");
            //}
        }

        static void CreateCollectionsWithStaticHelper()
        {
            //cuando la clase es estatica, no es necesario crear un objeto de la clase para utilizar sus metodos
            Console.WriteLine(JsonConvert.SerializeObject(BooksHelperStatic.GetRandomBooks(5).OrderBy(i => i.IdBook), Formatting.Indented));

        }

        static void CreateCollectionsWithHelper()
        {
            var helper = new BooksHelper();
            var booksR = helper.GetRandomBooks(3);

            Console.WriteLine(JsonConvert.SerializeObject(booksR.OrderBy(i => i.IdBook), Formatting.Indented));

        }

        static void CreateObjectGps()
        {
            var gpsOne = new ReceptorGps("abcdffd-123");
            gpsOne.Latitude = 89.8989;
            gpsOne.Longitude = 179.89034;



            var gpsTwo = new ReceptorGps("rewrw-123");
            gpsTwo.Latitude = 65.897;
            gpsTwo.Longitude = 32.766;

            //gpsOne.Latitude = gpsOne.Latitude - 1;

            Console.WriteLine(JsonConvert.SerializeObject(gpsOne, Formatting.Indented));

            var position = gpsOne.GetCurrentPosition();

            Console.WriteLine(JsonConvert.SerializeObject(position, Formatting.Indented));


            var dictionary = new Dictionary<string, Tuple<double, double>>();

            dictionary.Add(gpsOne.Id, gpsOne.GetCurrentPosition());
            dictionary.Add(gpsTwo.Id, gpsTwo.GetCurrentPosition());


            Console.WriteLine(JsonConvert.SerializeObject(dictionary, Formatting.Indented));


            //gpsOne.DescribePositio();

            //gpsOne.DescribePositioTwo();

        }

    }
}

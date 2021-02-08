using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurus.HelloWorld.ConsoleApplication.Entities;

namespace TecGurus.HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de objeto -- ctrl k c, comentario
            //Forma 1
            Student stud = new Student();
            stud.Id = 1;
            stud.FirstName = "Manuel";
            stud.LastName = "Ferrusquia";
            stud.BirthDate = new DateTime(1990, 04, 22);

            Console.WriteLine(stud.Id);
            Console.WriteLine(stud.FirstName);
            Console.WriteLine(stud.LastName);
            Console.WriteLine(stud.BirthDate);
            Console.WriteLine(stud.PlateNumber);

            //Forma 2
            var studTwo = new Student
            {
                Id = 2,
                FirstName = "Lorena",
                LastName = "Rodriguez",
                BirthDate = new DateTime(1999, 11, 25)
            };

            Console.WriteLine(studTwo.Id); //Multiseccion (shift + tab)
            Console.WriteLine(studTwo.FirstName);
            Console.WriteLine(studTwo.LastName);
            Console.WriteLine(studTwo.BirthDate);
            Console.WriteLine(studTwo.PlateNumber);


            Student studentThree = new Student(3, "89KY")
            { //ctrl k, d (ajustar sangrias)
                Id = 3,
                FirstName = "Prueba",
                LastName = "estudiante 3",
                BirthDate=new DateTime(2000, 01, 19)
            };
            Console.WriteLine(studentThree.Id);
            Console.WriteLine(studentThree.FirstName);
            Console.WriteLine(studentThree.LastName);
            Console.WriteLine(studentThree.BirthDate);
            Console.WriteLine(studentThree.PlateNumber);
            Console.WriteLine(studentThree.ClassRoom);
            Console.ReadKey();
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecgurus.BasicPoo.ConsoleApp.ExampleInheritance;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleInheritance
{
    public static class ExampleInheritanceProgram
    {
        public static void DoMain()
        {
            //ExampleInheritanceAbstractClase();
            ExampleInheritance();

            Console.ReadKey();
        }

        static void ExampleInheritanceAbstractClase()
        {

            //var aninal = new AnimalBase();
            //verificar los enum, para las validaciones de tipo de datos
            var canino = new Canine();
            canino.ScientificName = "Canino algo";
            canino.CanineType = CanineType.Domesticated;
            canino.FeedingType = FeedingType.omnivore;
            canino.SkeletonType = SkeletonType.invertebrate;
            canino.CanineInfo();
            canino.Sound();

            //Apesar que en felino no tiene propiedades, heredamos todo del animal base
            var felino = new Feline();
            felino.FeedingType = FeedingType.carnivorous;
            felino.ScientificName = "Felino prueba";
            felino.SkeletonType = SkeletonType.vertebrate;
            felino.Sound();

            var canineOne = new Canine(FeedingType.carnivorous, CanineType.Wild)
            {
                SkeletonType = SkeletonType.vertebrate
                ,
                ScientificName = "Canidae"

            };

            canineOne.CanineInfo();
            canineOne.Sound();

            Console.ReadKey();

        }

        static void ExampleInheritance()
        {

            //var ibulg = new IBuilding();

            //var house = new House() { TotalWindows = 4 };
            //Console.WriteLine(house.OpenDoor());
            //house.OpenWindow();

            var factory = new Factory()
            {

                FoundationDate = new DateTime(1985, 12, 1)
            ,
                NameCompany = "La Romita"


            };


            Console.WriteLine(factory.OpenDoor());
            factory.OpenWindow();
            Console.WriteLine(factory.TurnOnLabel());
            factory.Dispose();//Destruye la instancia
            factory.OpenWindow();


            //con el using se encapzula el tiempo que se mantendra en memoria el objeto
            using (var factoryTwo = new Factory())
            {
                factoryTwo.FoundationDate = new DateTime(1985, 12, 1);
                factoryTwo.NameCompany = "La Romita";

                factoryTwo.OpenWindow();

                Console.WriteLine(factoryTwo.OpenDoor());

                Console.WriteLine(factoryTwo.TurnOnLabel());



            }

            //factoryTwo.OpenWindow();//no deja utilizarlo porque ya no existe en este contexto




        }

    }
}

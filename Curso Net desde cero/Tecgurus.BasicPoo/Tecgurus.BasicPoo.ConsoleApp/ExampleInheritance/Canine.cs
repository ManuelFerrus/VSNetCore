using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleInheritance
{
    public class Canine : AnimalBase
    {
        public Canine() { }

        public Canine(FeedingType feedingType, CanineType canineType) : base(feedingType)
        {

            this.CanineType = canineType;
            //this.FeedingType = feedingType;        
        }

        public CanineType CanineType { get; set; }


        public override void Sound() //en la clase hija, se tiene que poner el override, para hacer la sobrecarga
        {

            Console.WriteLine("The canine makes: woof woof!");

        }

        public void CanineInfo()
        {
            Console.WriteLine($"This canine is {this.CanineType}. Feeding type is {this.FeedingType}. All canine are {base.SkeletonType}");
        }

    }
}

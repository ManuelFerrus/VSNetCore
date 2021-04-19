using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleInheritance
{
    public abstract class AnimalBase
    {
        public AnimalBase() { }

        public AnimalBase(FeedingType feedingType) {

            this.FeedingType = feedingType;        
        }


        public string ScientificName { get; set; }

        public FeedingType FeedingType { get; set; }

        public SkeletonType SkeletonType { get; set; }

        public virtual void Sound()//permite la sobrecarga para las clases que heredan este metodo
        {
            Console.WriteLine("The animal makes: brrrr!");
        }

    }
}

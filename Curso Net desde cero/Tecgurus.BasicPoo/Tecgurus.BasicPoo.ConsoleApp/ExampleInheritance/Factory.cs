using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleInheritance
{
    public class Factory : IBuilding, ICompany, IDisposable
    {

        public string NameCompany { get; set; }

        public DateTime FoundationDate { get; set; }

        public void Dispose()
        {
            Console.WriteLine("We dont use the factory. This will be destroyed");
            
            GC.SuppressFinalize(this);
        }

        public int GetInfo()
        {
            throw new NotImplementedException();
        }

        public string OpenDoor()
        {
            return "The main door's factory is open";
        }

        public void OpenWindow()
        {
            Console.WriteLine($"We have not windows, Oops!");
        }

        public string TurnOnLabel()
        {
            var minutes = Math.Round((DateTime.Now - FoundationDate).TotalMinutes);

            var slogan = $"Making dreams by :{NameCompany}, since {minutes} minutes".ToUpper();

            return slogan;
        }
    }
}

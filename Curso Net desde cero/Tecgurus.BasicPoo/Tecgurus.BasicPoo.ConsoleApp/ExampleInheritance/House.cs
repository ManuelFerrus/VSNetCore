using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleInheritance
{
    public class House : IBuilding //Una interfaz debe de implementar todos los meotodos, de la clase base
    {
        public byte TotalWindows { get; set; }

        public int GetInfo()
        {
            throw new NotImplementedException();
        }

        public string OpenDoor()
        {
            return "The main door's house is open";
        }

        public void OpenWindow()
        {
            var i = 0;
            while (i < TotalWindows)
            {

                Console.WriteLine($"Window {i + 1} open");
                i++;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurus.HelloWorld.ConsoleApplication.Entities
{
    class Student
    {
        public Student() { }
        public Student(int id, string classroom)
        {
            Id = id;
            PlateNumber = "0009977" + id;
            _classRoom = classroom;
        }
        public Student(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
        }
        //campo debe de ser private
        private string _classRoom;

        //propiedades
        public int Id { get; set; } //prop, tab - tab
        public string FirstName { get; set; } //ctl+D, duplica el renglon
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PlateNumber { get; set; }
        //una propiedad de solo lectura debe tener relacionado un camppo
        public string ClassRoom { get { return _classRoom; } }
    }
}

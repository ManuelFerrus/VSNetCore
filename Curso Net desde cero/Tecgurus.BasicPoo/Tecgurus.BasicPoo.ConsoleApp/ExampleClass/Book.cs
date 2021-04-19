using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.BasicPoo.ConsoleApp.ExampleClass
{
    /// <summary>
    /// clases o entidades:
    /// Se les nombra entidades a las clases que se usan para describir las propiedades de unelemto que hemos abstraido
    /// En este Caso la clase Book, es la entidad que describe a un libro.
    /// Una clase es un mapa que contiene las isntrucciones de como debe de crearse un objeto.
    /// Es como el ADN de la enidad que creamos. 
    /// </summary>
    public // MODIFICADOR DE ACCESO : determina el nivel de acceso a la clase desde fuera del proyecto
            // Se aplica de forma gerarquica, es decir los metodos y propiedades dentro son accecibles desde fuera dependiendo de este nivel 
            // private: solo las clase del mismo namespace tienen acceso a esta clase.
            // public: la clase es visible desde fuera del namespace , es decir otro porgrama podria usar esta clase.
            // Mayor información: https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/access-modifiers
        class Book // NOMBRE DE LA CLASE: siempre en plural
    {
        public  // MODIFICADOR DE ACCESO : determina el nivel de acceso a la propiedad desde fuera de la clase 
            int IdBook  // TIPO Y NOMBRE DE UNA PROPIEDAD
        {
            get;    // MÉTODO DE OBTENCION:: lo usamos para obtener el valor de la propiedad
            set;    // MÉTODO DE ASIGNACIÓN: lo usamos para asignar un valor a la propiedad
        }
        public string NameBook { get; set; }
        public DateTime DatePublishBook { get; set; }
        public int NumberPage { get; set; }
        public double PurchasePrice { get; set; }
        public float SalePrice { get; set; }
        public Boolean Avaible { get; set; }


        /// <summary>
        /// MÉTODO COSNTRUCTOR
        /// Es un metdo especial, que se usa para crear un objeto del tipo que lo contine.
        /// en este caso crea un objeto de Book
        /// Al proceso de creación de objetos se le conoce como instanciación
        /// aquí podemos indicar si aplicaremos o no una valor en especial al crear un objeto
        /// TODAS LAS CLASES TIENEN UN CONSTRUCTOR PRINCIPAL, AUNQUE NO ESTE DELCARADO EXISTE
        /// </summary>
        public Book() { }

        /// <summary>
        /// Los cosntructores se pueden sobre cargar
        /// Podemos tener uno o mas cosntructores con diferentes parametros de entrada
        /// </summary>
        /// <param name="name"></param>
        /// <param name="datePublish"></param>
        public Book(int id, string name, string datePublish)
        {
            IdBook = id;
            NameBook = name;
            DatePublishBook = Convert.ToDateTime(datePublish);

        }

        /// <summary>
        /// Método sobecargado
        /// </summary>
        /// <param name="id">Es el identificador de un libro</param>
        /// <param name="name">Es el nombre de un libro</param>
        /// <param name="price">Es el precio de un libro</param>
        public Book(int id, string name, double price)
        {
            IdBook = id;
            NameBook = name;
            PurchasePrice = price;
            SalePrice = (float)price;
        }

        public Book(int id, string name, DateTime datePublish)
        {
            IdBook = id;
            NameBook = name;
            DatePublishBook = datePublish;

        }
    }
}





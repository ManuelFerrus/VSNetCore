/// LIBRERIAS DE SISTEMA: PERTENECEN AL MISMO FRAMEWORK O SEA .NET
/// LIBRERIA DE TERCEROS: ELABORADAS POR OTROS DESARROLADORES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// EL CONTENEDOR DEL PROYECTO
/// </summary>
namespace Tecgurus.BasicPoo.ConsoleApp.ExampleSintaxis
{

    /// <summary>
    /// NUESTRA CLASE PRINCIPAL DEL PROGRAMA
    /// LA PRIMERA EN SER EJECUTADA
    /// </summary>
    public class ExampleSintaxisProgram
    {        
        public static void DoMain()
        {
            // UTILIZAR METODO
            //DataTypesExample();


            //ConvertionsExample();

            //CastingExample();


            StringsExample();

            //OutReferenceExample();

            //ReferenceValueExample();

            //CicleExamples();

            //DataTypesExample();

            //ReferenceAndValueTypesExample();
        }

        /// <summary>
        /// Metodo, ejemplo de variables y tipos de datos
        /// </summary>
        public static void DataTypesExample()
        {
            ///Las variables nos ayudan a almacenar en memoria
            ///valores de diferentes tipos de datos
            ///puede declarase estos tipos de forma implicita o explicta

            var myVar = 10; // Implicitly typed.
            int myVarTwo = 10; // Explicitly typed.
            uint myVarTwoU = 10; // Explicitly typed. UINT, solo maneja valores positivos

            var myChar = 'C';
            var mystring = "Hello world";
            var myInt = 12345;
            var myBoolean = false;
            var myFloat = 5.75123454567891234567F;  //6 o 7 digitos de presición
            var myDouble = 5.75123454567891234567D; //aproximadamente 15 digitos de presición
            var myDecimal = 5.75123454567891234567; //aproximadamente 15 digitos de presición
            var myStudent = new Student { Id = 1, Name = "Eduardo" };
            var myDate = DateTime.Now;

            Console.WriteLine($"Variable declaración implicita: {myVar}"); //Se pone el $, para poder escribir codigo dentro de la cadena
            Console.WriteLine($"Variable declaración explicia: {myVarTwo}");
            Console.WriteLine($"Variable tipo cadena: {mystring}");
            Console.WriteLine($"Variable tipo caracter: {myChar}");
            Console.WriteLine($"Variable tipo entero: {myInt}");
            Console.WriteLine($"Variable tipo flotante: {myFloat}");
            Console.WriteLine($"Variable tipo doble: {myDouble}");
            Console.WriteLine($"Variable tipo decimal: {myDecimal}");
            Console.WriteLine($"Variable tipo boleano: {myBoolean}");
            Console.WriteLine($"Variable de clasa: Id:{myStudent.Id} Nombre:{myStudent.Name}");
            Console.WriteLine($"Variable de clasa: Id:{myDate}");
            Console.WriteLine($"Variable de clasa: Id:{myVarTwoU}");

            ////Pueden asignarse variables con un tipo
            /// pero que tambien puedan teneruna asginación nula
            /// No aplica para todos los tipos

            int? myIntNulleable = null; //con el ?, nuestra variable puede obtener un valor NULL

            Console.WriteLine($"Variable tipo entero nulo: {myIntNulleable}");
            if (myIntNulleable == null)
            {
                Console.WriteLine($"Varabile nula");
            }
            //int result = myIntNulleable.Value / myInt;
            //Console.WriteLine($"resultado : {result}");

            myIntNulleable = 12;

            if (myIntNulleable.HasValue) //se pregunta si tiene valor
            {
                Console.WriteLine($"Variable tipo entero nulo: {myIntNulleable}");
                Console.WriteLine($"Variable tipo entero nulo: {myIntNulleable.Value}");
            }

            Console.ReadKey();



        }

        /// <summary>
        /// Ejemplo valor por referencia 
        /// </summary>
        private static void ReferenceAndValueTypesExample()
        {
            Console.WriteLine("-------------Valores-------------");
            //Los valores contienen directamente el valor del dato
            var myInt = 100;
            Console.WriteLine($"Valor original: {myInt}");
            ChangeValue(myInt);
            Console.WriteLine($"Valor original se mantiene: {myInt}");
            
            Console.WriteLine("-------------Referencia-------------");
            ChangeValue(ref myInt);
            Console.WriteLine($"Valor original cambia: {myInt}");

            increment(ref myInt);
            Console.WriteLine($"Valor despues del increment: {myInt}");
            var iRestIcncrement = incremetReturnValue(5);
            Console.WriteLine($"Valor multiplicado x 3: {iRestIcncrement}");
            /// Las variables mantienen los valores en espacio de memoria
            /// cuando pasamos una variable a otra instancia esta mantiene los valores
            /// en la nueva instacia por referencia de memoria            
            /// cuando el valor de la copia cambia tambien cambia el valor del original

            var myStudent = new Student { Id = 1, Name = "Eduardo" };
            Console.WriteLine($"Valor original: Id:{myStudent.Id} Nombre:{myStudent.Name}");
            //En este caso no es necesario poner 'ref', en la declaracion del metodo, ya que C#, de forma nativa, las clases las trata como referencias
            ChangeReference(myStudent);
            Console.WriteLine($"Valor original cambia: Id:{myStudent.Id} Nombre:{myStudent.Name}");


            Console.ReadKey();


        }

        public static void ChangeValue(int value)
        {

            value = 200;

            Console.WriteLine($"Valor de 'copia' cambia: {value}");

        }

        public static void ChangeValue(ref int value)
        {

            value = 200;

            Console.WriteLine($"Valor de 'copia' cambia: {value}");

        }

        public static void ChangeReference(Student studentParam)
        {

            studentParam.Id = 343;
            studentParam.Name = "Porfirio";

            Console.WriteLine($"Valor de 'copia' cambia: Id:{studentParam.Id} Nombre:{studentParam.Name}");

        }

        /// <summary>
        /// EJEMPLO CONCEPTO DE VALOR DE REFERNCIA
        /// </summary>
        public static void ReferenceValueExample()
        {

            var original = 9;
            Console.Write($"Valor actual de Original is {original}");
            Console.WriteLine(Environment.NewLine);
            // PALABRA RESERVADA ref apunta el valor a la referencia de memoria del paramentro de entrada
            increment(ref original);
            Console.WriteLine($"Ahora el nuevo valor de Original es {original}");
            Console.ReadLine();

        }

        /// <summary>
        /// METODO MODIFICA EL VALOR DEL PARAMETRO DE INGRESO
        /// NO RETORNA VALOR LO ALMACENA COMO REFERNCIA EN MEMORIA
        /// </summary>
        /// <param name="num">VALOR DE ENTRADA</param>
        public static void increment(ref int num)
        {
            num = num * num * num;
            //num = 521;
        }

        public static int incremetReturnValue(int num)
        {
            num *= 3;
            return num;
        }
        /// <summary>
        /// METODO EJEMPLO CONVERSION A NUMEROS
        /// </summary>
        public static void ConvertionsExample()
        {

            var numberChainOne = "121";
            var numberChainTow = '3';

            // USANDO CONVERT
            var numberOne = Convert.ToInt32(numberChainOne);
            var numberTow = Convert.ToInt16(numberChainTow);
            var sumResult = numberOne + numberTow;
            Console.WriteLine(sumResult);

            //USANDO LA ESTRCTURA
            //var numberOne = int.Parse(numberChainOne);
            //var numberTow = int.Parse(numberChainTow);
            //var sumResult = numberOne + numberTow;
            //Console.WriteLine(sumResult);

            //// USANDO TRY PARSE ERRONEO 
            //var numberChainThree = "323asdhfashg";
            //var numberThree = 0;
            //int.TryParse(numberChainThree, out numberThree);
            //Console.WriteLine(numberThree);
            //Console.ReadKey();


            // USANDO TRY PARSE CORRECTO
            var numberChainThree = "35646";
            var numberThree = 0;
            /// PALABRA RESERVADA out retorna y asigna el valor de la oeracion a la variable
            int.TryParse(numberChainThree, out numberThree);
            Console.WriteLine(numberThree);
            Console.ReadKey();


        }

        /// <summary>
        /// Es una asignación de un dato a otro tipo de dato
        /// </summary>
        public static void CastingExample()
        {
            var myDouble = 7676.57;

            // CASTING EXPLICITO
            var myInt = (int)myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            Console.ReadKey();

        }

        public static void StringsExample()
        {

            var myString = " Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean m   ";
            var myLabel = "EJEMPLO";
            //Console.WriteLine(myString.ToLower());
            //Console.WriteLine(myString.ToUpper());
            //Console.WriteLine(myString.Trim());

            // INTERPOLACIÓN $" Ejemplo de valor del texto es:{myString.Trim().ToUpper()}"
            Console.WriteLine($"Ejemplo de valor del texto es:{myString.Trim().ToUpper()}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Ejemplo de valor del texto es:{myString.ToUpper()} GFSFSGsadadsadas {myString}");
            Console.WriteLine(Environment.NewLine);
            // INTERPOLACION USANDO STRING FORMAT
            Console.WriteLine(string.Format("{0} {1}", myLabel, myString));
            Console.WriteLine(Environment.NewLine);

            var numberChainOne = "121";
            var numberChainTow = "323";

            Console.WriteLine($"RESULTADO : {Convert.ToInt32(numberChainOne) + Convert.ToInt32(numberChainTow) }");



            Console.ReadKey();


        }

        static void OutReferenceExample()
        {

            var area = 0;
            var perimeter = 0;

            area = CalculateArea(2, 4);
            perimeter = CalculatePerimeter(2, 4);

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro {perimeter}");
            Console.WriteLine(Environment.NewLine);


            // CALCULAR AREA Y PERIMETRO
            CalculateRect(5, 4, out area, out perimeter);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro {perimeter}");
            Console.WriteLine(Environment.NewLine);



            var analize = CalculateRectTow(5, 4, out area, out perimeter);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro {perimeter}");
            Console.WriteLine($"Altura es mayor al acncho: {analize}");
            Console.ReadLine();
        }

        /// <summary>
        /// Calcluar el area 
        /// </summary>
        /// <param name="len">altura</param>
        /// <param name="with">ancho</param>
        /// <returns></returns>
        public static int CalculateArea(int len, int with)
        {

            var areaC = len * with;
            return areaC;

        }

        public static int CalculatePerimeter(int len, int with)
        {
            var perimeterC = 2 * (len + with);
            return perimeterC;
        }

        //Accept two input parameter and returns two out value
        //son para metodos que regresan valores de salida y estos son distintos a los valores de entrada
        //Es diferente a los metodos que tienen valores de retorno
        public static void CalculateRect(int len, int width, out int area, out int perimeter) 
        {
            area = len * width;
            perimeter = 2 * (len + width);
        }

        //Accept two input parameter and returns two out value
        public static bool CalculateRectTow(int len, int width, out int area, out int perimeter)
        {
            area = len * width;
            perimeter = 2 * (len + width);

            return len > width;
        }

        public static void CicleExamples()
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // apuntador           0 ,1 ,2 ,3,4,5,6,7,8,9.....  
            // tamaño              numero de elementos del arreglo: 10                          

            ////FOR
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($" {numbers[i]}");
            //}

            //for (int i = 2; i < numbers.Length; i = i + 2)
            //{
            //    Console.WriteLine($"Position:{i} | value: {numbers[i]} | Length: {numbers.Length} ");
            //}

            ////FOREACH
            //var m = 0;
            //foreach (var item in numbers)
            //{
            //    m++;
            //    var module = item % 2;
            //    if (module > 0)
            //    {
            //        Console.WriteLine($"Position:{m} | Value: {item} | Length: {numbers.Length}");
            //    }
            //}


            //var t = 0;
            //while (t < numbers.Length)
            //{                
            //    Console.WriteLine($"Position:{t} | Value: {numbers[t]} | Length: {numbers.Length}");
            //    t++;
            //};


            Console.ReadKey();



        }


    }
}

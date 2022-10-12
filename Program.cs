/*Solicite al usuario que ingrese su nombre completo y guárdelo en una variable del tipo
correspondiente. Muestre por pantalla un saludo personalizado usando el nombre
almacenado. Se debe esperar que el usuario presione una tecla para finalizar programa*/

using System;

namespace EJ2_
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           
            string  Nombreing;
            Console.WriteLine(" *****BIENBENIDOOO***** ");
            Console.WriteLine("Por favor Ingrese su nombre: ");
            
            Nombreing= Console.ReadLine();
            Console.WriteLine ("Hola " + Nombreing);
            Console.ReadKey();



        }
    }
}

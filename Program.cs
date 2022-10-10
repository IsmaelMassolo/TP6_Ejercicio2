/*Solicite al usuario que ingrese su nombre completo y guárdelo
en una variable del tipo correspondiente. Muestre por pantalla un
saludo personalizado usando el nombre almacenado. Se debe esperar
que el usuario presione una tecla para finalizar programa.*/
using System;
using System.Threading;
namespace TpCSharpEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hola!");
            Thread.Sleep (3000);
            Console.Clear();
            string entrada = "";
            Console.WriteLine("A continuación ingrese su nombre completo");
            entrada=Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Que tal {0}?!, que tengas buen día!", entrada);
            
        }
    }
}
using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Ingrese un número");
            n = double.Parse(Console.ReadLine());

            if (n > 10)
                Console.WriteLine("Es mayor a 10");
            else
                Console.WriteLine("No es mayor a 10");              
        }
    }
}

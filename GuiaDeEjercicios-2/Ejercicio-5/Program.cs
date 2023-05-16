using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Ingrese un número");
            n = double.Parse(Console.ReadLine());           

            if (n % 2 == 0)
                Console.WriteLine("Es PAR");
            else
                Console.WriteLine("Es IMPAR"); 
        } 
    }         
}

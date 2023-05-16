using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Ingrese un número");
            n = double.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("Positivo");
            else if (n < 0 )
                Console.WriteLine("Negativo");   
            else 
                Console.WriteLine("Cero");  
        }
    }
}

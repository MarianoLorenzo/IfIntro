using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            if (n1 > 100)
                Console.WriteLine(n1 + " es mayor a 100");

            if (n2 > 100)
                Console.WriteLine(n2 + " es mayor a 100");

            if (n3 > 100)
                Console.WriteLine(n3 + " es mayor a 100");

            if (n4 > 100)
                Console.WriteLine(n4 + " es mayor a 100");            
        }
    }
}

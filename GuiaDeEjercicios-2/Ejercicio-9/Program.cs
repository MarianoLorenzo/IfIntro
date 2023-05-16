using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;

            Console.WriteLine("Ingrese cinco números distintos");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());
            n5 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
                Console.WriteLine("El mayor número es: " + n1);
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
                Console.WriteLine("El mayor número es: " + n2);
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
                Console.WriteLine("El mayor número es: " + n3);
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
                Console.WriteLine("El mayor número es: " + n4);
            else 
                Console.WriteLine("El mayor número es: " + n5);   

            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
                Console.WriteLine("El menor número es: " + n1);
            else if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
                Console.WriteLine("El menor número es: " + n2);
            else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
                Console.WriteLine("El menor número es: " + n3);
            else if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
                Console.WriteLine("El menor número es: " + n4);
            else 
                Console.WriteLine("El menor número es: " + n5); 
        }
    }
}

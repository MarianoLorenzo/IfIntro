using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Ingrese dos números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            if (n1 < n2)
                Console.WriteLine("El número menor es: " + n1);
            else if (n1 > n2)
                Console.WriteLine("El número menor es: " + n2);           
        }
    }
}

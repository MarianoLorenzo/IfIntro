using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Ingrese dos números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine("El número mayor es: " + n1);
            else if (n1 < n2)
                Console.WriteLine("El número mayor es: " + n2);   
            else 
                Console.WriteLine("Son iguales");  
        }
    }
}

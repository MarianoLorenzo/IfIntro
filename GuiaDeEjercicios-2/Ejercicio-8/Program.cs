using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números distintos");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4)
                Console.WriteLine("El número menor es: " + n1);
            else if (n2 < n1 && n2 < n3 && n2 < n4)
                Console.WriteLine("El número menor es: " + n2); 
            else if (n3 < n1 && n3 < n2 && n3 < n4)
                Console.WriteLine("El número menor es: " + n3);
            else 
                Console.WriteLine("El número menor es: " + n4);    
                   
        }
    }
}

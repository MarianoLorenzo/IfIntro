using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números distintos");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4)
                Console.WriteLine("El número mayor es: " + n1);
            else if (n2 > n1 && n2 > n3 && n2 > n4)
                Console.WriteLine("El número mayor es: " + n2);
            else if (n3 > n1 && n3 > n2 && n3 > n4)
                Console.WriteLine("El número mayor es: " + n3);  
            else 
                Console.WriteLine("El número mayor es: " + n4); 

        }
    }
}

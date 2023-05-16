using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;
            int contadorMayores = 0;          

            Console.WriteLine("Ingrese cuatro números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            if (n1 > 100)
                contadorMayores ++;

            if (n2 > 100)
                contadorMayores ++;

            if (n3 > 100)
                contadorMayores ++;

            if (n4 > 100)
                contadorMayores ++;

            if (contadorMayores == 0)
                Console.WriteLine("No hay números mayores a 100");
            else if (contadorMayores == 1)   
                Console.WriteLine(contadorMayores + " número es mayor que 100"); 
            else 
                Console.WriteLine(contadorMayores + " números son mayores que 100");

        }
    }
}

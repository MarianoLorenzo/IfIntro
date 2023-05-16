using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {           
            float n, horas;

            Console.WriteLine("Ingrese un valor expresado en minutos");
            n = int.Parse(Console.ReadLine());

            if (n > 60)
            {
                horas = n / 60;   
                Console.WriteLine("La cantidad de horas es " + horas.ToString("0.00"));   
            }
            else 
                Console.WriteLine("La cantidad de minutos es: " + n);               
        }
    }
}

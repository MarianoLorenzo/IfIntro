using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double importeVenta, importeFinal;

            Console.WriteLine("Ingrese el importe de la venta");
            importeVenta = double.Parse(Console.ReadLine());

            if (importeVenta < 1000)
                importeFinal = importeVenta;
            else if (importeVenta >= 1000 && importeVenta < 5000)
                importeFinal = importeVenta * 0.9;
            else
                importeFinal = importeVenta * 0.82;   

            Console.WriteLine("El importe final es: $" + importeFinal.ToString("0.00"));         
        }
    }
}

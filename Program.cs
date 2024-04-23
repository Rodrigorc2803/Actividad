using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneradorDeNumero generadorFibonacci = new GeneradorFibonacci();
            GeneradorDeNumero generadorPrimo = new GeneradorPrimoYPerfecto(true);
            GeneradorDeNumero generadorPerfecto = new GeneradorPrimoYPerfecto(false);

            while (true)
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Encontrar el término n de Fibonacci");
                Console.WriteLine("2. Encontrar el primo número n");
                Console.WriteLine("3. Encontrar el número perfecto n");
                Console.WriteLine("4. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 4) break;

                Console.WriteLine("Introduce el valor de n:");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"El término {n} de Fibonacci es {generadorFibonacci.ObtenerNumero(n)}");
                        break;
                    case 2:
                        Console.WriteLine($"El primo número {n} es {generadorPrimo.ObtenerNumero(n)}");
                        break;
                    case 3:
                        Console.WriteLine($"El número perfecto {n} es {generadorPerfecto.ObtenerNumero(n)}");
                        break;
                }
            }

        }
    }
}

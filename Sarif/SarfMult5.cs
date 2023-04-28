using System;
using System.Numerics;

namespace ADA
{
    class Program
    {
        static int Preguntar()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static void Main(string[] args)
        {
            int suma = 0;
            // Mostrar multiplos de 5
            int numero = Preguntar();
            for (int i = 1; i <= numero; i++)
            {
                int vuelta = 5 * i;
                Console.Write(vuelta + " ");
                // Sumar 
                suma += vuelta;
            }

            Console.WriteLine();
            Console.WriteLine("Suma: " + suma);
        }
    }
}

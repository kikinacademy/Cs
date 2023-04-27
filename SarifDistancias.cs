using System;

namespace ADA
{
    class Program
    {
        static void Preguntar()
        {
            Console.Write("Escribe coordenada X para punto 1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe coordenada Y para punto 1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Escribe coordenada X para punto 2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Escribe coordenada Y para punto 2: ");
            int y2 = int.Parse(Console.ReadLine());

            double resultado = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);

            Console.WriteLine("Resultado: " + resultado);
        }

        static void Main(string[] args)
        {
            // Preguntar coordenadas
            Preguntar();
        }
    }
}

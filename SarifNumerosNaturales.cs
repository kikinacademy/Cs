using System;

namespace ADA
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Opciones");
            Console.WriteLine("1) Factorial");
            Console.WriteLine("2) Promedio entre 1 y n");
            Console.WriteLine("3) Promedio pares entre 1 y n");
            Console.Write("Ingresa tu opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static int Numero()
        {
            Console.Write("Ingresa tu número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static void Factorial(int numero)
        {
            int factorial = 1;
            Console.WriteLine("\nFactorial ");
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Resultado " + factorial);
        }

        static void Promedio(int numero)
        {
            Console.WriteLine("\nPromedio entre 1 y n ");
            int suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            int resultado = suma / numero;
            Console.WriteLine("Resultado " + resultado);
        }

        static void PromedioPares(int numero)
        {
            Console.WriteLine("\nPromedio pares entre 1 y n ");
            int suma2 = 0;
            int pares = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    suma2 += i;
                    pares++;
                }
            }

            int resultado2 = suma2 / pares;
            Console.WriteLine("Resultado " + resultado2);
        }
        
        static void Main(string[] args)
        {
            int opcion = Menu();
            int numero = Numero();
            
            switch (opcion)
            {
                case 1:
                {
                    Factorial(numero);
                    break;
                }
                case 2:
                {
                    Promedio(numero);
                    break;
                }
                case 3:
                    PromedioPares(numero);
                    break;
                default:
                {
                    Console.WriteLine("Default ");
                    break;
                }
            }
        }
    }
}

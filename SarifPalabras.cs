using System;

namespace ADA
{
    class Program
    {
        static string Palabra()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            return palabra;
        }

        static void ChecarInicial(string palabra)
        {
            palabra = palabra.ToLower();
            char inicial = palabra[0];
            
            switch (inicial)
            {
                case 'a':
                    Console.WriteLine("La palabra empieza con A");
                    break;
                case 'e':
                    Console.WriteLine("La palabra empieza con E");
                    break;
                case 'i':
                    Console.WriteLine("La palabra empieza con I");
                    break;
                case 'o':
                    Console.WriteLine("La palabra empieza con O");
                    break;
                case 'u':
                    Console.WriteLine("La palabra empieza con U");
                    break;
                default:
                    Console.WriteLine("No inicia con vocal");
                    break;
            }
        }
        
        static void ChecarTamano(string palabra)
        {
            int tamano = palabra.Length;
            Console.WriteLine($"La palabra tiene {tamano} letras");
        }

        static void Main(string[] args)
        {
            // informar con que vocal empieza la palabra y cuantas letras tiene
            string palabra = Palabra();

            ChecarInicial(palabra);
            ChecarTamano(palabra);

        }
    }
}

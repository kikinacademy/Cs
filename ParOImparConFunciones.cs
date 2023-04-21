using System;

class Program
{
    static void Main()
    {
        int opcion = 1;
        while (opcion != 0) // Ciclo que se repite mientras la opción no sea 0
        {
            opcion = Menu(); // Función Menu() para mostrar el menú y leer la opción seleccionada por el usuario
            switch (opcion) // Switch para determinar qué acción tomar según la opción seleccionada
            {
                case 1: // Si la opción es 1, se pide al usuario que ingrese un número y se llama a la función EsPar() para determinar si es par o impar
                    Console.Write("Ingresa un número: ");
                    int num = int.Parse(Console.ReadLine());
                    if (EsPar(num))
                    {
                        Console.WriteLine("El número es par.");
                    }
                    else
                    {
                        Console.WriteLine("El número es impar.");
                    }
                    break;
                case 0: // Si la opción es 0, se muestra un mensaje y se sale del programa
                    Console.WriteLine("Saliendo...");
                    break;
                default: // Si la opción es otra, se muestra un mensaje de error
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static int Menu()
    {
        Console.WriteLine("MENU"); // Se muestra el menú en la consola
        Console.WriteLine("1. Par o impar");
        Console.WriteLine("0. Salir");
        Console.Write("Selecciona tu opción: ");
        int opcion = int.Parse(Console.ReadLine()); // Se lee la opción seleccionada por el usuario
        return opcion; // Se devuelve la opción
    }

    static bool EsPar(int num)
    {
        return num % 2 == 0; // Se devuelve true si el número es par y false si es impar
    }
}

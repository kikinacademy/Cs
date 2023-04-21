// Solicita al usuario ingresar el número de nombres
Console.Write("Número de nombres: ");
int num_nombres = int.Parse(Console.ReadLine());

// Verifica que el número ingresado sea válido
if (num_nombres <= 0)
{
    Console.WriteLine("Error: debe ingresar un número positivo.");
}
else
{
    // Crea un arreglo de cadenas para almacenar los nombres
    String[] nombres = new String[num_nombres];

    // Solicita al usuario ingresar cada uno de los nombres y los almacena en el arreglo
    for (int i = 0; i < num_nombres; i++)
    {
        Console.Write($"Nombre {i + 1}: ");
        String nombre = Console.ReadLine();
        nombres[i] = nombre;
    }

    // Crea un arreglo de enteros para almacenar las longitudes de cada nombre
    int[] longitudes = new int[num_nombres];

    // Obtiene la longitud de cada nombre y la almacena en el arreglo de longitudes
    for (int i = 0; i < num_nombres; i++)
    {
        String nombre = nombres[i];
        int longitud = nombre.Length;
        longitudes[i] = longitud;
    }

    // Inicializa variables para comparar las longitudes y encontrar el nombre más largo
    int posicion = 0;
    int long_actual = 0;
    int longitud_sig = 0;

    // Compara cada longitud con la longitud del siguiente nombre y actualiza la posición del nombre más largo
    for (int i = 0; i < num_nombres - 1; i++)
    {
        long_actual = longitudes[i];
        longitud_sig = longitudes[i + 1];

        if (long_actual < longitud_sig)
        {
            posicion = i + 1;
        }
    }

    // Muestra el nombre más largo y su longitud
    Console.WriteLine($"El nombre más largo es: {nombres[posicion]}, con {longitudes[posicion]} letras");
}

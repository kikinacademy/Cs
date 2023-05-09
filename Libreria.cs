namespace ADA
{
    class Program
    {
        /*
        Para cada libro quiere capturar los siguientes datos:
        Nombre: alfanumérico máximo 50 posiciones
        Código ISBN-10: numérico de 10 posiciones
        Código ISBN-13: numérico de 13 posiciones
        Precio de lista: numérico con 2 decimales
        Costo del librto: numérico con 2 decimales
        Existencia actual: numérico sin decimales
        Venta exclusiva: boolean
         */
        struct Libro
        {
            public string? Nombre = "";
            public int Isbn10;
            public int Isbn13; // NEVER USED
            public float PrecioLista;
            public float CostoLibro;
            public int ExistenciaActual;
            public bool VentaExclusiva = false; // NEVER USED

            public Libro()
            {
            }
        }

        /*
        Para cada librería quiere capturar los siguientes datos:
        Razón social: alfanumérico de 100 posiciones
        RFC: alfanumérico de 13 posiciones
        Calle y número alfanumérico de 80 posiciones
        Colonia alfanumérico de 60 posiciones
        Municipio alfanumérico de 50 posiciones
        CP numérico de 5 posiciones
         */
        struct Libreria
        {
            public char[] RazonSocial = new char[100]; // NEVER USED
            public char[] Rfc = new char[13]; // NEVER USED
            public char[] CalleNumero = new char[80]; // NEVER USED
            public char[] Colonia = new char[60]; // NEVER USED
            public char[] Municipio = new char[50]; // NEVER USED
            public int Cp; // NEVER USED
            public List<Libro> Inventario = new List<Libro>(); 

            public Libreria()
            {
            }

            public void CapturarInventario()
            {

                Console.WriteLine("Captura de inventario");
                Console.Write("Cantidad de libros a capturar: ");
                int cantidad = int.Parse(Console.ReadLine() ?? string.Empty);
                for (int i = 0; i < cantidad; i++)
                {
                    Libro temporal = new Libro();
                    Console.Write("Nombre: ");
                    temporal.Nombre = Console.ReadLine();
                    Console.Write("ISBN-10: ");
                    temporal.Isbn10 = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("ISBN-13: ");
                    temporal.Isbn13 = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Precio de lista: ");
                    temporal.PrecioLista = float.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Costo del libro: ");
                    temporal.CostoLibro = float.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Existencia actual: ");
                    temporal.ExistenciaActual = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Venta exclusivaa (1 SI, 0 NO): ");
                    int bol = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (bol == 1) temporal.VentaExclusiva = true;
                    else temporal.VentaExclusiva = false;

                    Inventario.Add(temporal);
                }
            }

            public void AjustarInventario()
            {
                Console.WriteLine("Ajuste de inventario");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine() ?? String.Empty);
                for (int i = 0; i < Inventario.Count; i++)
                {
                    if (isbn10 == Inventario[i].Isbn10)
                    {
                        Libro temporal = Inventario[i];
                        Console.WriteLine("Libro encontrado");
                        Console.Write("Ingresa la cantidad de ejemplares de este libro: ");
                        int cantidad = int.Parse(Console.ReadLine()?? String.Empty);
                        temporal.ExistenciaActual = cantidad;
                        Inventario[i] = temporal;
                        break;
                    }
                }
            }

            public void AjustarPrecio()
            {
                Console.WriteLine("Ajuste de precio");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine()?? String.Empty);
                for (int i = 0; i < Inventario.Count; i++)
                {
                    if (isbn10 == Inventario[i].Isbn10)
                    {
                        Libro temporal = Inventario[i];
                        Console.WriteLine("Libro encontrado");
                        Console.Write("Ingresa el nuevo precio de este libro: ");
                        int precio = int.Parse(Console.ReadLine() ?? string.Empty);
                        temporal.PrecioLista = precio;
                        Inventario[i] = temporal;
                        break;
                    }
                }
            }

            public void ReporteInventario()
            {
                Console.WriteLine("Reporte de lista de libros");
                Console.WriteLine("Nombre\tExistencia\tCosto\tPrecio");
                foreach (var libro in Inventario)
                {
                    Console.WriteLine($"{libro.Nombre}\t{libro.ExistenciaActual}\t{libro.CostoLibro}\t{libro.PrecioLista}");
                }
            }

            public void VentaMostrador()
            {
                Console.WriteLine("Venta de mostrador");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine() ?? string.Empty);
                for (int i = 0; i < Inventario.Count; i++)
                {
                    if (isbn10 == Inventario[i].Isbn10)
                    {
                        Libro temporal = Inventario[i];
                        Console.WriteLine("Libro encontrado");
                        temporal.ExistenciaActual--;
                        Inventario[i] = temporal;

                        Console.WriteLine("Venta realizada");
                        Console.WriteLine($"Total pagado por el libro {temporal.Nombre} es de {temporal.PrecioLista}");
                        break;
                    }
                }
            }
        }

        static void Menu()
        {
            bool libreriaExiste = true; bool capturados = false;
            Libreria libreria = new Libreria();
            int opcion;
            do
            {
                Console.WriteLine("Menu principál");
                Console.WriteLine("1) Captura de inventario");
                Console.WriteLine("2) Ajuste de inventario"); // CANTIDAD DE LIBRO
                Console.WriteLine("3) Ajuste de precio"); // PRECIO DE LIBRO
                Console.WriteLine("4) Reporte de inventario"); // Lista con existencia, costo y precio
                Console.WriteLine("5) Captura de datos de librería");
                Console.WriteLine("6) Venta al mostrador"); // Realiza venta, genera ticket, afecta inventario
                Console.WriteLine("7) Salir del programa");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine() ?? string.Empty);

                switch (opcion)
                {
                    case 1:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }
                        if(capturados)
                        {
                            Console.WriteLine("Ya se capturó el inventario.");
                            break;
                        }
                        libreria.CapturarInventario();
                            capturados = true;
                        break;
                    }
                    case 2:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        libreria.AjustarInventario();
                        break;
                    }
                    case 3:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        libreria.AjustarPrecio();
                        break;
                    }
                    case 4:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        libreria.ReporteInventario();
                        break;
                    }
                    case 5:
                    {
                        if (libreriaExiste)
                        {
                            Console.WriteLine("Ya existe una librería registrada.");
                            break;
                        }

                        libreria = CapturarDatosLibreria();
                        libreriaExiste = true;
                        break;
                    }
                    case 6:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        libreria.VentaMostrador();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                    }
                }
            } while (opcion != 7);
        }

        private static Libreria CapturarDatosLibreria()
        {
            Console.WriteLine("Capturar datos de librería");
            Libreria libreria = new Libreria();

            Console.Write("Razón social: ");
            libreria.RazonSocial = Console.ReadLine()!.ToCharArray();
            Console.Write("RFC: ");
            libreria.Rfc = Console.ReadLine()!.ToCharArray();
            Console.Write("Calle y Número: ");
            libreria.CalleNumero = Console.ReadLine()!.ToCharArray();
            Console.Write("Colonia: ");
            libreria.Colonia = Console.ReadLine()!.ToCharArray();
            Console.Write("Municipio: ");
            libreria.Municipio = Console.ReadLine()!.ToCharArray();
            Console.Write("CP: ");
            libreria.Cp = int.Parse(Console.ReadLine() ?? string.Empty);

            return libreria;
        }

        static void Main()
        {
            Menu();
        }
    }
}

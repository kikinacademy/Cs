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
            public string Nombre = string.Empty;
            public int Isbn10 = 0;
            public int Isbn13 = 0; // NEVER USED
            public float PrecioLista = 0;
            public float CostoLibro = 0;
            public int ExistenciaActual = 0;
            public bool VentaExclusiva = false; // NEVER USED

            public Libro() // EACH TIME YOU CREATE A BOOK, IT GETS DEFAULT VALUES
            {
                Nombre = string.Empty;
                Isbn10 = 0;
                Isbn13 = 0;
                PrecioLista = 0;
                CostoLibro = 0;
                ExistenciaActual = 0;
                VentaExclusiva = false;
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
            public int Cp = 0; // NEVER USED
            public List<Libro> Inventario = new List<Libro>();

            public Libreria() // DEFAULT CONSTRUCTOR, WHEN WE CREATE A NEW LIBRARY
            {
                RazonSocial = new char[100];
                Rfc = new char[13];
                CalleNumero = new char[80];
                Colonia = new char[60];
                Municipio = new char[50];
                Cp = 0;
                Inventario = new List<Libro>();
            }

            public void CapturarInventario()
            {
                Console.WriteLine("Captura de inventario");
                Console.Write("Cantidad de libros a capturar: "); // HOW MANY TIMES DOES THE CYCLE WILL REPEAT?
                int cantidad = int.Parse(Console.ReadLine() ?? string.Empty);
                for (int i = 0; i < cantidad; i++) // FOR EACH BOOK, CREATE EMPTY BOOK (DEFAULT CONSTRUCTOR)
                {
                    Libro temporal = new Libro();

                    Console.Write("Nombre: "); // START FILLING LIBRARY INSTANCE
                    temporal.Nombre = Console.ReadLine(); // ASIGN OBTAINED VALUE TO FIELD
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

                    Inventario.Add(temporal); // ADD OBJECT (BOOK) INSTANCE TO LIST
                }
            }

            public void AjustarInventario()
            {
                Console.WriteLine("Ajuste de inventario");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine() ?? String.Empty); // ASKS FOR BOOK ISBN10
                for (int i = 0; i < Inventario.Count; i++) // SEARCH IN THE COMPLETE LIST - LINEAR SEARCH (BARRIDO)
                {
                    if (isbn10 == Inventario[i].Isbn10) // IF ISBN10 FROM BOOK (CURRENT) MATCHES SEARCHED ISBN10 (COMPROBACIÓN)
                    {
                        Libro temporal = Inventario[i]; // SAVE BOOK IN TEMP TO MAKE CHANGES
                        Console.WriteLine("Libro encontrado");
                        Console.Write("Ingresa la cantidad de ejemplares de este libro: ");  // ADJUST QUANTITY
                        int cantidad = int.Parse(Console.ReadLine() ?? String.Empty);
                        temporal.ExistenciaActual = cantidad;
                        Inventario[i] = temporal; // REPLACE OLD BOOK WITH NEW ONE
                        break;
                    }
                }
            }

            public void AjustarPrecio()
            {
                Console.WriteLine("Ajuste de precio");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine() ?? String.Empty); // ASKS FOR BOOK ISBN10
                for (int i = 0; i < Inventario.Count; i++) // SEARCH IN THE COMPLETE LIST - LINEAR SEARCH (BARRIDO)
                {
                    if (isbn10 == Inventario[i].Isbn10) // IF ISBN10 FROM BOOK (CURRENT) MATCHES SEARCHED ISBN10 (COMPROBACIÓN)
                    {
                        Libro temporal = Inventario[i]; // SAVE BOOK IN TEMP TO MAKE CHANGES
                        Console.WriteLine("Libro encontrado");
                        Console.Write("Ingresa el nuevo precio de este libro: ");  // ADJUST PRICE
                        int precio = int.Parse(Console.ReadLine() ?? string.Empty);
                        temporal.PrecioLista = precio;
                        Inventario[i] = temporal; // REPLACE OLD BOOK WITH NEW ONE
                        break;
                    }
                }
            }

            public void ReporteInventario()
            {
                Console.WriteLine("Reporte de lista de libros");
                Console.WriteLine("Nombre\tExistencia\tCosto\tPrecio"); //\t GIVES HORIZONTAL WHITESPACE (TAB)
                foreach (var libro in Inventario) // LOOP IN ALL BOOKS (BARRIDO POR ELEMENTO)
                {
                    Console.WriteLine(
                        $"{libro.Nombre}\t{libro.ExistenciaActual}\t{libro.CostoLibro}\t{libro.PrecioLista}"); // SHOW DETAILS NEEDED FOR EACH BOOK
                }
            }

            public void VentaMostrador()
            {
                Console.WriteLine("Venta de mostrador");
                Console.Write("Ingresa el ISBN-10 del libro: ");
                int isbn10 = int.Parse(Console.ReadLine() ?? string.Empty); // ASKS FOR BOOK ISBN10
                for (int i = 0; i < Inventario.Count; i++) // SEARCH IN THE COMPLETE LIST - LINEAR SEARCH (BARRIDO)
                {
                    if (isbn10 == Inventario[i].Isbn10) // IF ISBN10 FROM BOOK (CURRENT) MATCHES SEARCHED ISBN10 (COMPROBACIÓN)
                    {
                        Libro temporal = Inventario[i]; // SAVE BOOK IN TEMP TO MAKE CHANGES
                        Console.WriteLine("Libro encontrado");
                        temporal.ExistenciaActual--; // TAKE 1 FROM INVENTORY
                        Inventario[i] = temporal; // REPLACE OLD BOOK WITH NEW ONE

                        Console.WriteLine("Venta realizada");
                        Console.WriteLine($"Total pagado por el libro {temporal.Nombre} es de {temporal.PrecioLista}"); // SHOW BOOK ORDER DETAILS
                        break;
                    }
                }
            }
        }

        static void Menu()
        {
            bool libreriaExiste = true; // CHECK IF THERE IS A LIBRARY CREATED
            bool capturados = false; // CHECK IF THERE ARE BOOKS IN STOCK
            Libreria libreria = new Libreria(); // LIBRARY STUCTURE CONTAINS A LIST OF BOOKS (ESTRUCTURA ANIDADA POR UNA LISTA)
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
                opcion = int.Parse(Console.ReadLine() ?? string.Empty); // CHOOSE OPTION

                switch (opcion) // ACCORDING TO THE OPTION SELECTED
                {
                    case 1:
                    {
                        if (!libreriaExiste)  // CHECKS FOR LIBRARY (IF libreriaExiste == FALSE) / LO MISMO QUE (IF libreriaExiste DIFERENTE DE VERDADERO)
                            {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        if (capturados) // IF YOU ALREADY ADD BOOKS TO STOCK, SHOW MESSAGE AND EXIT
                        {
                            Console.WriteLine("Ya se capturó el inventario.");
                            break;
                        }

                        libreria.CapturarInventario();
                        capturados = true; // CHANGE FLAG VARIABLE FOR STOCK
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

                        libreria = CapturarDatosLibreria(); // RETURNS A LIBRARY WHICH WILL BE USED IN THE PROGRAM, NEED TO BE THE FIRST EXECUTED
                        libreriaExiste = true; // CHANGE FLAG VARIABLE WHICH ALLOWS ALL OTHER OPTIONS TO BE USED
                        break;
                    }
                    case 6:
                    {
                        if (!libreriaExiste)
                        {
                            Console.WriteLine("No existe una librería registrada.");
                            break;
                        }

                        libreria.VentaMostrador(); // BUY 1 BOOK OF THE CHOSEN ONE
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("Saliendo del programa..."); // EXITING PROGRAM
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Opción inválida, intente de nuevo."); // DEFAULT CASE IF NOT A VALID OPTION
                        break;
                    }
                }
            } while (opcion != 7); // LOOP GOES ON WHILE YOU DO NOT EXIT (CHOOSE 7)
        }

        private static Libreria CapturarDatosLibreria() // FUNCTION THAT RETURNS A LIBRARY INSTANCE
        {
            Console.WriteLine("Capturar datos de librería");
            Libreria libreria = new Libreria(); // CREATES EMPY LIBRARY

            Console.Write("Razón social: "); // FILLS DATA
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

            return libreria; // SEND FILLED OUT LIBRARY TO INVOCATION
        }

        static void Main()
        {
            Menu(); // CLEAN MAIN ONLY CALLING MENU METHOD
        }
    }
}

/*En C#, un constructor es un metodo especial que se utiliza para inicializar objetos de una clase. Se define dentro de la clase y tiene el mismo nombre que la clase. Cuando se crea una instancia de la clase mediante la palabra clave new, el constructor se invoca automáticamente y se utiliza para realizar cualquier inicialización necesaria antes de que el objeto esté listo para ser utilizado.

Un constructor puede aceptar parámetros, lo que permite proporcionar valores iniciales para las propiedades o campos de la clase. También puede haber varios constructores definidos en una clase, cada uno con una lista de parámetros diferente. Esto se conoce como sobrecarga de constructores.

EN ESTE CASO, EN LUGAR DE CLASE ES UNA ESTRUCTURA

CLASE / ESTRUCTURA ES LA PLANTILLA (ABSTRACTO)
OBJETO / INSTANCIA ES YA UN REGISTRO DE ESA PLANTILLA
 */

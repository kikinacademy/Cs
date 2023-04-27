using System;

namespace ADA
{
    class Program
    {
        static void CalificacionTotal(string[] materias)
        {
            int[] calificaciones = new int[materias.Length];
            int suma = 0;
            Console.WriteLine();
            for (int i = 0; i < materias.Length; i++)
            {
                Console.Write("¿Cuál es tu calificación en " + materias[i] + "?");
                calificaciones[i] = int.Parse(Console.ReadLine());
                suma += calificaciones[i];
            }

            int promedio = suma / materias.Length;
            Console.WriteLine("Tu promedio es: " + promedio);
            if (promedio < 6)
            {
                Console.WriteLine("Reprobaste");
            }
            else if (promedio >= 6 && promedio < 9)
            {
                Console.WriteLine("Aprobaste");
            }
            else
            {
                Console.WriteLine("Sobresaliente");
            }
        }

        static void NombreYMaterias()
        {
            Console.WriteLine("Mi nombre es: Sarif ");
            string[] materias = { "Fisica", "Quimica", "Algoritmos", "Calculo", "Historia", "Algebra" };
            for (int i = 0; i < materias.Length; i++)
            {
                Console.Write(materias[i] + ", ");
            }

            CalificacionTotal(materias);
        }

        static void Main(string[] args)
        {
            // 1) Mostrar tu nombre y nombre de las materias cursadas este semestre
            // 2) Preguntar calificacion obtenida en cada materia y calcular promedio
            // 3) Preguntar cada calificacion parcial para cada materia e informar si el promedio es reprobatorio (menor a 6), aprobadotio (mayor o igual a 6 y menor a 9) o sobresaliente (mayor o igual a 9)

            NombreYMaterias();
        }
    }
}

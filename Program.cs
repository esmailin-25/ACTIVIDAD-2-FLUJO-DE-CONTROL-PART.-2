using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            double nota1, nota2, nota3, nota4, promedio;
            string nombre, estatus;

            Console.Write("Digite la cantidad de estudiantes: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nombre\t\tNota1\tNota2\tNota3\tNota4\tPromedio\tEstatus");

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("\nEstudiante #" + i);

                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Nota 1: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 2: ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 3: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 4: ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                if (promedio >= 70)
                {
                    estatus = "Aprobado";
                }
                else
                {
                    estatus = "Reprobado";
                }

                Console.WriteLine(nombre + "\t\t" +
                                  nota1 + "\t" +
                                  nota2 + "\t" +
                                  nota3 + "\t" +
                                  nota4 + "\t" +
                                  promedio + "\t\t" +
                                  estatus);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

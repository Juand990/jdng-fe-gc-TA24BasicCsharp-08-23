using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = { { 5, 5, 7 },
                             { 3, 7, 6 },
                             { 8, 8, 8 },
                             { 10, 5, 5 },
                             { 1, 3, 4 },
            };

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.WriteLine("Introduce notas del alumno entre 0-10: ");
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.Write("Notas alumno : ");
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write(notas[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                double media = 0;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media = media + notas[i, j];

                }
                if ((media/3)>=5)
                {
                    Console.WriteLine("Alumno "+i+": "+ "APROBADO.");
                }
                else
                {
                    Console.WriteLine("Alumno " + i + ": " + "NO APROBADO.");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 5;
            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Altura de la piramide??");
            int piramide = int.Parse(Console.ReadLine());
            for (int linea = 0, asc = (piramide * 2) - 1; asc > 0; linea++, asc = asc - 2)
            {
                for (int i = 0; i < linea; i++)
                {
                    Console.Write(" ");
                }
                for (int j = asc; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

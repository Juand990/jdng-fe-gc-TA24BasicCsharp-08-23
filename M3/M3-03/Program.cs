using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero:");
            //int N = int.Parse(Console.ReadLine());
            int N = 20;
            int cero = 0;
            int uno = 1;
            Console.WriteLine(cero + ",");
            for (int i = 0; i < N; i++)
            {
                int tmp = cero;
                cero = uno;
                uno = tmp + cero;

                Console.WriteLine(cero + ",");
            }
            Console.ReadKey();
        }
    }
}

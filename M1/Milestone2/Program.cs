using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 1.1234;
            int numeroInt = 10;
            float numeroFloat = 1.5f;
            string numeroString = "50";
            Console.WriteLine("Int a Double: "+ Convert.ToDouble(numeroInt));
            Console.WriteLine("Float a Double: " + Convert.ToDouble(numeroFloat));
            Console.WriteLine("String a Double: " + Convert.ToDouble(numeroString));
            Console.ReadKey();
        }
    }
}

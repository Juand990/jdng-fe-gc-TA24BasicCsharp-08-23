using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10 };

            for (int i = 0; i < array.Length/2; i++)
            {
                int tmp = array[i];
                array[i]= array[array.Length - 1-i];                                     
                array[array.Length - 1-i] = tmp;               
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array "+i+": " + array[i]);
            }
            Console.ReadKey();
        }
    }
}

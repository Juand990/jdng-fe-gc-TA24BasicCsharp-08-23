using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FASE 1
            //string st1 = "Barcelona";
            //string st2 = "Madrid";
            //string st3 = "Valencia";
            //string st4 = "Malaga";
            //string st5 = "Cadis";
            //string st6 = "Santander";
            Console.WriteLine("Introduce por teclado estas ciudades de 1 en 1: Barcelona, Madrid, Valencia, Malaga, Cadis, Santander.");
            string st1 = Console.ReadLine();
            string st2 = Console.ReadLine();
            string st3 = Console.ReadLine();
            string st4 = Console.ReadLine();
            string st5 = Console.ReadLine();
            string st6 = Console.ReadLine();
            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine(st4);
            Console.WriteLine(st5);
            Console.WriteLine(st6);
            Console.WriteLine("---------------------");
            //FASE 2
            string[] arrCiudades = { st1, st2, st3, st4, st5, st6 };
            Array.Sort(arrCiudades);
            for (int i = 0; i < arrCiudades.Length; i++)
            {
                Console.WriteLine(arrCiudades[i]);
            }
            Console.WriteLine("---------------------");
            //FASE 3
            string[] arrCiudadesModificadas = new string[arrCiudades.Length];
            string cambio = "";

            for (int i = 0; i < arrCiudades.Length; i++)
            {
                cambio = "";
                for (int j = 0; j < arrCiudades[i].Length; j++)
                {
                    if (arrCiudades[i][j] == 'a')
                    {
                        cambio = cambio + "4";
                    }
                    else
                    {
                        cambio = cambio + arrCiudades[i][j];
                    }
                }
                arrCiudadesModificadas[i] = cambio;
            }
            Array.Sort(arrCiudadesModificadas);
            for (int i = 0; i < arrCiudadesModificadas.Length; i++)
            {
                Console.WriteLine(arrCiudadesModificadas[i]);
            }
            Console.WriteLine("---------------------");
            //FASE 4
            string[] ciudad1 = new string[st1.Length];
            string[] ciudad2 = new string[st2.Length];
            string[] ciudad3 = new string[st3.Length];
            string[] ciudad4 = new string[st4.Length];
            string[] ciudad5 = new string[st5.Length];
            string[] ciudad6 = new string[st6.Length];
            string[,] notas = new string[3, 5];
            int letra = st1.Length - 1;
            //Barcelona
            for (int i = 0; i < ciudad1.Length; i++)
            {
                ciudad1[i] = st1[letra].ToString();
                letra--;
            }
            Console.Write(st1 + ": ");
            for (int i = 0; i < ciudad1.Length; i++)
            {
                Console.Write(ciudad1[i]);
            }
            Console.WriteLine();
            //Madrid
            letra = st2.Length - 1;
            for (int i = 0; i < ciudad2.Length; i++)
            {
                ciudad2[i] = st2[letra].ToString();
                letra--;
            }
            Console.Write(st2 + ": ");
            for (int i = 0; i < ciudad2.Length; i++)
            {
                Console.Write(ciudad2[i]);
            }
            Console.WriteLine();
            //Valencia
            letra = st3.Length - 1;
            for (int i = 0; i < ciudad3.Length; i++)
            {
                ciudad3[i] = st3[letra].ToString();
                letra--;
            }
            Console.Write(st3 + ": ");
            for (int i = 0; i < ciudad3.Length; i++)
            {
                Console.Write(ciudad3[i]);
            }
            Console.WriteLine();
            //Malaga
            letra = st4.Length - 1;
            for (int i = 0; i < ciudad4.Length; i++)
            {
                ciudad4[i] = st4[letra].ToString();
                letra--;
            }
            Console.Write(st4 + ": ");
            for (int i = 0; i < ciudad4.Length; i++)
            {
                Console.Write(ciudad4[i]);
            }
            Console.WriteLine();
            //Cadis
            letra = st5.Length - 1;
            for (int i = 0; i < ciudad5.Length; i++)
            {
                ciudad5[i] = st5[letra].ToString();
                letra--;
            }
            Console.Write(st5 + ": ");
            for (int i = 0; i < ciudad5.Length; i++)
            {
                Console.Write(ciudad5[i]);
            }
            Console.WriteLine();
            //Santander
            letra = st6.Length - 1;
            for (int i = 0; i < ciudad6.Length; i++)
            {
                ciudad6[i] = st6[letra].ToString();
                letra--;
            }
            Console.Write(st6 + ": ");
            for (int i = 0; i < ciudad6.Length; i++)
            {
                Console.Write(ciudad6[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // FASE 1
            string nom = "Nombre";
            string cognom1 = "Apellido1";
            string cognom2 = "Apellido2";
            int dia = 20;
            int mes = 6;
            int any = 1990;
            Console.WriteLine(nom + " " + cognom1 + " " + cognom2);
            Console.WriteLine(dia + "/" + mes + "/" + any);
            // FASE 2
            const int traspas = 1948;
            List<int> anysTraspas = new List<int>();
            for (int i = traspas; i <= any; i++)
            {
                if (i % 100 != 0)
                {
                    if (i % 4 == 0 || i % 400 == 0)
                    {
                        anysTraspas.Add(i);
                        Console.WriteLine(i);
                    }
                }
            }
            // FASE 3
            bool naixementTraspas = false;
            string naixementNo = "El meu any de naixement NO és de traspàs.";
            string naixementSi = "El meu any de naixement és de traspàs.";
            if (any % 100 != 0)
            {
                if (any % 4 == 0 || any % 400 == 0)
                {
                    naixementTraspas = true;
                    Console.WriteLine(naixementSi);
                }
                else
                {
                    Console.WriteLine(naixementNo);
                }
            }
            else
            {
                Console.WriteLine(naixementNo);
            }
            // FASE 4
            string nomCognoms = nom + " " + cognom1 + " " + cognom2;
            string diaMesAny = dia + "/" + mes + "/" + any;
            Console.WriteLine("El meu nom és " + nomCognoms);
            Console.WriteLine("Vaig néixer el " + diaMesAny);
            if (naixementTraspas)
            {
                Console.WriteLine(naixementSi);
            }
            else
            {
                Console.WriteLine(naixementNo);
            }
            Console.ReadKey();
        }
    }
}


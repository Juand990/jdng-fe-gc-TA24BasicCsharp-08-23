using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FASE 1
            char[] nombre = {'j','u','a','n','d','i','e','g','o' };
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            Console.WriteLine("--------------------------");
            //FASE 2
            List<char> list = new List<char> { 'j', 'u', 'a', 'n', 'd', 'i', 'e', 'g', 'o' };
            double numero;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 'a'| list[i] == 'e' | list[i] =='i'| list[i] =='o'| list[i] =='u')
                {
                    Console.WriteLine("VOCAL");
                }
                else
                {
                    Console.WriteLine("CONSONTANT");

                }
                if (double.TryParse(list[i].ToString(),out numero))
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
            }
            //FASE 3
            Dictionary<char, int> nombreMap = new Dictionary<char, int>();

            for (int i = 0; i < nombre.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < nombre.Length; j++)
                {
                    if (nombre[j]== nombre[i])
                    {
                        cont++;
                    }
                }
                if (!nombreMap.ContainsKey(nombre[i])) //Si no esta la KEY añdida se agrega
                {
                    nombreMap.Add(nombre[i], cont);
                }                
            }
            foreach (KeyValuePair<char, int> valor in nombreMap)
            {
                Console.WriteLine("Letra: "+valor.Key+" Rept: "+valor.Value);
            }
            //FASE 4
            List<char> cognom = new List<char> { 'n', 'a', 'v', 'a', 'r', 'r', 'o' };
            List<char> fullName = nombre.Concat(" ").Concat(cognom).ToList();

            for (int i = 0; i < fullName.Count; i++)
            {
                Console.WriteLine(fullName[i]);
            }
            Console.ReadKey();
        }
    }
}

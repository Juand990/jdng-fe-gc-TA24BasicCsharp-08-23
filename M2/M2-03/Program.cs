using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos = 0;
            int minutos = 0;
            int horas = 0;            
            while (true)
            {
                segundos++;                                
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }
                if (minutos == 60)
                {
                    minutos = 0;
                    horas++;
                }
                if (segundos < 10 && minutos < 10 && horas<10)
                {
                    Console.WriteLine("0"+horas + ":" +"0"+ minutos + ":"+"0" + segundos);
                }
                else
                {
                    if (minutos < 10 && horas < 10)
                    {
                        Console.WriteLine("0" + horas + ":" + "0" + minutos + ":" + segundos);
                    }
                    else
                    {
                        Console.WriteLine("0" + horas + ":" + minutos + ":" + segundos);
                    }
                }                
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}

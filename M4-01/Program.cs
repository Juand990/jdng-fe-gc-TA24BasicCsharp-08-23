using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Milestone 1 FASE 1
            int cinco = 5;
            int diez = 10;
            int veinte = 20;
            int cincuenta = 50;
            int cien = 100;
            int doscientos = 200;
            int quinientos = 500;
            int precioTotal = 0;
            string[] menu = new string[5];
            int[] precio = new int[menu.Length];
            // Milestone 1 FASE 2
            for (int i = 0; i < menu.Length;)
            {
                try
                {
                    Console.WriteLine("Introduce el nombre del plato:");
                    menu[i] = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (menu[i] == "")
                    {
                        Console.WriteLine("Introduce el nombre del plato:");
                        menu[i] = Console.ReadLine();
                    }
                    throw new FormatException("Valor introducido erroneo.", e); // Milestone 3 FASE 1
                }
                try
                {
                    Console.WriteLine("Introduce el precio del plato:");
                    precio[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    if (precio[i] == 0)
                    {
                        Console.WriteLine("Introduce el precio del plato:");
                        precio[i] = int.Parse(Console.ReadLine());
                    }
                    throw new FormatException("Valor introducido erroneo.", e); // Milestone 3 FASE 1
                }
                if (menu[i] != "" && precio[i] != 0)
                {
                    i++;
                }
            }
            Console.Clear();
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i] + " con precio de " + precio[i]);
            }
            List<string> pedido = new List<string>();
            bool terminar = false;
            int resp;
            while (!terminar)
            {
                // Milestone 2 FASE 1
                try
                {
                    Console.WriteLine("Que vas a comer??");
                    string elegido = Console.ReadLine();
                    pedido.Add(elegido);
                }
                catch (Exception e)
                {
                    throw new FormatException("No esta en el menu.", e); // Milestone 3 FASE 1                  
                }
                // Milestone 2 FASE 1
                try
                {
                    Console.WriteLine("Seguir pidiendo?? 1(Si) / 0(No)");
                    resp = int.Parse(Console.ReadLine());
                    if (resp == 0)
                    {
                        terminar = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Seguir pidiendo?? 1(Si) / 0(No)");
                    resp = int.Parse(Console.ReadLine());
                    if (resp == 0)
                    {
                        terminar = true;
                    }
                }
            }
            // Milestone 1 FASE 3

            for (int i = 0; i < pedido.Count; i++)
            {
                for (int j = 0; j < menu.Length; j++)
                {
                    if (menu[j] == pedido[i])
                    {
                        precioTotal = precioTotal + precio[j];
                    }
                }
            }
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine("pedido: " + pedido[i]);

            }
            Console.WriteLine("precio del pedido: " + precioTotal);
            Console.ReadKey();
        }
    }
}


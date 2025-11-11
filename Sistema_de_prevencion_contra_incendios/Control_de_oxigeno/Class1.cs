using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Control_de_estaciones
{
    public class Medidor
    {
        private int t, o, p;
        public Medidor(ref int pP, ref int pC, ref int pR)
        {
            Random rnd = new Random();
            t = rnd.Next(23, 75);
            o = rnd.Next(15, 31);
            p = pP;
            if (p < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("============MONITOREO MANUAL============");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Piso " + p + ":");
                if (t <= 57)
                {
                    Console.ResetColor();
                    Console.Write("Temperatura ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Normal " + t + "°");
                    Console.ResetColor();
                    if (o <= 21)
                    {
                        Console.ResetColor();
                        Console.Write("Oxigeno ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Normal " + o + "%");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("Oxigeno ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Alto " + o + "%");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ResetColor();
                    Console.Write("Temperatura ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Alta " + t + "°");
                    Console.ResetColor();
                    if (o <= 21)
                    {
                        Console.ResetColor();
                        Console.Write("Oxigeno ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Normal " + o + "%");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("Oxigeno ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Alto " + o + "%");
                        Console.ResetColor();
                        pC = 1;
                        pR = 0;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Para regrsar precione [1]: ");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("OPCIONÓn NO  VÁLIDA");
                Console.ResetColor();
                pR = 0;
            }
        }
    }
}


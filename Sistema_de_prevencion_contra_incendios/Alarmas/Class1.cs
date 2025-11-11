using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alarmas
{
    public class Alarma
    {
        private int e; 
        public Alarma( ref int pE) 
        {
            e = pE;
            Console.Clear();
            for (int i = 0; i < 3; i++) 
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\r==ALERTA PELIGRO EN EL PISO " + e + " ==");
                Console.Beep(2350,1500);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\r==ALERTA PELIGRO EN EL PISO " + e + " ==");
                Console.Beep(2350, 1500);
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("LLAMNDO A LOS BOMBEROS ");
            Thread.Sleep(750);
            Console.Write("■");
            Thread.Sleep(750);
            Console.Write("■");
            Thread.Sleep(750);
            Console.Write("■");
            Console.WriteLine("\nEVACUANDO PISOS DEL 1 AL 4");
            Thread.Sleep(750);
            Console.ResetColor();
        }
    }
}

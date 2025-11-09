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
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\rAlerta peligro en la estacion " + e);
                Console.Beep(2350,1500);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("\rAlerta peligro en la estacion " + e);
                Console.Beep(2350, 1500);
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nLLamndo a los bomberos");
            Thread.Sleep(250);
            Console.Write("■");
            Thread.Sleep(250);
            Console.Write("■");
            Thread.Sleep(250);
            Console.Write("■");
            Console.WriteLine("\nEvacuando pisos del 1 al 4");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Funcionamiento
{
    public class Detector
    {
        private int d;
        public Detector(int pA,ref int pS, ref int pC)
        {
            d = pA;
            if (d <= 63)  
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normal " + d + "°");
                Console.ResetColor();
                Thread.Sleep(750);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Precacucion " + d + "°");
                Console.ResetColor();
                Thread.Sleep(750);
                pS = 1;
                pC = 1;
            }
        }
    }
}

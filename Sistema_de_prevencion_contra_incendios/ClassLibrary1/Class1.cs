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
        private int t, o;
        public Detector(int pT, int pO, int pN, ref int pC, ref int pR, ref int pP)
        {
            t = pT;
            o = pO;
            if (t <= 57)
            {
                Console.ResetColor();
                Console.Write("Temperatura ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normal " + t + "°");
                Console.ResetColor();
                if (o >= 83) 
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
                    Console.WriteLine("Bajo " + o + "%");
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
                if (o >= 83)
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
                    Console.WriteLine("Bajo " + o + "%");
                    Console.ResetColor();
                    pC = 1;
                    pR = 0;
                    pP = pN;
                }
            }
        }
    }
}

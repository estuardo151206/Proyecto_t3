using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Control_de_oxigeno
{
    public class Medidor
    {
        private int o;
        public Medidor(int pA, ref int pS, ref int pC)
        {
            o = pA;
            if (o <= 83)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normal " + o + "%");
                Console.ResetColor();
                Thread.Sleep(750);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Precacucion " + o + "%");
                Console.ResetColor();
                Thread.Sleep(750);
                pS = 2;
                pC = 1;
            }
        }
    }
}

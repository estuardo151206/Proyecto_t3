using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarma
{
    public class alarma
    {
        private int a;
        public alarma(int pA) 
        { 
            a = pA;
                switch (a)
                {
                    case 1: Console.WriteLine("Alerta iniciada en estacion 1"); activar(a); break;
                    case 2: Console.WriteLine("Alerta iniciada en estacion 2"); activar(a); break;
                    case 3: Console.WriteLine("Alerta iniciada en estacion 3"); activar(a); break;
                    case 4: Console.WriteLine("Alerta iniciada en estacion 4"); activar(a); break;
                }
        }
        private void activar(int a) 
        {
            Console.WriteLine("Precaucion temperatura alta en la estacion " + a);
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor= ConsoleColor.White;
                Console.Write("\rPrecaucion");
                Console.ResetColor();
                Console.Beep(1000, 1000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("\rPrecaucion");
                Console.Beep(1000, 1000);
                Console.ResetColor();
            }
            Console.WriteLine("\nAlerta emviada");
        }
    }
}

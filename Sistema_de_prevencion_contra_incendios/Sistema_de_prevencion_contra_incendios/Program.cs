using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Funcionamiento;
using Control_de_estaciones;
using Alarmas;
using System.Security.Cryptography;
using System.ComponentModel.Design.Serialization;

namespace Sistema_de_prevencion_contra_incendios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, control = 0, piso = 0;
            do
            {
                if (control == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║SISTEMA DE PREVENCION CONTRA INCENDIOS║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("============PANEL DE CONTROL============");
                    Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("[1]Monitoreo en tiempo real");
                    Thread.Sleep(50);
                    Console.WriteLine("[2]Revisar estaciones");
                    Thread.Sleep(50);
                    Console.Write("Seleccione: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Panel(opcion, ref control, ref piso);
                }
                else 
                {
                  Alarma a = new Alarma(ref piso);
                  break;    
                }
            } while (opcion != 3);
        }
        static void Panel(int opcion, ref int control, ref int piso)
        {
            switch (opcion)
            {
                case 1: Tiempo_Real(ref control, ref piso); break;
                case 2: Estaciones(ref piso, ref control); break;
            }
        }
        static void Tiempo_Real( ref int control, ref int piso)
        {
            Random rnd = new Random();
            int t1, t2, t3, t4, o1, o2, o3, o4;
            int r = 1;
            Console.Clear();
            Thread.Sleep(250);
            while (r == 1)
            {
                t1 = rnd.Next(23, 75);
                t2 = rnd.Next(23, 75);
                t3 = rnd.Next(23, 75);
                t4 = rnd.Next(23, 75);
                o1 = rnd.Next(80, 101);
                o2 = rnd.Next(80, 101);
                o3 = rnd.Next(80, 101);
                o4 = rnd.Next(80, 101);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("========MONITOREO EN TIEMPO REAL========");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Piso 1:");
                Detector d1 = new Detector(t1, o1, 1, ref control, ref r, ref piso);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Piso 2:");
                Detector d2 = new Detector(t2, o2, 2, ref control, ref r, ref piso);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Piso 3:");
                Detector d3 = new Detector(t3, o3, 3, ref control, ref r, ref piso);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Piso 4:");
                Detector d4 = new Detector(t4, o4, 4, ref control, ref r, ref piso);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Para regrsar precione [1]: ");
                Console.ResetColor();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.KeyChar == '1')
                    {
                        r = 0;
                        break;
                    }
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.Clear();
        }
        static void Estaciones(ref int piso, ref int control)
        {
            int r = 1;
            Console.Clear();
            Console.WriteLine("Seleccione el piso a revisar:");
            piso = int.Parse(Console.ReadLine());
            Console.Clear();
            Thread.Sleep(250);
            while (r == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("============MONITOREO MANUAL============");
                Console.ResetColor();
                Medidor m = new Medidor(ref piso, ref control, ref r);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Para regrsar precione [1]: ");
                Console.ResetColor();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.KeyChar == '1')
                    {
                        r = 0;
                        break;
                    }
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.Clear();
        }
    }
}

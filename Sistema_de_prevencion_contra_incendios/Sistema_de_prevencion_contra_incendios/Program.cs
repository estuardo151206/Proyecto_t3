using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Funcionamiento;
using Control_de_oxigeno;
using Alarmas;
using System.Security.Cryptography;
using System.ComponentModel.Design.Serialization;

namespace Sistema_de_prevencion_contra_incendios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, control = 0, sensor = 0;
            do
            {
                if (control == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║SISTEMA DE PREVENCION CONTRA INCENDIOS║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("============PANEL DE CONTROL============");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("[1]Revisar detectores de temperatura");
                    Console.WriteLine("[2]Revisar detectores de humo");
                    Console.WriteLine("[3]Salir");
                    Console.Write("Seleccione: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Panel(opcion, ref sensor, ref control);
                }
                else 
                {
                    switch (sensor) 
                    {
                        case 1: Alarma a1 = new Alarma(sensor);break;
                        case 2: Alarma a2 = new Alarma(sensor); break;
                    }
                    break;
                }
            } while (opcion != 3);
        }
        static void Panel(int opcion, ref int sensor, ref int control)
        {

            switch (opcion)
            {
                case 1: Temperatura(ref sensor, ref control); break;
                case 2: Oxigeno(ref sensor, ref control); break;
                case 3: salida(); break;
            }
        }
        static void Temperatura(ref int sensor, ref int control)
        {
            int d1, d2, d3, d4;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(1000);
            Console.WriteLine("=====Temperaturas de las estaciones=====");
            Thread.Sleep(500);
            Console.ResetColor();
            Random rnd = new Random();
            d1 = rnd.Next(32, 76);
            d2 = rnd.Next(32, 76);
            d3 = rnd.Next(32, 76);
            d4 = rnd.Next(32, 76);
            Console.WriteLine("╔═════╗");
            Console.Write("║ [1] ║");
            Console.Write("Estacion 1:");
            Detector f1 = new Detector(d1, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [2] ║");
            Console.Write("Estacion 2:");
            Detector f2 = new Detector(d2, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [3] ║");
            Console.Write("Estacion 3:");
            Detector f3 = new Detector(d3, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [4] ║");
            Console.Write("Estacion 4:");
            Detector f4 = new Detector(d4, ref sensor, ref control);
            Console.WriteLine("╚═════╝");
            Console.Write("Regresando ");
            Thread.Sleep(750);
            Console.Write("■ ");
            Thread.Sleep(750);
            Console.Write("■ ");
            Thread.Sleep(750);
            Console.Write("■");
            Thread.Sleep(750);
            Console.Clear();
        }
        static void Oxigeno(ref int sensor, ref int control) 
        {
            int o1, o2, o3, o4;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(1000);
            Console.WriteLine("=======Oxigeno  de las estaciones=======");
            Thread.Sleep(500);
            Console.ResetColor();
            Random rnd = new Random();
            o1 = rnd.Next(80, 101);
            o2 = rnd.Next(80, 101);
            o3 = rnd.Next(80, 101);
            o4 = rnd.Next(80, 101);
            Console.WriteLine("╔═════╗");
            Console.Write("║ [1] ║");
            Console.Write("Estacion 1:");
            Medidor c1 = new Medidor(o1, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [2] ║");
            Console.Write("Estacion 2:");
            Medidor c2 = new Medidor(o2, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [3] ║");
            Console.Write("Estacion 3:");
            Medidor c3 = new Medidor(o3, ref sensor, ref control);
            Console.WriteLine("╠═════╣");
            Console.Write("║ [4] ║");
            Console.Write("Estacion 4:");
            Medidor c4 = new Medidor(o3, ref sensor, ref control);
            Console.WriteLine("╚═════╝");
            Console.Write("Regresando ");
            Thread.Sleep(750);
            Console.Write("■ ");
            Thread.Sleep(750);
            Console.Write("■ ");
            Thread.Sleep(750);
            Console.Write("■");
            Thread.Sleep(750);
            Console.Clear();
        }
        static void salida() 
        {
            Console.WriteLine("Cerrando sistemas");
        }
    }
}

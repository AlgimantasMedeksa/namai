using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciasProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            double varna = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skaicius " + varna);
            Console.WriteLine("iveskite pirma skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite trecia skaiciu");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("pirmas skaicius didziausias");
            }
            if (b > a && b > c)
            {
                Console.WriteLine("antras skaicius didziausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("trecias skaicius didziausias");
            }
            else
            {
                Console.WriteLine("visi skaiciai lygus");
            }
            Console.ReadLine();
            double pirmas = 30;
            int antras = 60;
            Console.WriteLine("iveskite studento amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius > pirmas)
            {
                Console.WriteLine("studento amzius didesnis uz pirma skaiciu");
            }
            if (amzius > antras)
                    {
                Console.WriteLine("studento amzius didesnis uz antra skaiciu");
            }
            else
            Console.ReadLine();
            if (pirmas<antras)
            {
            Console.WriteLine("pirmas maziau uz antra");
            Console.WriteLine("pirmo skaiciaus reiksme - " + pirmas);
            }
            double liekana = pirmas % 2;
            if(liekana==0)
            {
            Console.WriteLine("skaicius lyginis");
            }
            Console.WriteLine("skaicius nelyginis");
            Console.ReadLine();

            Console.WriteLine("Ivesti apskritimo spinduli");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("apskritimo ilgis");
            double l = r * 2 * Math.PI;
            Console.WriteLine($"{l}");
            Console.WriteLine("apskritimo plotas");
            double p = r * r* Math.PI;
            Console.WriteLine($"{p}");
            Console.ReadLine();

        }
    }
}

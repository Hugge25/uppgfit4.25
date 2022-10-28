using System;

namespace Uppgfit4._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj et av följande alternativ:");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");



            int prog = int.Parse(Console.ReadLine());

            while (prog != 3)
            {
                switch (prog)
                {
                    case 1:
                        Console.WriteLine("Skriv in det första talet du vill subtrahera");
                        int subTal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in det andra talet du vill subtrahera");
                        int subtTal2 = int.Parse(Console.ReadLine());
                        int subSum = subTal1 - subtTal2;
                        Console.WriteLine($"{subTal1} - {subtTal2} = {subSum}");
                        break;

                    case 2:
                        Console.WriteLine("Skriv in ett tal som blir täljare");
                        int divTal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in ett tal som blir nämnare");
                        int divTal2 = int.Parse(Console.ReadLine());
                        int divSum = divTal1 / divTal2;
                        Console.WriteLine($"{divTal1} / {divTal2} = {divSum}");
                        break;
                }
                break;
            }
            Thread.Sleep(2000);
            string text = "Stänger av programme";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            string text2 = "t...";
            foreach (char d in text2)
            {
                Console.Write(d);
                Thread.Sleep(1000);
            }
        }
    }
}


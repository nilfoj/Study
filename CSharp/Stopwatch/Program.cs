using System;
using System.Threading;



namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome Stopwatch!");
            Console.WriteLine("S = Seconds (10s = 10 Seconds)");
            Console.WriteLine("M = Minutes (10m = 10 Minutes)");
            Console.WriteLine("E = Exit");
            Console.WriteLine("How long do you want to count?");
            
            
            string dtime = Console.ReadLine().ToLower();
            char dletter = char.Parse(dtime.Substring(dtime.Length - 1, 1));
            int dnumber = int.Parse(dtime.Substring(0, dtime.Length-1));


            Console.WriteLine(dletter);
            Console.WriteLine(dnumber);
        }


        static void Start()
        {

            int time = 0;
            int currenttime = 0;

            while (currenttime != time)
            {
                Console.Clear();
                currenttime ++;
                Console.WriteLine(currenttime);
                Thread.Sleep(500);
            }

        }

    }
}
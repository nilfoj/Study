using System;
using System.Runtime.InteropServices.JavaScript;
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
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long do you want to count?");


            string dtime = Console.ReadLine().ToLower();
            char dletter = char.Parse(dtime.Substring(dtime.Length - 1, 1));
            int dnumber = int.Parse(dtime.Substring(0, dtime.Length - 1));


            int multiplier = 1;

            if (dletter == 'm')
            {
                multiplier = 60;
            }

            if (dnumber == 0)
            {
                System.Environment.Exit(0);
            }

    
            PreStart (dnumber * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear ();
            Console.WriteLine("Ready ...");
            Thread.Sleep (1000);
            Console.WriteLine("Set ...");
            Thread.Sleep(800);
            Console.WriteLine("Go ...");
            Thread.Sleep(600);

            Start(time);
        }

        static void Start(int time)
        {

            int currenttime = 0;

            while (currenttime != time)
            {
                Console.Clear();
                currenttime ++;
                Console.WriteLine(currenttime);
                Thread.Sleep(200);
            }

            Console.Clear();
            Console.WriteLine("Stop!!");
            Menu();

        }

    }
}
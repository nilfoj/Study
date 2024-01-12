using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            
        }

        static void Menu()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Choose which mathematical operation you want to perform?");
            Console.WriteLine("1 – Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit!");
            Console.WriteLine("Choose an option:");


            short result = short.Parse(Console.ReadLine());
            switch (result)
            {

                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                
            }

        }

        static void Sum()
        {
            
            Console.Clear();
            
            Console.WriteLine("First value:");
            double v1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Result = {v1 + v2}");
            Console.WriteLine();
           
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
          
            Console.WriteLine("First value:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Result = {v1 - v2}");
            Console.WriteLine();    

            Menu();

        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Result = {v1 * v2}");
            Console.WriteLine();

            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Result = {v1 / v2}");
            Console.WriteLine();

            Menu();

        }

    }
}
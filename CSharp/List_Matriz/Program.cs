using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<int> listaNumeros = new List<int>();

            int valores = Convert.ToInt16(Console.ReadLine());
            
            for(int i = 0; i < valores; i++)
            {
                int numero = Convert.ToInt16(Console.ReadLine());
                listaNumeros.Add(numero);
            }
           
            foreach(int numero in listaNumeros) { Console.WriteLine(numero); }

        }
    }
}
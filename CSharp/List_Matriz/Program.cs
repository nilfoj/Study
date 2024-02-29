using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            List<int> listaNumeros = new List<int>();
            
            listaNumeros.Add(1);
            listaNumeros.Add(2);

            Console.WriteLine(listaNumeros[0]);
        }
    }
}
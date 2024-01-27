using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hello();
            //Nome();
            Soma();

        }

        static void Hello()
        {
            Console.Clear();
            Console.WriteLine("Olá, mundo!");
        }

        static void Nome()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"É um prazer te conhecer, {nome}");
        }

        static void Soma()
        {
            Console.Write("Digite um valor: ");
            int valor01 = int.Parse(Console.ReadLine());

            Console.Write("Digite um outro valor: ");
            int valor02 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre {valor01} e {valor02} é igual a {valor01 + valor02}");
        }



    }
}



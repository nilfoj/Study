using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            //001Hello(); 
            //002Nome();
            //003Soma();
            //005PredSecce();
            //006DTRaiz();

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

        static void PredSecce()
        {
            Console.Write("Digite um número: ");
            int valor01 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Analisando o valor {valor01}, seu antecessor é {valor01 - 1} e o sucessor é {valor01 + 1}");
       
        }

        static void DTRaiz()
        {
            Console.Write("Digite um valor: ");
            int valor01 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O dobro de {valor01} vale {valor01*2}.");
            Console.WriteLine($"O dobro de {valor01} vale {valor01 * 3}.");

            double valor02 = Math.Sqrt(valor01);
            string formato = valor02.ToString("0.00");

            Console.WriteLine($"A raiz quadrada de {valor01} é igual a {formato}");
        }

    }
}



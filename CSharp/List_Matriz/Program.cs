using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {

            List();

        }

        static void List()
        {
            Console.Clear();

            List<int> listaNumeros = new List<int>();

            int valores = int.Parse(Console.ReadLine());

            for (int i = 0; i < valores; i++)
            {
                int numero = Convert.ToInt16(Console.ReadLine());
                listaNumeros.Add(numero);
            }


            //foreach (int numero in listaNumeros) {
            //    Console.WriteLine(numero); 
            //}


            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine("Posição {0}:{1}", i, listaNumeros[i]);
            }


            int soma = 0;

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                soma += listaNumeros[i];
            }

            Console.WriteLine("A soma dos numeros da list é {0}", soma);


            Console.Write("Digite a posição da lista que deseja trocar:");
            int posicao = int.Parse(Console.ReadLine());

            if (posicao < 0 || posicao >= listaNumeros.Count)
            {
                Console.WriteLine("Inválido!");
                return;
            }

            Console.Write("Digite o numero que deseja colocar:");
            int numeronovo = int.Parse(Console.ReadLine());

            listaNumeros[posicao] = numeronovo;

            for (int i = 0;i < listaNumeros.Count; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }

        }




  

    }
}
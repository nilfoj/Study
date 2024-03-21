using System;

class Revisão
{
    static void Main()
    {

        int[,] matriz = new int[3, 3];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Digite o valor [{0}.{1}]:", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }


        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }


        int somaLinha = 0;
        int somaColuna = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            somaLinha += matriz[0, i];
            somaLinha += matriz[1, i];
            somaLinha += matriz[2, i];

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaColuna += matriz[j, 0];
                somaColuna += matriz[j, 1];
                somaColuna += matriz[j, 2];
            }

        }

        Console.WriteLine("[{0}.{1}]",somaLinha, somaColuna);












    }
}



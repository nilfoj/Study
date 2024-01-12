using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Soma +
        //Subtração -
        //Multiplicação *
        //Divisão /


        int valor01 = 1 + 1;
        int valor02 = 2 - 1;
        int valor03 = 3 * 1;
        int valor04 = 4 / 1;

        Console.WriteLine(valor01);
        Console.WriteLine(valor02);
        Console.WriteLine(valor03); 
        Console.WriteLine(valor04);


        int x = 0;
      
        Console.WriteLine(x += 5);
        Console.WriteLine(x -= 1);
        Console.WriteLine(x *= 2);
        Console.WriteLine(x /= 1);


        //Comparação
        // Igual ==
        //Diferente != 
        // Maior que >
        //Menor que <
        //Maior ou igual <=
        //Menor our igual >=

        Console.WriteLine(x < 24);
        Console.WriteLine(x >= 24);


        //Operadores Lógicos
        // and = &&
        // or = ||
        // not = !

        int z = 0;
        bool entre = (z > 25) && (z < 40);
        bool ou = (z > 25) || (z < 40);
        bool negacao = !(z < 25);

        Console.WriteLine(entre);
        Console.WriteLine(ou);
        Console.WriteLine(negacao);


        //Estrutura de Condição If e Else
        // if
        // else
        // else if






    }
}
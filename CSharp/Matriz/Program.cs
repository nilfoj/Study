//Declarando a matriz

/*
 
 M {A1 B1 C1
    D2 E2 F2
    G3 H3 I3}
 
 */

//Escrevendo Matriz

int[,] matriz = new int[3, 3];

for (int i = 0; i < matriz.GetLength(0); i++) 
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine("Digite o elemento [{0}.{1}]:", i, j);
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();


//Imprimindo a Matriz

for (int i = 0; i < matriz.GetLength(0); i++)
{

    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine();


//Somando Linha 1 

int somaLinha1 = 0;

for (int i = 0; i < matriz.GetLength(1); i++)
{
    somaLinha1 += matriz[0, i];
}

Console.WriteLine(somaLinha1);
Console.WriteLine();


//Somando Linha 2

int somaLinha2 = 0;

for (int i = 0; i < matriz.GetLength(1); i++)
{
    somaLinha2 += matriz[1, i];
}

Console.WriteLine(somaLinha2);
Console.WriteLine();


//Somando Linha 3
int somaLinha3 = 0;

for (int i = 0; i < matriz.GetLength(1); i++)
{
    somaLinha3 += matriz[2, i];
}

Console.WriteLine(somaLinha3);
Console.WriteLine();


//Somando Coluna 1

int somaColuna1 = 0;

for (int j = 0; j < matriz.GetLength(1); j++)
{
    somaColuna1 += matriz[j, 0];
}

Console.WriteLine(somaColuna1);
Console.WriteLine();


//Somando Coluna 1

int somaColuna2 = 0;

for (int j = 0; j < matriz.GetLength(1); j++)
{
    somaColuna2 += matriz[j, 1];
}

Console.WriteLine(somaColuna2);
Console.WriteLine();


//Soma Colune 3

int somaColuna3 = 0;

for (int j = 0; j < matriz.GetLength(1); j++)
{
    somaColuna3 += matriz[j, 2];
}

Console.WriteLine(somaColuna3);
Console.WriteLine();

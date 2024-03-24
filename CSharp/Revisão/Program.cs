using System.Globalization;

Random num00 = new Random();

Console.WriteLine("Seja bem vindo ao Jogo 21!");
//
Console.WriteLine();
Console.WriteLine("__________________________");
//
Console.WriteLine($"Regras: ");
Console.WriteLine("1* Não pode passar de 21!");
Console.WriteLine("2* Você pode pedir até 3 Jogadas!");
Console.WriteLine("3* O *Menor* número que pode aparecer é 1 e o *Maior* é 21!");
Console.WriteLine("4* Não pode passar de 21!");
//
Console.WriteLine("__________________________");
Console.WriteLine();

//1 Entranda!

Console.WriteLine("Player 01 ...");
int num01 = num00.Next(1, 22);
Console.WriteLine(num01);
Console.WriteLine();

if (num01 == 21)
{
    Console.WriteLine("Você venceu a Mesa!");
}

else
{

    Console.WriteLine($"Você deseja continuar: 'S' ou 'N'?");
    string continuar = Console.ReadLine().Trim().ToLower();
    string sim = "s";
    String nao = "n";

    if (continuar == "s")
    {
        Console.WriteLine("Vamos continuar!");
    }

    else
    {
        Console.WriteLine("Vamos parar aqui!");
    }

}

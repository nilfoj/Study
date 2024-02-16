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
            //007MAritmetica
            //008CMedidas();
            //009Tabuada();
            //010CMoedas();
            //011PParede();
            //012CDesconto();
            //013RSalarial();
            CTemperatura();
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

        static void MAritmetica()
        {

            Console.Clear();
            Console.Write("Primeira nota do Aluno: ");
            float pnota = float.Parse(Console.ReadLine());

            Console.Write("Segunda nota do Aluno: ");
            float snota = float.Parse(Console.ReadLine());

            float result = (pnota + snota) / 2;

            Console.WriteLine($"A média entra {pnota} e {snota} é igual a {result.ToString("0.0")}");
        }

        static void CMedidas()
        {
            
            Console.Clear();
            Console.Write("Uma distância em metros: ");
            float mmedidas = float.Parse(Console.ReadLine());

            Console.WriteLine($"A medida {mmedidas} em Km é {mmedidas / 1000}km");
            Console.WriteLine($"A medida {mmedidas} em hm é {mmedidas / 100}hm");
            Console.WriteLine($"A medida {mmedidas} em dam é {mmedidas / 10}dam");
            Console.WriteLine($"A medida {mmedidas} em dm é {mmedidas * 10}dm");
            Console.WriteLine($"A medida {mmedidas} em cm é {mmedidas * 100}cm");
            Console.WriteLine($"A medida {mmedidas} em mm é {mmedidas * 1000}mm");

        }

        static void Tabuada()
        {
            Console.Clear();
            Console.Write("Digite um número para vê sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------");

            Console.WriteLine($"{num} x 0 = {num * 0}");
            Console.WriteLine($"{num} x 1 = {num * 1}");
            Console.WriteLine($"{num} x 2 = {num * 2}");
            Console.WriteLine($"{num} x 3 = {num * 3}");
            Console.WriteLine($"{num} x 4 = {num * 4}");
            Console.WriteLine($"{num} x 5 = {num * 5}");
            Console.WriteLine($"{num} x 6 = {num * 6}");
            Console.WriteLine($"{num} x 7 = {num * 7}");
            Console.WriteLine($"{num} x 8 = {num * 8}");
            Console.WriteLine($"{num} x 9 = {num * 9}");
            Console.WriteLine($"{num} x 10 = {num * 10}");

            Console.WriteLine("-----------------");
        }

        static void CMoedas()
        {

            Console.Clear();
            Console.Write("Quando você tem na carteira? R$ ");
            float real = float.Parse(Console.ReadLine());

            double result = (real / 4.97);
            Console.WriteLine($" Com {real} você po comprar U${result.ToString("0.00")}");

        }

        static void PParede()
        {
            Console.Clear();
            Console.Write("Largura da Parede: ");
            float largura = float.Parse(Console.ReadLine());

            Console.Write("Altura da Parede: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sua parede tem a dimensão de {largura} x {altura} e sua área é de {(largura * altura).ToString("0.000")}m²");
            Console.WriteLine($"Para pintar essa parede, você precisará de {((largura * altura) / 2).ToString("0.0000")}l de tinta");



        }

        static void CDesconto()
        {
            Console.Clear();
            Console.Write("Qual é o preço do produto? R$ ");
            float ventrada = float.Parse(Console.ReadLine());

            Console.WriteLine($"O produto que custava R${ventrada}, na promoção com o desconto de 5% vai custar R$ R${(ventrada - ((ventrada * 5) / 100)).ToString("0.00")}.");
            Console.ReadKey();
        }

        static void RSalarial()
        {
            Console.Clear();
            Console.Write("Qual salário do funcionário? R$");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine($"Um funcionário que ganhva R${salario}, com 15% de aumento, passa a receber R$ R${( salario + ((salario * 15) / 100)).ToString("0.00")}.");
            Console.ReadKey();





        }

        static void CTemperatura()
        {
            Console.Clear();
            Console.Write("Informe a temperatura em °C: ");
            float temperatura = float.Parse(Console.ReadLine());

            Console.WriteLine($"A temperatura de {temperatura}°C corresponde a {((temperatura * 9) / 5) + 32}");
        }
    }
}



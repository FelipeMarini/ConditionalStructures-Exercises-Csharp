using System;

namespace Projeto_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            string num1_text = Console.ReadLine(); //"Console.ReadLine" lê e armazena em variável tipo string (num1_text)
            int num1 = int.Parse(num1_text); //conversão da variável string para integer(int) usando "int.Parse"  

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()); //conversão string para int de "Console.ReadLine" de forma direta

            int soma = num1 + num2;

            // Console.Write("O resultado é: ");   ---->   "forma mais direta de exibir o resultado"
            // Console.WriteLine(soma);

            Console.WriteLine("O resultado de " + num1 + " + " + num2 + " é: " + soma);
        }
    }
}

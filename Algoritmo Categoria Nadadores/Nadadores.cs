using System;

namespace Ex_Desafio1_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Por gentileza digite a sua idade: ");
            Console.WriteLine();
            int idade = int.Parse(Console.ReadLine());

            if (idade >=5 && idade <=7) {
                Console.WriteLine();
                Console.WriteLine("A sua categoria de nadador é a INFANTIL A");
            }

            if (idade >=8 && idade <=10) {
                Console.WriteLine();
                Console.WriteLine("A sua categoria de nadador é a INFANTIL B");
            }

            if (idade >=11 && idade <=13) {
                Console.WriteLine();
                Console.WriteLine("A sua categoria de nadador é a JUVENIL A");
            }

            if (idade >=14 && idade <=17) {
                Console.WriteLine();
                Console.WriteLine("A sua categoria de nadador é a JUVENIL B");
            }

            if (idade >18) {
                Console.WriteLine();
                Console.WriteLine("A sua categoria de nadador é a SÊNIOR");
            }
        }
    }
}
        
        
        

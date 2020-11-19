using System;

namespace Ex_1_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            
            int meses = anos * 12;
            Console.WriteLine("Você tem " + meses + " meses de idade");
            
            Console.WriteLine();
            
            int dias = anos * 365;
            Console.WriteLine("Você tem " + dias + " dias de idade");
            
            Console.WriteLine();
            
            int horas = dias * 24;
            Console.WriteLine("Você tem " + horas + " horas de idade");
            
            Console.WriteLine();
            
            int minutos = horas * 60;
            Console.WriteLine("Você tem " + minutos + " minutos de idade");

        }
    }
}

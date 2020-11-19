using System;

namespace Ex_3_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite o seu salário: ");
            Console.Write("$");
            
            double salario = double.Parse(Console.ReadLine());

            double reajuste = salario * 1.3;

            if(salario < 500) { 
                salario = reajuste;
                Console.WriteLine("O seu salário reajustado será de: " + "$" + salario + "Reais"  ); }   
            
            else { Console.WriteLine("O(A) senhor(a) não terá, dado o valor, um reajuste de salário"); }
        }
            
    }
            
}
        
        
        
        
        

        
    


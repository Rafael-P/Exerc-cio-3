using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salário atual ?");
            int salario = int.Parse(Console.ReadLine());

            double aumento = ((double)30/100)*salario;
            double reajuste = aumento + salario;
            
            if(salario < 500){
                Console.WriteLine("Seu salário será aumentado em "+aumento+" reais");
                Console.WriteLine("Seu salário atual é de "+reajuste);
            }else{
                Console.WriteLine("Você não tem direito a um aumento salárial");
            }

        }//FIM DO MAIN
    }
}

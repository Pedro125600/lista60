using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salarioInicial = 2000; 
            double aumento = 0.015; 
            double salario = salarioInicial;

            salario += salario * aumento;

           
            for (int ano = 1997; ano <= 2024; ano++)
            {
                aumento *= 2; 
                salario += salario * aumento; 
            }

            Console.WriteLine($"O salário atual do funcionário é: R${salario:F2}");
        }
    }
}
    


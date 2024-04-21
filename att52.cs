using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do saque:");
            int valorSaque = int.Parse(Console.ReadLine()) ;
           

            int notas100 = valorSaque / 100;
            valorSaque %= 100;

            int notas50 = valorSaque / 50;
            valorSaque %= 50;

            int notas20 = valorSaque / 20;
            valorSaque %= 20;

            int notas10 = valorSaque / 10;
            valorSaque %= 10;

            int notas5 = valorSaque / 5;
            valorSaque %= 5;

            int notas2 = valorSaque / 2;
            valorSaque %= 2;

            int notas1 = valorSaque;

            Console.WriteLine("Quantidade de notas necessárias:");
            if (notas100 > 0)
            {
                Console.WriteLine($"100 reais: {notas100} nota(s)");
            }
            if (notas50 > 0)
            {
                Console.WriteLine($"50 reais: {notas50} nota(s)");
            }
            if (notas20 > 0)
            {
                Console.WriteLine($"20 reais: {notas20} nota(s)");
            }
            if (notas10 > 0)
            {
                Console.WriteLine($"10 reais: {notas10} nota(s)");
            }
            if (notas5 > 0)
            {
                Console.WriteLine($"5 reais: {notas5} nota(s)");
            }
            if (notas2 > 0)
            {
                Console.WriteLine($"2 reais: {notas2} nota(s)");
            }
            if (notas1 > 0)
            {
                Console.WriteLine($"1 real: {notas1} nota(s)");
            }
        }
    }
}
    


using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 0, b = 1, f = 0, soma = 0;

            while (f < 4000000)
            {
                if (f % 2 == 0) 
                {
                    soma += f;
                }

                f = a + b;
                a = b;
                b = f;
            }

            Console.WriteLine($"A soma dos termos de valor par da sequência de Fibonacci até 4 milhões é: {soma}");
        }
    }
}
    


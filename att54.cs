using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro maior do que 1:");
            int numero = int.Parse(Console.ReadLine()) ;
         
            while(numero <= 1)
            {
                Console.WriteLine("Digite um número inteiro maior do que 1:");
                numero = int.Parse(Console.ReadLine());
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"O número {numero} não é primo.");

                }
            }

            Console.WriteLine($"O número {numero} é primo.");

        }
    }
}
    


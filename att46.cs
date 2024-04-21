using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroGerado = random.Next(1, 1001);
            int tentativas = 0;
            int palpite = 0;


            Console.WriteLine("Tente adivinhar o número gerado (entre 1 e 1000):");

            while (palpite != numeroGerado)
            {
               palpite = int.Parse(Console.ReadLine());

                tentativas++;

                if (palpite == numeroGerado)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroGerado} em {tentativas} tentativas.");
                }
                else if (palpite < numeroGerado)
                {
                    Console.WriteLine("O número gerado é maior. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("O número gerado é menor. Tente novamente.");
                }
            }
        }
    }
}
    


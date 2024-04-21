using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro positivo:");
            int n = int.Parse(Console.ReadLine());

            int contador = 1;
            for (int linha = 1; linha <= n; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    Console.Write(contador + " ");
                    contador++;
                }
                Console.WriteLine();
            }
        }
    }
}
    


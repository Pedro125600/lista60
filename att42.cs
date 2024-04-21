using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v;
            do
            {
                Console.WriteLine("Digite um número (ou digite um valor negativo ou zero para sair):");
                v = double.Parse(Console.ReadLine());

                double quadrado = Math.Pow(v, 2);
                double cubo = Math.Pow(v, 3);
                double raizQuadrada = Math.Sqrt(v);

                Console.WriteLine($"Para o valor {v}:");
                Console.WriteLine($"Quadrado: {quadrado}");
                Console.WriteLine($"Cubo: {cubo}");
                Console.WriteLine($"Raiz Quadrada: {raizQuadrada}\n");
            } while (v > 0);
        }
    }
}

    


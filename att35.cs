namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inicial e valor final:");
            int valorI = int.Parse(Console.ReadLine());
            int valorF = int.Parse(Console.ReadLine());

            while (valorI > valorF)
            {
                Console.WriteLine("Intervalo de valores inválido");
                Console.WriteLine("Digite o valor inicial e valor final:");
                 valorI = int.Parse(Console.ReadLine());
                 valorF = int.Parse(Console.ReadLine());
            }

            int somaImpares = 0;

            for (int i = valorI; i <= valorF; i++)
            {
                if (i % 2 != 0) 
                {
                    somaImpares += i;
                }
            }

            Console.WriteLine($"Soma dos ímpares no intervalo {valorI} a {valorF}: {somaImpares}");
        }
    }
    }


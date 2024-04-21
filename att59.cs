using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numHabitantes;
            double valorKwh;
            double maiorConsumo = 0
            double menorConsumo = 0
            double somaConsumo = 0;
            double totalResidencial = 0;
            double totalComercial = 0;
            double totalIndustrial = 0;

            Console.WriteLine("Informe o número de habitantes da cidade:");
            numHabitantes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do kWh:");
            valorKwh = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numHabitantes; i++)
            {
                Console.WriteLine($"\nHabitante {i}:");
                Console.Write("Consumo do mês (em kWh): ");
                double consumo = double.Parse(Console.ReadLine());
                somaConsumo += consumo;

                if (consumo > maiorConsumo)
                    maiorConsumo = consumo;

                if (consumo < menorConsumo)
                    menorConsumo = consumo;

                Console.Write("Código do consumidor (1-Residencial, 2-Comercial, 3-Industrial): ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        totalResidencial += consumo;
                        break;
                    case 2:
                        totalComercial += consumo;
                        break;
                    case 3:
                        totalIndustrial += consumo;
                        break;
                    default:
                        Console.WriteLine("Código inválido. O consumo não será contabilizado.");
                        break;
                }
            }

            double mediaConsumo = somaConsumo / numHabitantes;

            Console.WriteLine($"\nMaior consumo: {maiorConsumo} kWh");
            Console.WriteLine($"Menor consumo: {menorConsumo} kWh");
            Console.WriteLine($"Média de consumo: {mediaConsumo} kWh");

            Console.WriteLine($"\nTotal de consumo residencial: {totalResidencial} kWh");
            Console.WriteLine($"Total de consumo comercial: {totalComercial} kWh");
            Console.WriteLine($"Total de consumo industrial: {totalIndustrial} kWh");
        }
    }
}


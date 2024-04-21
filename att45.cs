using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Converter de km/h para m/s");
                Console.WriteLine("2. Converter de m/s para km/h");
                Console.WriteLine("3. Finalizar o programa");


                opcao = int.Parse(Console.ReadLine());

                double velocidade;
                double resultado;


               
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a velocidade em km/h:");
                        velocidade = double.Parse(Console.ReadLine());
                        resultado = velocidade * 1000 / 3600;
                        Console.WriteLine($"{velocidade} km/h equivale a {resultado} m/s");
                        break;
                    case 2:
                        Console.WriteLine("Digite a velocidade em m/s:");
                        velocidade = double.Parse(Console.ReadLine());
                        resultado = velocidade * 3600 / 1000;
                        Console.WriteLine($"{velocidade} m/s equivale a {resultado} km/h");
                        break;
                    case 3:
                        Console.WriteLine("Saindo");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma das opções disponíveis.");
                        break;
                }

            } while (opcao != 3);
        }
    }
}
    


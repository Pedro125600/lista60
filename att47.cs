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
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma das opções disponíveis.");
                    continue;
                }

                double numero1, numero2, resultado;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 + numero2;
                        Console.WriteLine($"O resultado da adição é: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 - numero2;
                        Console.WriteLine($"O resultado da subtração é: {resultado}");
                        break;
                    case 3:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 * numero2;
                        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        else
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"O resultado da divisão é: {resultado}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma das opções disponíveis.");
                        break;
                }

            } while (opcao != 5);
        }
    }
}
    


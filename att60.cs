using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0;
            int quantidade = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int somaPares = 0;
            int quantidadePares = 0;
            int numero = 1;

            Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

            while (numero != 0)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                    break;

                soma += numero;
                quantidade++;

                if (numero > maior)
                    maior = numero;

                if (numero < menor)
                    menor = numero;

                if (numero % 2 == 0)
                {
                    somaPares += numero;
                    quantidadePares++;
                }
            }

            double media = (double)soma / quantidade;
            double mediaPares = quantidadePares > 0 ? (double)somaPares / quantidadePares : 0;

            Console.WriteLine($"\n(a) Soma dos números digitados: {soma}");
            Console.WriteLine($"(b) Quantidade de números digitados: {quantidade}");
            Console.WriteLine($"(c) Média dos números digitados: {media}");
            Console.WriteLine($"(d) Maior número digitado: {maior}");
            Console.WriteLine($"(e) Menor número digitado: {menor}");
            Console.WriteLine($"(f) Média dos números pares: {mediaPares}");
        }
    }
}



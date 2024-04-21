using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int somaIdades = 0, quantidadePessoas = 0;

            do
            {
                Console.WriteLine("Digite a idade da pessoa (ou digite 0 para encerrar):");
             idade = int.Parse(Console.ReadLine());
              

                somaIdades += idade;
                quantidadePessoas++;
            } while (idade != 0);

            double idadeMedia = (double)somaIdades / quantidadePessoas;
            Console.WriteLine($"A idade média do grupo é: {idadeMedia}");
        }
    }
}

    


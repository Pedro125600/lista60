namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maior = 0 , menor = 100000000, nun; 

            do
            {
                
                Console.WriteLine("Escreva numeros e escreva um numero negatico para sair ");
                nun = int.Parse(Console.ReadLine());

                if (nun > maior )
                {
                    maior = nun;
                }

                if (nun < menor)
                {
                    menor = nun;
                }


            }while(maior > 0);
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);

        }
    }
}

    


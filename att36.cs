namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("soma dos quadrados dos cem primeiros numeros naturais  ́e");

          double  somaQ = 0;
            for (int i = 1 ; i <= 100; i++)
            {
                somaQ += Math.Pow(i,2) ;
            }

            Console.WriteLine($"Soma dos quadrados : {somaQ} ");
            
            double somaS = 0;   
            for (int i = 1 ;i <= 100; i++)
            {
                somaS += i;
            }
            somaS = Math.Pow(somaS,2);
            Console.WriteLine($"O quadrado da soma  : {somaS} ");

            double diferenca = somaS - somaQ;
            Console.WriteLine($"A didferença entre eles e  : {diferenca} ");

        }
    }
    }


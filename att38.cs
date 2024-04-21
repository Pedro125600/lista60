namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 1000;

            for (int a = 1; a < soma / 3; a++)
            {
                for (int b = a + 1; b < soma / 2; b++)
                {
                    int c = soma - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("O terno pitagórico é: a = " + a + ", b = " + b + ", c = " + c);
                        Console.WriteLine("O produto abc é: " + (a * b * c));
                    }
                }
            }

            Console.WriteLine("Não foi encontrado nenhum terno pitagórico para a soma " + soma);
        }
    }
}
    


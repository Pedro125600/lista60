namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1;

          
            for (int i = 1; i <= 20; i++)
            {
                int temp = resultado;

       
                while (temp % i != 0)
                {
                    temp += resultado; 
                }

                resultado = temp; 
            }

            Console.WriteLine("O menor número divisível por todos os números de 1 a 20 é: " + resultado);

        }
    }
}

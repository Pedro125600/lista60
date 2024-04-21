namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números que possuem a propriedade:");

            for (int numero = 1000; numero <= 9999; numero++)
            {
                int parteAlta = numero / 100;
                int parteBaixa = numero % 100;

                int somaQuadrados = (parteAlta / 10 + parteAlta % 10) * (parteBaixa / 10 + parteBaixa % 10);


                if (somaQuadrados == numero)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
    


namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r1, r2;
            do
            {
                Console.WriteLine("Digite o valor de R1 (ou digite 0 para sair):");


                r1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite o valor de R2 (ou digite 0 para sair):");

                r2 = double.Parse(Console.ReadLine());

                double resistencia = (r1 * r2) / (r1 + r2);
                Console.WriteLine("A resistência em paralelo é: " + resistencia);
            } while (r1 != 0 || r2 != 0);

        }
    }
}

    


namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseT, alturaT;

            do
            {
                Console.WriteLine("Digite a base do triângulo:");
               baseT = double.Parse(Console.ReadLine());
            } while ( baseT <= 0);

            do
            {
                Console.WriteLine("Digite a altura do triângulo:");
                alturaT = double.Parse(Console.ReadLine()); 
            } while (alturaT <= 0);

       
            double areaTriangulo = (baseT * alturaT) / 2;

      
            Console.WriteLine("A área do triângulo é: " + areaTriangulo);
        }
    }
}

    


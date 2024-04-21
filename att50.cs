using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double alturaChico = 150; 
            double alturaZe = 110;
            int anos = 0;

            while (alturaZe <= alturaChico)
            {
                alturaChico += 2; 
                alturaZe += 3;
                anos++; 
            }

            Console.WriteLine($"Serão necessários {anos} anos para que Zé seja mais alto que Chico.");
        }
    }
}
    


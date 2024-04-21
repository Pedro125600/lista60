using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0, f = 0;

            while (c < n)
            {

                Console.WriteLine(f);
                f = a + b;
                a = b;
                b = f;
                c++;
            }
        }
    }
}

    


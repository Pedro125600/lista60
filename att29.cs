using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista60
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double S = 0;
            int valorf1 = 2;

            for (i = 1; i <= 5; i++)
            {
                int fatorial = 1;

                for (int j = valorf1; j > 0; j--)
                {
                    fatorial *= j;
                }

                S += i / (double)fatorial;
                valorf1 += 2;
            }

            Console.WriteLine($"O valor de S é {S}");
            Console.ReadLine();

        }
    }
}

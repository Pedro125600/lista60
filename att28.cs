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
            Console.WriteLine("um valor n inteiro e positivo");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("um valor n inteiro e positivo");
                n = int.Parse(Console.ReadLine());
            }

            double E = 1;
            int fatorial = 1;
            int valorf1 = n;


            for (i = n; i > 0; i--)
            {
                valorf1 = i;
                fatorial = 1;

                while (valorf1 != 1)
                {
                    fatorial *= valorf1;
                    valorf1--;

                }



                E += 1 / (double)fatorial;


            }

            Console.WriteLine($"\nO valor de S e {E} ");
            Console.ReadLine();

      

        }
    }
}

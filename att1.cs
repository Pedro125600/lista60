using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista60
{
    class att1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5 primeiros numeros multiplos de 3");

            int cont = 0, n1 = 3;

            while (cont < 5)
            {
                Console.WriteLine(n1);
                n1 = n1 + 3;
                cont++;

            }


            Console.ReadLine();
        }
    }
}

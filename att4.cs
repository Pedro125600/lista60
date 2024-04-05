using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Conttagem ate 100.000 de 1.000 em 1.000");

            int cont = 0;

            while(cont <= 1000000)
            {
                Console.WriteLine(cont);

                cont += 1000;

            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {

 int i, j = 1;
            int k = 1;

            Console.WriteLine("for");
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

 

            Console.WriteLine("\n While");
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }



            Console.WriteLine("\n do While");
            do
            {
                Console.WriteLine(k);
                k++;



            } while (k <= 100);

            Console.ReadLine();


           
        }
    }
}

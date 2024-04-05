using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem de 10 a 0");

            int n1 = 10;

            while (n1 >= 0)
            {
                Console.WriteLine(n1);
                if (n1 == 0)
                {
                    Console.WriteLine("FIM");
                }

             
                n1--;
            }


            Console.ReadLine();
        }
        

    }
}

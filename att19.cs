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
            Console.WriteLine("Imprima um numero entre 100 e 999");
            int n = int.Parse(Console.ReadLine());
            while(n < 100 || n > 999)
            {
                Console.WriteLine("Valor invalido");
                Console.WriteLine("Imprima um numero entre 100 e 999");
                 n = int.Parse(Console.ReadLine());
            }

            int n1 = n / 100;
            Console.WriteLine(n1);
            int n2 = (n / 10) % 10;
            Console.WriteLine(n2);
            int n3 = n % 10;
            Console.WriteLine(n3);



            Console.ReadLine();

        }
    }
}

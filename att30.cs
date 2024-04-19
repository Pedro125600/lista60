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
            Console.WriteLine("De o valor de n");
            int n = int.Parse(Console.ReadLine());


            int soma1 = 0;
            for(int i = 0; i<= n ; i++)
            {
                soma1 += i;
            }

            Console.WriteLine($"\nA primeira sequencia deu : {soma1} ");


            int soma2 = 0;

            for(int i = 0; i<= n; i++)
            {
                int par = 2, impar = 1;
                soma2 += impar - par;

                par += 2;
                impar += 2;

            }

            soma2 += 2 * n - 1;

            Console.WriteLine($"\nA segunda sequencia deu : {soma2} ");

            int soma3 = 0;
            for(int i = 1; i <= (n*2 - 1); i+=2)
            {


                soma3 += i;


               
            }



            Console.WriteLine($"\nA terceira sequencia deu : {soma3} ");
            Console.ReadLine();

      

        }
    }
}

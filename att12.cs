using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero inteiro positivo");
            int nun = int.Parse(Console.ReadLine());

            while (nun < 0)
            {
                Console.WriteLine("Digite um numero inteiro positivo");
                nun = int.Parse(Console.ReadLine());

            }


            


            while (nun >= 0 )
            {

                Console.WriteLine(nun);
                 nun -= 1;

            }


            Console.ReadLine();
        }
    }
}

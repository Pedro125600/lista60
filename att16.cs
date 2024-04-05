using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro positivo impar");
            int nun = int.Parse(Console.ReadLine());

            while (nun < 0)
            {
                Console.WriteLine("Digite um numero inteiro positivo");
                nun = int.Parse(Console.ReadLine());

            }

            while (nun % 2 == 0)
            {
                Console.WriteLine("Digite um numero inteiro impar");
                nun = int.Parse(Console.ReadLine());

            }


            while (nun >= 0)
            {

                Console.WriteLine(nun);
                nun -= 2;

            }

            Console.ReadLine();


        }
    }
}

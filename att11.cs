using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att11
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


            int cont = 1;


            while (nun >= cont)
            {

                Console.WriteLine(cont);
                cont += 1;

            }


            Console.ReadLine();

        }
    }
}

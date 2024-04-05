using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero");
            int nun = int.Parse(Console.ReadLine());
            int cont = 1;


            while (nun > cont)
            {

                Console.WriteLine(cont);
                cont += 2;

            }


            Console.ReadLine();

        }
    }
}

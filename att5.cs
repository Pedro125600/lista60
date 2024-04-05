using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 5 valores para somar");

            int cont = 0;
            double n1 = 0 , soma = 0;

            while(cont < 5 )
            {
                cont++;
                Console.WriteLine("Digite o " + cont + " valor " );

                n1 = double.Parse(Console.ReadLine());

                soma += n1;

            }

            Console.WriteLine("O valor da soma e " + soma);

            Console.ReadLine();

        }
    }
}

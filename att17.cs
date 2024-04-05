using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att17
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


            int cont = 1 , soma = 0;


            while (nun > cont)
            {

                Console.WriteLine(cont);
                soma += cont;
                cont += 1;
             
            }

            Console.WriteLine("A soma dos numeros inteiros ate " + nun + " e " + soma);

            Console.ReadLine();

        }
    }
}

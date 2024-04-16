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

            double nun = 0;
            double soma = 0;
            int cont = -1;
            do
            {
                soma += nun;
                Console.WriteLine("De notas de 10 a 20 qualquer outro valor para parar");
                nun = double.Parse(Console.ReadLine());
          
                cont++;

            } while (nun >= 10 && nun <= 20);


            double media = soma / cont;
            Console.WriteLine($"A media das notas e de : {media} ");

            Console.ReadLine();
         

            }
          
        }
   }


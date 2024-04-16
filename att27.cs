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

            Console.WriteLine("Digite um numero Positivo inteiro");
            int nun = int.Parse(Console.ReadLine());
            int cont = 1 ;
            int soma = 0;

            while(nun != 0)
            {
                soma += 1/cont + 1;
                cont++;
                nun--;
            }


            Console.WriteLine($" a soma da serie harmonica e : {soma}");


            Console.ReadLine();
         

            }
          
        }
   }


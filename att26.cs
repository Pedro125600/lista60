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

            Console.WriteLine("Digite um numero Positivo");
            int nun = int.Parse(Console.ReadLine());

            int cont = 1;
            int nun1 = nun;
            int nun2 = 0;
            while (cont != 0)
            {
                nun1++;
                if(nun1 % 11 == 0  || nun1 % 13 == 0 || nun1 % 17 == 0  )
                {
                    Console.WriteLine($"O primeirp  primeiro ultiplo de 11, 13 ou 17  apos {nun} e :{nun1}");
                    cont = 0;
                }



            }





            Console.ReadLine();
         

            }
          
        }
   }


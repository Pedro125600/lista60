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


            int nun = 1000;
            int cont = 1;
            int soma = 0;
            while(cont < nun)
            {
                if(cont % 3 == 0 || cont % 5 == 0)
                {

                    soma += cont;
                }

                cont++;

            }

            Console.WriteLine($"A soma de todos os numeros natrais abaixo de 1000 multiplos de 3 ou 5 e : {soma}");




            Console.ReadLine();
         

            }
          
        }
   }


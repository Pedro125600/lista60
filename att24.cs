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
            int soma = 0;
            while(cont < nun)
            {
                if(nun % cont == 0)
                {

                    soma += cont;
                }

                cont++;

            }

            Console.WriteLine($"A soma dos divisores de {nun} e: {soma}");




            Console.ReadLine();
         

            }
          
        }
   }


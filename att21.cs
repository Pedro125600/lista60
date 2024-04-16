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
            Console.WriteLine("Digite o primeiro numero");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int nun2 = int.Parse(Console.ReadLine());

            int n3 , somap = 0 , multI = 1 ;

            if ( nun1 > nun2)
            {
                n3 = nun2;
                while ( n3 <= nun1)
                {
                    

                    if (n3 % 2 == 0)
                    {
                        somap += n3;
                    }

                    else
                    {
                        multI *= n3;
                    }

                    n3++;

                }


            }
            else
            {
                n3 = nun1;
                while (n3 <= nun2)
                {


                    if (n3 % 2 == 0)
                    {
                        somap += n3;
                    }

                    else
                    {
                        multI *= n3;
                    }

                    n3++;

                }
            }


            Console.WriteLine($"A soma dos pares e {somap}");
            Console.WriteLine($"A multiplicação dos impares e  {multI}");


            Console.ReadLine();
         

            }
          
        }
   }


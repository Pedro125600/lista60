﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 numeros para fazer a media o programa ira ignorar numeros negativos");

            int cont = 0, soma = 0, n1 = 0;
            double media = 0;

            while (cont < 10)
            {
                cont++;
                Console.WriteLine("Digite o " + cont + " valor ");

                n1 = int.Parse(Console.ReadLine());

                if (n1 > 0)
                {
                    soma += n1;
                }

               else 
                {
                    Console.WriteLine("NUmero NWgativo Ignorado");
                }

            }

            media = soma / 10;

            Console.WriteLine("O valor da media e " + media);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 numeros para fazer a media");

            int cont = 0 ,  soma = 0 , n1 = 0;
            double  media = 0 ;

            while (cont < 10)
            {
                cont++;
                Console.WriteLine("Digite o " + cont + " valor ");

                n1 = int.Parse(Console.ReadLine());

                soma += n1;
              
            }

            media = soma / 10;

            Console.WriteLine("O valor da media e " + media);

            Console.ReadLine();



        }
    }
}

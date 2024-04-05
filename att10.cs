using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma dos 50 numeros pares");
        
            int cont = 0 , soma = 0 , pares =0;



            while (cont <= 50)
            {
                cont++;
                Console.WriteLine(soma);
                pares += 2;
                soma += pares;
           
            }


            Console.ReadLine();




        }
    }
}

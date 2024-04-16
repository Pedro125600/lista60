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
            int n = 0;
            int p = 0;
            int nun; 
            do
            {
                n++;
                Console.WriteLine($"Digite o {n} numero se quiser parar digite 100");
                nun = int.Parse(Console.ReadLine());

                if (nun % 2 == 0)
                {
                    p++;
                }
               
             
            } while (nun != 100);


            Console.WriteLine($"foram lidos {n} valores");
            Console.WriteLine($"Destes valores {p} são pares");

            Console.ReadLine();
        }
    }
}

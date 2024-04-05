using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de numeros que sera lido");
            int N = int.Parse(Console.ReadLine());

            int cont = 1;


            
        

            double nun = 0, maior , menor;

            Console.WriteLine("Digite o " + cont + " valor ");

            nun = int.Parse(Console.ReadLine());
            maior = nun;
            menor = nun;


            while (N > cont)
            {
                cont++;
                Console.WriteLine("Digite o " + cont + " valor ");
              
                nun = int.Parse(Console.ReadLine());


                if (nun > maior)
                {
                    maior = nun;
                }

                if (nun < menor)
                {
                    menor = nun;
                }


            }



            Console.WriteLine("O maior numero e " + maior);
            Console.WriteLine("O menor numero e " + menor);


            Console.ReadLine();

        }
    }
}

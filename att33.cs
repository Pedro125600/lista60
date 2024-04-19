using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De o  valor de n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("De o  valor de i");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("De o  valor de j");
            int j = int.Parse(Console.ReadLine());
            int v = 0;
            int pi = 0, pj = 0;

            int mi = 0 , mj = 0;
            
           while(n > 0)
            { 

                mi = i * v;
                mj = j * v;


                if (pi == mi )
                {
                    Console.Write(pi + " ");
                    n--;
                }

                if (pj == mj)
                {
                    Console.Write( pj + " ");
                    n--;
                }

               else  if (mi == mj)
                { 
                    Console.Write(mj + " ");
                    pi = mi;
                    pj = mj;
                    n--;
                }

             else    if (mi < mj)
                {

                    Console.Write(mi + " " );
                    pi = mi;
                    pj = mj;
                    n--;
                }

            else     if (mj > mi)
                {
                    Console.Write(mj + " " );
                    pi = mi;
                    pj = mj;
                    n--;
                }
                v++;

            }

            Console.ReadLine();
        }
    }
}

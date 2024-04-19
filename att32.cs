using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att32
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int d1 = r.Next(1,6);
            int d2 = r.Next(1,6);
            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");

            if (d1 > d2)
            {
                Console.WriteLine("d1 > d2");
            }
           
           else if  (d2 > d1)
            {
                Console.WriteLine("d2 > d1");
            }

            else
            {
                Console.WriteLine("d1 = d2");
            }

            Console.ReadLine();

        }
    }
}

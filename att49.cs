using System.Drawing;

namespace list60_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

                double salarioCarlos = 1000;
                double salarioJoao = salarioCarlos / 3;
                int meses = 0;


                while (salarioJoao < salarioCarlos)
                {
                    salarioCarlos += salarioCarlos * 0.02;
                    salarioJoao += salarioJoao * 0.05;
                    meses++;
                }

                Console.WriteLine($"Quantidade de meses necessários: {meses}");
            }
        }
    }
}
    


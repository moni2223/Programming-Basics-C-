using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            int A = 1;
            if (D == 1)
            {
                Console.WriteLine("{0} ", A);
            }
            else
            {
                int B = 1;
                Console.Write("{0} {1} ", A, B);
                for (int i = 3; i <= D; i++)
                {
                    int C = A + B;
                    A = B;
                    B = C;
                    Console.Write("{0} ", C);

                }
                Console.WriteLine();
            }
        }
    }
}
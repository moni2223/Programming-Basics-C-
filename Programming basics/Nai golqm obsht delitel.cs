using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            while (A != 0&&B!=0)
            {
                if(A>B)
                {
                    A = A - B;
                }
                else
                {
                    B = B - A;
                }
            }
            int gcd = A + B;
            Console.WriteLine(gcd);
        }
    }
}

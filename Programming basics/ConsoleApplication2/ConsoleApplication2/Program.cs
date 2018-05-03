using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A>B)
            {
                Console.WriteLine(A);
            }
            if (A<B)
            {
                Console.WriteLine(B);
            }
        }
    }
}

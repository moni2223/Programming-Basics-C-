using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int P= Math.Max(Math.Max(A,B),C);
            int Q = Math.Min(Math.Min(A, B), C);
            int S = A + B + C - (P + Q);
            Console.WriteLine("{0} {1} {2}", P,S,Q);
        }
    }
}

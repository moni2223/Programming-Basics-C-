using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A >= B && B >= C)
            {
                Console.WriteLine("{0} {1} {2}", A, B, C);
            }
            else
            if (B >= A && A >= C)
            {
                Console.WriteLine("{0} {1} {2}", B, A, C);
            }
            else
            if (C >= A && C >= B)
            {
                Console.WriteLine("{0} {1} {2}", C, A, B);
            }
            else
            if (A >= C && C >= B)
            {
                Console.WriteLine("{0} {1} {2}", A, C, B);
            }
            else
            if (B >= C && C >= A)
            {
                Console.WriteLine("{0} {1} {2}", B, C, A);
            }
            else
            if (C >= B && B >= A)
            {
                Console.WriteLine("{0} {1} {2}", C, B, A);
            }
        }
    }
}

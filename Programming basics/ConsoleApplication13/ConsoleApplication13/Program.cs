using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int s1 = A / C;
            if (A % C > 0)
                s1++;
            int s2 = B / D;
            if (B % D > 0)
                s2++;
            int b1 = s1 * s2;

            s1 = A / D;
            if (A % D > 0)
            s1++;
            s2 = B / C;
            if (B % C > 0)
            s2++;
            int b2 = s1 * s2;
            Console.WriteLine(Math.Min(b1,b2));
        }
    }
}

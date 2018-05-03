using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            int a1 = c1 * z2 + c2 * z1;
            int a2 = z1 * z2;
            int a = a1;
            int b = a2;
            int grd = 0;
            while (a > 0 && b > 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            grd = a + b;
            a = b / grd;
            b = a / grd;
            Console.WriteLine("{0}/{1}", a + b);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Max = 0;
            int b = 0;
            for (int i = 1; i <= N; i++)
            {

                int a = int.Parse(Console.ReadLine());

                if (a > Max)
                {
                    Max = a;
                }

                if (a < b)
                {
                    b = a;
                }
            }
            Console.WriteLine(Max-b);
        }
    }
}

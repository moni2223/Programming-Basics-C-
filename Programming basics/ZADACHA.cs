using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
                int S = 0;
            for (var i = 1; i<=A; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b % 2 == 0)
                {
                    S=S+b;
                }
            }
            Console.WriteLine(S);
        }
    }
}

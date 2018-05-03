using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            while(N>0)
            {
                S = S + N % 10;
                N = N / 10;
            }
            Console.WriteLine(S);
        }
    }
}

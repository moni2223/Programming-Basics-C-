using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int w = 2*M - 1;
            for (int i=1;i<=M;i++)
            {
                int s = (i - 1) * 2 + 1;
                int N = (w-s) / 2;
                Console.Write(new string(' ',N));
                Console.WriteLine(new string('*',s));
            }
            for (int i =M-1; i >=1; i--)
            {
                int s = (i - 1) * 2 + 1;
                int N = (w - s) / 2;
                Console.Write(new string(' ', N));
                Console.WriteLine(new string('*', s));
            }
        }
    }
}

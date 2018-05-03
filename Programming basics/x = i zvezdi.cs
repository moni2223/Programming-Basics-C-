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
            Console.Write(new string('=',M-1));
            Console.Write("X");
            Console.WriteLine(new string('=', M - 1));
            for (int i = 1; i <= M-2; i++)
            {
                int L = i * 2 - 1;
                int N = (w - L - 2) / 2;
                Console.Write(new string('=',N));
                Console.Write(('x'));
                Console.Write(new string('*',L));
                Console.Write(('x'));
                Console.WriteLine(new string('=',N));
            }
            Console.WriteLine(new string('x',w));
        }
    }
}

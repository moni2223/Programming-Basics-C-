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
            for (int i = 1; i <= M; i++)
            {
                int s = M - i;
                int z = i - 1;
                Console.Write(new string(' ',s));
                Console.Write(new string('*',z));
                Console.Write(('|'));
                Console.WriteLine(new string('*',z));
            }
        }
    }
}

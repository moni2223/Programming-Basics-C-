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
            int d = int.Parse(Console.ReadLine());
            for (int i = 1; i <= d; i++)
                Console.WriteLine(new string('*', M));
            for (int i = 1; i <= M - 2*d; i++)
            {
                Console.Write(new string('*', d));
                Console.Write(new string(' ',M-2*d));
                Console.WriteLine(new string('*', d));
            }
            for (int i = 1; i <= d; i++)
                Console.WriteLine(new string('*', M));
            Console.WriteLine();
        }
    }
}


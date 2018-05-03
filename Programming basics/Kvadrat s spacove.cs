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
            Console.Write('+');
            Console.Write(new string('-',M-2));
            Console.WriteLine('+');
            for(int i=1;i<=M;i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', M - 2));
                Console.WriteLine('|');
            }
            Console.Write("+");
            Console.Write(new string('*', M - 2));
            Console.WriteLine("+");
        }
    }
}


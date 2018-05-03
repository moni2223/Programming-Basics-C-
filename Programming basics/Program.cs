using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if (A < 5)
            {
                Console.WriteLine("Yes");
            }
            else
                if (A > 10)
                {
                    Console.WriteLine("Yes");
                }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

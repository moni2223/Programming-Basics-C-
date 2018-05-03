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
            var A = int.Parse(Console.ReadLine());
            var Min =10000000000000;
            for (var i = 1; i <= A; i++)
            {
                var b = int.Parse(Console.ReadLine());
                if(b<Min)
                {
                    Min = b;
                }
            }
            Console.WriteLine("Min="+Min);
        }
    }
}



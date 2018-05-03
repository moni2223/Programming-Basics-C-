using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = int.Parse(Console.ReadLine());
            var b2 = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var Area = (b1 + b2) * h / 2;
            Console.WriteLine("Area="+ Area);
        }
    }
}

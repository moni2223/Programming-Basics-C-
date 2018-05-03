using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A1 = N % 10;
            int A2 = (N / 10) % 10;
            int A3 = (N / 100) % 10;
            int A4 = (N / 1000) % 10;
            int A5 = (N / 10000) % 10;
            int A6 = (N / 100000) % 10;
            if(A1+A2+A3==A4+A5+A6)
            {
                Console.WriteLine(A1+A2+A3);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}

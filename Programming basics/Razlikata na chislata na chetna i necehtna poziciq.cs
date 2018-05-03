using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = -2147483648;
            while (true)
            {
                int N = int.Parse(Console.ReadLine());
                if(N==-1)
                {
                    break;
                }
                if(N>C)
                {
                    C = N;
                }
            }
            Console.WriteLine(C);
        }
    }
}
    


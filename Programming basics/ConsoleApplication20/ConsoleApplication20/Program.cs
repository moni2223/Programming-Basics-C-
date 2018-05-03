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
            int N = int.Parse(Console.ReadLine());
            int Max1 = 0;
            while (N>0)
            {
                int A = N % 10;
                N = N / 10;
                if(A>Max1)
                {
                    Max1 = A;
                    Console.WriteLine(A);
                }
         }
       }
   }
}
    


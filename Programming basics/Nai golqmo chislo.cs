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
            int C = 0;
            int S = 0;
            int B = 0;
            while (N > 0)
            {
                C++;
                if(C%2==0)
                {
                    S = S + N % 10;
                }
                else
                {
                    B = B + N % 10;
                }
                N = N / 10;
            }
            Console.WriteLine(Math.Abs(S-B));
        }
       }
   }

    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int Br = 1;
            int Max = 1;
            for(int i=2;i<=N;i++)
            {
                int B = int.Parse(Console.ReadLine());
                if (A == B)
                {
                    Br++;
                    if (Max < Br)
                    {
                        Max = Br;

                    }
                }
                else
                {
                    Br = 1;
                    A = B;
                }
                
            }
            Console.WriteLine(Max);
        }
    }
}

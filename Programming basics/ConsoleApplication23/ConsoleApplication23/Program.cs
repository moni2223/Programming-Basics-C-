using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if(A>B)
            {
                A = B;
            }
            for(int i=3;i<=N;i++)
            {
                int C = int.Parse(Console.ReadLine());
                if(C>A)
                {
                    B = A;A = C;
                }
                else
                  if(C>B)
                {
                    B = C;
                }
            }
            Console.WriteLine(B);
        }
        }
    }


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
            int Max = int.Parse(Console.ReadLine());
            int Br = 1;
            
            for (int i = 2; i <= N; i++)
            {
                int B = int.Parse(Console.ReadLine());
                if (Max < B)
                {
                    Max = B;
                    Br = 1;

                }
                else
                if (Max == B) Br++;
            }

            Console.WriteLine(Max+" "+Br);
        }
    }
}

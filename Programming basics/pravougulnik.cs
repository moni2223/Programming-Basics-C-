using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int k = i - 1;
                for (int j = 1; j <= N; j++)
                {
                    k++;
                    if (k > N)
                        k = 1;
                    Console.Write(k);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}

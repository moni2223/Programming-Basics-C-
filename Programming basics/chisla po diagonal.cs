﻿using System;
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
                for (int j = 1; j <= N; j++)
                {
                   
                    if (i==j||i==(N-j+1))
                        Console.Write(1+" ");
                        else
                        Console.Write(0+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

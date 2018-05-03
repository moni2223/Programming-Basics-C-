using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e,h,s,S;
            a = int.Parse(Console.ReadLine());
            e=a % 10;
            d = (a / 10) % 10;
            s = (a / 100) % 10;
            h = a / 1000;
            S = e + d + s + h;
            Console.WriteLine(S);
            
             

        }
    }
}

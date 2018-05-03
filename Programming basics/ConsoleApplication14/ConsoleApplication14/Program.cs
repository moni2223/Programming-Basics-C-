using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int tim, tt;
            int T = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            if(((T<N) && (R !=1)) || ((T > N) && (R != 2)))
            {
                Console.WriteLine("-1");
            }
            else
           if(R==1)
            {
                tim=N-T;
                Console.WriteLine("{0} {1}", tim / 60, tim % 60);
            }
            else
            if(R==2)
            {
                tt = T- N;
                tim = tt / 2;
                if (tt % 2 == 1) tim++;
                Console.WriteLine("{0} {1}", tim/60, tim%60);
            }
            
        }
    }
}

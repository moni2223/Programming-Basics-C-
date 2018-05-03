using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if ((A >= 5 && A <= 10)||(A>=20 && A<=30))
            { Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}

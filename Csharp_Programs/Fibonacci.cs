using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programs
{
    public static class Fibonacci
    {
        public static void Print()
        {
            //0 1 1 2 3 5 8
            int a = 0, b = 1, c = 0;
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter limit for fibonacci series: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Write($"Series is : {a} {b}");
            for (int i = 2; i < n; i++)
            {
                c = a + b;//1,2,3,5
                a = b;//1,1,2
                b = c;//1,2,3

                Console.Write($" {c}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

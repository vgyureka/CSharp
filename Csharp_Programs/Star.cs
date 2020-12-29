using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programs
{
    public static class Star
    {
        public static void Print()
        {
            Console.WriteLine("************** Star Pyramid *******************");
            Console.WriteLine("Enter n number for STAR pyramid:");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("U entered:", n);
            string star = "*";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Pyramid()
        {
            int num, i, j, k;
            Console.WriteLine("*********************************");
            Console.WriteLine("enter the Pyramid level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}

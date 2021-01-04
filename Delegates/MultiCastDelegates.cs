using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void delegatePrint();
    public class MultiCastDelegates
    {
        public static void DelFunc()
        {
            // del is a multicast delegate, since it is pointing to multiple methods
            // methods are called in the same order in which they are referenced
            delegatePrint del = new delegatePrint(print1);
            del += print2;
            del += print3;
            del -= print2;
            del();
        }
        public static void print1()
        {
            Console.WriteLine("Print 1");
        }
        public static void print2()
        {
            Console.WriteLine("Print 2");
        }
        public static void print3()
        {
            Console.WriteLine("Print 3");
        }
    }
}




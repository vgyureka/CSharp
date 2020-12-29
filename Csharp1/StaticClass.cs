using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public static class StaticClass
    {
        private static int i = 0;
        // Constructor shld be private
        // Shld be static
        //access modifiers not allowed on static constructors
        static StaticClass()
        {
            i++;
            Console.WriteLine($"static constructor will not be called- {i}");
        }
        public static void TestDemo(int i)
        {
            Console.WriteLine($"static test demo {i}");
        }
    }

    public class StaticClass1
    {
        private static int i = 0;
        // Constructor shld be private
        // Shld be static
        //Constructor not called, in case of static methods
        private  StaticClass1()
        {
            i++;
            Console.WriteLine($"constructor called- {i}");
        }
        public static void TestDemo1(int i)
        {
            Console.WriteLine($"static test demo {i}");
        }
    }

}

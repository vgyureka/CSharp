using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void TestDel(int a, int b, int c);
    public delegate string SayDel(string name);
    class DelegatesDemo
    {
        public void AddNums(int x,int y,int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }

    }
}

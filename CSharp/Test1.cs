using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public  class Test1
    {
        static int a = 0;

        private Test1()
        {
            a = 1;
        }
        //public Test1(string a)
        //{
           
        //}


        string func1()
        {
            return "func1";
        }

        internal static int  func2()
        {
            return a;
        }
    }
}

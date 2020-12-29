using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class ParameterTypes
    {
        public static void ValueType()
        {
            int i = 0;
            someMethodValue(i);
            Console.WriteLine("value : " + i);
        }
        public static void RefType()
        {
            int i = 0;
            someMethodRef(ref i);
            Console.WriteLine("value : " + i);
        }
        public static void OutType()
        {
            int i;
            someMethodOut(out i);
            Console.WriteLine("value : " + i);
            Console.ReadLine();
        }
        public static void ParamsType()
        {
            int[] i = { 1 };
            someMethodParams(1,i);
            Console.WriteLine("value : " + i[0]);
            Console.ReadLine();
        }

        public static void NamedType()
        {
            int x, y, z;
            someMethodNamed(1, y: 20, x: 10, z: 30);
        }
        public static void DefaultType()
        {
            int x, y, z;
            someMethodDefault(10,5);
        }

        private static void someMethodDefault(int x, int y = 1,int z =2)
        {
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            Console.WriteLine("z : " + z);
            Console.ReadLine();
        }

        public static void someMethodNamed(int j,int x, int y, int z)
        {
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            Console.WriteLine("z : " + z);
            Console.WriteLine("j : " + j);
            Console.ReadLine();
        }

        private static void someMethodParams(int j, params int[] i)
        {
            i[0] = 100;
            j = 100;
        }

        private static void someMethodOut(out int j)
        {
            j = 10;
            // without assignment here will give compile error
        }

        private static void someMethodRef(ref int j)
        {
            j = 100;
        }

        private static void someMethodValue(int j)
        {
            j = 100;
        }
    }

}

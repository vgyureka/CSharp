using System;

namespace Csharp1
{
    public static class StackVsHeap
    {
        /// <summary>
        ///   The Stack is self-maintaining, meaning that it basically takes care of its own memory management. 
        ///   The Heap, on the other hand, has to worry about Garbage collection (GC) - which deals with how to keep the 
        ///   Heap clean 
        ///   What goes on the Stack and Heap?
        ///   1.A Reference Type always goes on the Heap
        ///   2.Value Types and Pointers always go where they were declared.

        ///We have four main types of things we'll be putting in the Stack and Heap as our code is executing: 
        ///Value Types, Reference Types, Pointers, and Instructions. 
        ///1 . Value Types : -  [STACK]
        //-  they are from (System.ValueType):
        //bool
        //byte
        //char
        //decimal
        //double private enum
        //float
        //int
        //long
        //sbyte
        //short private struct
        //uint
        //ulong private ushort

        //2. Reference private Types [HEAP]

        //(and inherit from System.Object):
        // class
        // interface
        // delegate
        // object
        //  string
        /// </summary>

        static StackVsHeap()
        {

        }

        public static void Square(int a, int b)

        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);

        }

       
    }

    internal class Person
    {
        public int age;
    }
      
}

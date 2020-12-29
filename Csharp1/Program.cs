using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo;

namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose topic: ");
            Console.WriteLine("1.Static class");
            Console.WriteLine("2.Stack[value] vs heap[Ref]");
            Console.WriteLine("3.SOLID");


            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    StaticTest();
                    break;
                case 2:
                    ByValue();
                    ByRef();
                    break;
                case 3: SolidFunc();
                    break;
                default: break;
            }
        }

        private static void SolidFunc()
        {
            SOLID obj = new SOLID();
            obj.S();
            obj.O();
            obj.L();
            obj.I();
            obj.D();
        }

        private static void StaticTest()
        {
            StaticClass.TestDemo(1);
            StaticClass.TestDemo(2);
            StaticClass.TestDemo(3);

            StaticClass1.TestDemo1(1);
            StaticClass1.TestDemo1(2);
        }
        private static void ByValue()
        {
            int num1 = 5;

            int num2 = 10;

            Console.WriteLine(num1 + " " + num2);

            StackVsHeap.Square(num1, num2);

            Console.WriteLine(num1 + " " + num2);

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();
        }
        private static void SquareRef(Person a, Person b)

        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);

        }
        private static void ByRef()
        {
          
            Person p1 = new Person();

            Person p2 = new Person();

            p1.age = 5;

            p2.age = 10;

            Console.WriteLine(p1.age + " " + p2.age);

            SquareRef(p1, p2);

            Console.WriteLine(p1.age + " " + p2.age);

            Console.WriteLine("Press Any Key to Exit..");

            Console.ReadLine();
        }
    }
}

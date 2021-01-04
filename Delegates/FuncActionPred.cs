using System;

namespace Delegates
{
    public class FuncActionPred
    {
        public static TReturn Add<T1, T2, TReturn>(T1 x, T2 y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }
        public static void ActionAdd<T1, T2>(T1 a, T2 x)
        {
            Console.WriteLine("this is action emthod" + a + " " + x);
        }

        public static bool PredicateAdd<T1>(T1 a)
        {
            Console.WriteLine("this is Predicate emthod" + a);
            return true;
        }

        /// <summary>
        /// Func is a generic delegate included in the System namespace. 
        /// 1. It has zero or more input parameters and one out parameter. 
        /// 2. The last parameter is considered as an out parameter.
        /// </summary>
        public static void FuncDemo()
        {
            //without lambda
            Func<int, int, int> delFunc = Add<int, int, int>;
            Func<string, string, string> delFunc1 = Add<string, string, string>;

            var result = delFunc(1, 2);
            var str = delFunc1("abc", "xyz");

            //using lambda
            Func<int, int, int> Add = (x, y) => x + y;
            var res = Add(10, 20);

        }
       
        /// <summary>
        /// Action Delegate:
        ///  Action is also a delegate type defined in the System namespace.
        ///  1. An Action type delegate is the same as Func delegate except that the 
        ///     Action delegate doesn't return a value.
        ///  2. In other words, an Action delegate can be used with a method that has a 
        ///     void return type.
        /// </summary>
        public static void ActionDemo()
        {
            Action<int, string> actionFunc = ActionAdd<int, string>;
            actionFunc(1, "abc");
        }

        /// <summary>
        /// Predicate Delegate in C#:
        ///  A predicate is also a delegate like Func and Action delegates.
        ///  1. It represents a method that contains a set of criteria and checks 
        ///     whether the passed parameter meets those criteria or not.
        ///  2. A predicate delegate methods must take one input parameter 
        ///  3. and it then returns a boolean value - true or false.
        /// </summary>
        public static void PredicateDemo()
        {
            Predicate<int> prediFunc = PredicateAdd<int>;
            var isBool = prediFunc(1);
        }
    }
}

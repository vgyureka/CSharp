using System;

namespace Delegates
{
    /// <summary>
    /// Predicate Delegate in C#:
    ///  A predicate is also a delegate like Func and Action delegates.
    ///  1. It represents a method that contains a set of criteria and checks 
    ///     whether the passed parameter meets those criteria or not.
    ///  2. A predicate delegate methods must take one input parameter 
    ///  3. and it then returns a boolean value - true or false.
    /// </summary>
  
    internal class PredicateDelegate
    {
        static Predicate<string> pred = x => x == "test";
        public static void IfValid()
        {
            var result = pred("test");
            var result1 = pred("test1");
        }
    }
}

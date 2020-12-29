using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// Singleton :-
    /// 1.Creational type of design pattern
    /// 2.A Singleton design pattern says or enables a developer to 
    /// write code where only one instance of a class is created
    /// 3.Example:- [log writer class]
    /// 4.single thread-safe object is shared 
    /// 5.IF constructor is "Protected", than it is mandatory to make a sealed class
    /// -------------------------------
    /// ADVANTAGES OF SINGLETON
    /// -------------------------------
    /// 1.singleton makes sure every client accesses it with no 
    /// deadlock or conflict.
    /// 2.it only allows one instance of a class responsible for 
    /// sharing the resource, across the application.
    /// ---------------------
    /// GUIDELINES
    /// ---------------------
    ///1.ONE INSTANCE:-It should creates only one instance of the class,
    /// created at one point only
    ///2.PRIVATE CONSTRUCTOR:-The singleton's class constructors should 
    ///be private so that no class can directly instantiate the 
    ///singleton class.
    ///3.STATIC PROPERTY/METHOD:-There should be a static property/method 
    ///that takes care of singleton class instantiation and that 
    ///property should be shared across applications and is solely 
    ///responsible for returning a singleton instance.
    ///4.SEALED CLASS:-The C# singleton class should be sealed so that it 
    ///could not be inherited by any child nested class.
    ///---------------------
    ///SINGLETON VS STATIC
    ///----------------------
    ///1. Singleton can be extended :-Singleton classes support Interface inheritance whereas a static class cannot implement an 
    ///interface.
    ///2.Since singleton class supports interface implementation, we can reuse our singleton for any number of 
    ///implementations of interface confirming objects.
    ///3.In case u need to have more than 1 instance in future,in Singleton class, u cn make constructor public
    ///while is not possible with static classes
    ///4.Unlike static classes, we can use singletons as parameters to methods, or objects.


    /// </summary>

    //basic singleton
    public class SingleTonBasic
    {
        private SingleTonBasic()
        {
            Console.WriteLine("Singleton instance is created in CONSTRUCTOR.");
        }

        private static object lockingObject = new object();
        private static SingleTonBasic singleTonObject;
        public static SingleTonBasic Instance
        {
            get
            {
                lock (lockingObject)
                {
                    if (singleTonObject == null)
                    {
                        singleTonObject = new SingleTonBasic();
                        Console.WriteLine("Singleton instance is created in InstanceCreation method");
                    }
                }
                return singleTonObject;
            }
        }
        public void Logwriter()
        {
            Console.WriteLine("singleton logger");
        }
    }
    //Thread Safety Singleton using Double Check Locking : - 
    public class SingleTon
    {
        private SingleTon()
        {
            Console.WriteLine("Singleton instance is created in CONSTRUCTOR.");
        }
        private static object lockingObject = new object();
        private static SingleTon singleTonObject;
        public static SingleTon InstanceCreation()
        {
            if (singleTonObject == null)
            {
                lock (lockingObject)
                {
                    if (singleTonObject == null)
                    {
                        singleTonObject = new SingleTon();
                        Console.WriteLine("Singleton instance is created in InstanceCreation method");
                    }
                }
            }
            return singleTonObject;
        }

    }

    //Thread Safe Singleton without using locks and no lazy instantiation
    public sealed class SingletonNoLock
    {
        private static readonly SingletonNoLock instance = new SingletonNoLock();
        private static int i = 0;
        private static int j = 0;
        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static SingletonNoLock()
        {
            i++;
            Console.WriteLine($"Singleton instance is created in STATIC CONSTRUCTOR.{i}");
        }
        private SingletonNoLock()
        {
            j++;
            Console.WriteLine($"Singleton instance is created in PRIVATE CONSTRUCTOR.{j}");
        }

        public static SingletonNoLock Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SINGLETON
{
    /// <summary>
    /// 1. By default, Lazy<T> objects are thread-safe
    /// Lazy initialization is a technique that defers the creation of an object until the first time it is needed. 
    /// In other words, initialization of the object happens only on demand.
    /// Benefits:-
    /// 1. improves the performance
    /// 2 avoid unnecessary load till the point object is accessed
    /// 3. Reduces the memory footprint on the start-up
    /// 4. faster application load
    /// 
    /// Non-Lazy or eager loading
    /// 1. pre-instantiation of the object
    /// 2. commonly used in lower memory footprints
    /// </summary>
    public sealed class LazySingleton
    {
        static int instanceCounter = 0;
        private static readonly Lazy<LazySingleton> singleInstance = new Lazy<LazySingleton>(() => new LazySingleton()); //private static Singleton singleInstance = null;
        private LazySingleton()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }

        public static LazySingleton SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }
        public  void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}

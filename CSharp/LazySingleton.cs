using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
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
        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}

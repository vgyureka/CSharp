using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SingleTonSample
    {
       // private static Lazy<SingleTonSample> singleTonObject = null;
        private SingleTonSample()
        {
            Console.WriteLine("Singleton instance is created.");

        }
        private static object lockingObject = new object();
        private static SingleTonSample singleTonObject;
        public static SingleTonSample InstanceCreation()
        {
            //singleTonObject = new Lazy<SingleTonSample>(() => new SingleTonSample()
            //     );

            //return singleTonObject.Value;

            if (singleTonObject == null)
            {
                lock (lockingObject)
                {
                    if (singleTonObject == null)
                    {
                        singleTonObject = new SingleTonSample();
                      //  Console.WriteLine("Singleton instance is created.");
                    }
                }
            }
            return singleTonObject;
        }




    }
}

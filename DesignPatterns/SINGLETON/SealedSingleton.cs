using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SINGLETON
{
    public class SealedSingleton
    {
        private static SealedSingleton instance = null;
        private static int counter = 0;
        private SealedSingleton()
        {
            counter++;
            Console.WriteLine($"counter : {counter}");
            Console.ReadLine();
        }
        public static SealedSingleton Instace
        {
            get
            {
                if(instance==null)
                {
                    instance = new SealedSingleton();
                }
                return instance;
            }
        }
        public void Print(string msg)
        {
            Console.WriteLine($"print : {msg}");
            Console.ReadLine();
        }
        public class Child : SealedSingleton
        {
            public Child()
            {
            }
            public void childPrint(string msg)
            {
                Console.WriteLine($"Child print : {msg}");
                Console.ReadLine();
            }
        }
    }
}

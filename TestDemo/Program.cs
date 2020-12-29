
using ConsoleApplication1;
using System;
using TestDemo;
using TestDemo.ADAPTER;
using TestDemo.FACTORY;
using TestDemo.OBSERVER;
using TestDemo.SINGLETON;
using static TestDemo.SINGLETON.SealedSingleton;

namespace DesignPatterns
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose topic: ");
            Console.WriteLine("1. Basic Singleton");
            Console.WriteLine("2. Thread safe Singleton");
            Console.WriteLine("3. Lazy Singleton");
            Console.WriteLine("4. Factory Pattern");
            Console.WriteLine("5. Adapter Pattern");
            Console.WriteLine("6. Observer Pattern");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Basic Singleton");
                    BasicSingleton();
                    // why use sealed in singleton class
                    SealedInSingleton();
                    break;

                case 2:
                    Console.WriteLine("Thread safe Singleton");
                    ThreadSafeSingleton();
                    break;

                case 3:
                    Console.WriteLine("Lazy Singleton");
                    LazySingletonDemo();
                    break;
                case 4:
                    Console.WriteLine("Factory Pattern");
                    FactoryPattern();
                    break;
                case 5:
                    Console.WriteLine("Adapter Pattern");
                    AdapterPattern();
                    break;
                case 6:
                    Console.WriteLine("Observer Pattern");
                    ObserverPattern();
                    break;

                default: break;
            }

        }

        private static void SealedInSingleton()
        {
            SealedSingleton obj = SealedSingleton.Instace;
            obj.Print("call 1");
            SealedSingleton obj1 = SealedSingleton.Instace;
            obj1.Print("call 2");

            Child childObj = new Child();
            childObj.childPrint("child call");
        }

        private static void ObserverPattern()
        {
            ServiceSubject serviceSubject = new ServiceSubject();
            // Add stocks
            serviceSubject.Register(new ConcreteObserver("IBM"));
            serviceSubject.Register(new ConcreteObserver("Google"));
            serviceSubject.Register(new ConcreteObserver("Reliance"));
            //Stock prices update
            serviceSubject.price = 100;
            serviceSubject.price = 200;
        }

        private static void AdapterPattern()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }

        private static void FactoryPattern()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();
        }

        private static void BasicSingleton()
        {

            SingleTonBasic obj = SingleTonBasic.Instance;
            obj.Logwriter();
            SingleTonBasic obj1 = SingleTonBasic.Instance;
            obj1.Logwriter();
        }

        private static void ThreadSafeSingleton()
        {
            SingleTon.InstanceCreation();
            SingleTon.InstanceCreation();
            Console.ReadLine();

            var obj = SingletonNoLock.Instance;
            var obj1 = SingletonNoLock.Instance;
            var obj2 = SingletonNoLock.Instance;
            Console.ReadLine();
        }
        private static void LazySingletonDemo()
        {
            LazySingleton obj = LazySingleton.SingleInstance;
            LazySingleton obj1 = LazySingleton.SingleInstance;

            obj.LogMessage("defect1");
            obj1.LogMessage("defect2");
            Console.ReadLine();
        }

    }

}

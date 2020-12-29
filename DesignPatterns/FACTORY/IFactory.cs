using System;

namespace DesignPatterns.FACTORY
{
    /// <summary>
    /// The Factory Method pattern is a design pattern used to define a runtime interface for creating an object. 
    /// It's called a factory because it creates various types of objects without necessarily knowing what kind of object it 
    /// creates or how to create it. ... A class requires its subclasses to specify the objects it creates.
    /// 
    /// The 'Product' interface
    ///1. The Factory method is a creational design pattern which provides an interface for creating objects without
    ///   specifying their concrete classes. 
    ///2. It defines a method which we can use to create an object instead of using its constructor.
    ///3. The important thing is that the subclasses can override this method and create objects of different types.
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}

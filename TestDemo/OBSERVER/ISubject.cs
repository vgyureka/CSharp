using System;
using System.Collections.Generic;

namespace TestDemo.OBSERVER
{
    internal interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }

    internal interface IObserver
    {
        void Update(double price);
    }

    internal class ServiceSubject : ISubject
    {
        private double _price;

        private List<IObserver> listObservers = new List<IObserver>();
        public double price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
        public void Notify()
        {
            listObservers.ForEach(x => x.Update(price));
        }

        public void Register(IObserver observer)
        {
            listObservers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            listObservers.Remove(observer);
        }
    }

    internal class ConcreteObserver : IObserver
    {
        private string _name;
        public ConcreteObserver(string name)
        {
            this._name = name;
        }
        public void Update(double price)
        {
            Console.WriteLine($"Notified: updated price of stock {_name} is {price}");
            Console.ReadLine();
        }
    }
}

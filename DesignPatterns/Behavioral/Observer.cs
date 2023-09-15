using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DesignPatterns.Behavioral
{
    internal class Observer
    {
    }

    public interface IObserver
    {
        public void Update(string symbol, decimal price);
    }
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers();
    }

    public class Stock : ISubject
    {
        public string Symbol { get; set; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }

            }
        }
        public Stock(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
        }

        private readonly List<IObserver> _observers = new();
        public void NotifyObservers() => _observers.ForEach(observer => observer.Update(Symbol, Price));
        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void Unsubscribe(IObserver observer) => _observers.Remove(observer);
    }
    public class Display : IObserver
    {
        private readonly ISubject _subject;
        public Display(ISubject subject)
        {
            _subject = subject;
            _subject.Subscribe(this);
        }
        public void Update(string symbol, decimal price)
        {
            Console.WriteLine($"{symbol}: {price}");
        }
    }
    public class Logger : IObserver
    {
        private readonly ISubject _subject;
        private readonly string _filename;

        public Logger(ISubject subject, string filename)
        {
            _subject = subject;
            _subject.Subscribe(this);

            _filename = filename;
        }

        public void Update(string symbol, decimal price)
        {
            using var streamWriter = File.AppendText(_filename);
            streamWriter.WriteLine($"{symbol}:{price}");
        }
    }
}

using System.Collections.Generic;

namespace Observer
{
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public string Message { get; }

        public ConcreteSubject(string message)
        {
            Message = message;
        }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver item in _observers)
            {
                item.Update();
            }
        }
    }
}

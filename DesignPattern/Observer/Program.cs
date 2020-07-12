using System;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISubject subject = new ConcreteSubject("Test");

            ObserverA observerA = new ObserverA(subject);

            ObserverA observerB = new ObserverA(subject);

            subject.Add(observerA);

            subject.Add(observerB);

            subject.Notify();

            Console.Read();
        }
    }
}

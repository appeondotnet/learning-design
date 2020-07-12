using System;

namespace Observer
{
    public class ObserverA : IObserver
    {
        private readonly ISubject _subject;

        public ObserverA(ISubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Observer A Received Message: {_subject.Message}.");
        }
    }
}

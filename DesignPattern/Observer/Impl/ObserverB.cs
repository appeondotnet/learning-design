using System;

namespace Observer
{
    public class ObserverB : IObserver
    {
        private readonly ISubject _subject;

        public ObserverB(ISubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Observer B Received Message: {_subject.Message}.");
        }
    }
}

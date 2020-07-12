namespace Observer
{
    public interface ISubject
    {
        string Message { get; }

        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }
}

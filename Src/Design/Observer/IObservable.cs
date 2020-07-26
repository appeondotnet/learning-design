using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObservable
    {
        void AddOberver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void SetChanged();

        void NotifyObservers();
    }
}

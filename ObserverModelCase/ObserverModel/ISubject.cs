using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverModel
{
    public interface ISubject
    {
        void RegisterObserver(IOberver oberver);

        void RemoveObserver(IOberver oberver);

        void NotifyObserver();
    }
}

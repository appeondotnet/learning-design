using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverModel
{
    public interface IOberver
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}

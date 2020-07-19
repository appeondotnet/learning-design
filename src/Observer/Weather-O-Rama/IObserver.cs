using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}

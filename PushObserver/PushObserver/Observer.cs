using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushObserver
{
    interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }
}

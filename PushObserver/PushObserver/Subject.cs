using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushObserver
{
    interface Subject
    {
        void RegisterObservers(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}

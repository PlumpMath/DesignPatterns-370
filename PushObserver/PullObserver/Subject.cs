using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullObserver
{
    abstract class Subject
    {
        private ArrayList observers;
        private bool Changed = false;
        public void RegisterObservers(Observer o)
        {
            observers.Add(o);
        }

        public Subject()
        {
            observers = new ArrayList();
        }
        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void SetChange()
        {
            Changed = true;
        }

        public void NotifyObservers(Object arg)
        {
           if (Changed == true)
           {
               for (int i = 0; i < observers.Count; i++)
               {
                   Observer observer = (Observer)observers[i];
                   observer.Update(this, arg);
               }
           }
           Changed = false;
        }

        public void NotifyObservers()
        {
            NotifyObservers(null);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushObserver
{
    class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void RegisterObservers(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}

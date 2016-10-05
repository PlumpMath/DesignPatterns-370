using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullObserver
{
    class WeatherData : Subject
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public void MeasurementsChanged()
        {
            SetChange();
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }
}

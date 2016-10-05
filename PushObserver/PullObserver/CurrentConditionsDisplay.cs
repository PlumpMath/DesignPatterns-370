using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullObserver
{
    class CurrentConditionsDisplay : Observer, DiaplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObservers(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature +
                "F degrees and " + humidity + "% humidity");
        }

        public void Update(Subject subject, Object arg)
        {
            if (subject is WeatherData)
            {
                WeatherData weatherData = (WeatherData)subject;
                this.temperature = weatherData.Temperature;
                this.humidity = weatherData.Humidity;
                Display();
            }
        }
    }
}

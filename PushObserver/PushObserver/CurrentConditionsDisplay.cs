using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushObserver
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

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}

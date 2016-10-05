using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushObserver
{
    class StatisticsDisplay : Observer, DiaplayElement
    {
        private Subject weatherData;
        private float totalTemperature;
        private float maxTemperature;
        private float minTemperature;
        private float averageTemperature;
        private int temperatureCount;
        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObservers(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureCount++;
            averageTemperature = GetAverage(temperature);
            minTemperature = GetMin(temperature);
            maxTemperature = GetMax(temperature);
            Display();
        }

        private float GetAverage(float temperature)
        {
            totalTemperature += temperature;
            return totalTemperature / temperatureCount;
        }

        private float GetMax(float temperature)
        {
            return maxTemperature > temperature ? maxTemperature : temperature;
        }

        private float GetMin(float temperature)
        {
            if (temperatureCount == 1)
                return temperature;

            return minTemperature < temperature ? minTemperature : temperature;
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature: " + averageTemperature +
                "/" + maxTemperature + "/" + minTemperature);
        }
    }
}

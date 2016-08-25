using System;
using ObserverPatternWithBuiltInObservables.Interfaces;

namespace ObserverPatternWithBuiltInObservables.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current condintions: {_temperature} C degrees and {_humidity} % humidity");
        }
    }
}
using ObserverPatternWithBuiltInObservables.Interfaces;
using System;

namespace ObserverPatternWithBuiltInObservables.Displays
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplay
    {
        public void OnNext(WeatherInfo value)
        {
            Display(value);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Something went wrong!");
        }

        public void OnCompleted()
        {
            Console.WriteLine("Weather broadcasting completed!");
        }

        public void Display(WeatherInfo wi)
        {
            Console.WriteLine($"Current condintions: {wi.Temperature} C degrees and {wi.Humidity} % humidity");
        }
    }
}
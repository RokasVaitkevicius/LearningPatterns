using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> Observers { get; set; }
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObsever(IObserver o)
        {
            Observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurmentsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurments(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurmentsChanged();
        }
    }
}
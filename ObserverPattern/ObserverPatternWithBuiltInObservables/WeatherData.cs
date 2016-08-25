//using ObserverPatternWithBuiltInObservables.Interfaces;
//using System;
//using System.Collections.Generic;

//namespace ObserverPatternWithBuiltInObservables
//{
//    public class WeatherData : IObservable<WeatherInfo>
//    {


//        public WeatherData()
//        {
//            Observers = new List<IObserver>();
//        }

//        public void RegisterObserver(IObserver o)
//        {
//            Observers.Add(o);
//        }

//        public void RemoveObsever(IObserver o)
//        {
//            Observers.Remove(o);
//        }

//        public void NotifyObserver()
//        {
//            foreach (var observer in Observers)
//            {
//                observer.Update(Temperature, Humidity, Pressure);
//            }
//        }

//        public void MeasurmentsChanged()
//        {
//            NotifyObserver();
//        }

//        public void SetMeasurments(float temperature, float humidity, float pressure)
//        {
//            Temperature = temperature;
//            Humidity = humidity;
//            Pressure = pressure;
//            MeasurmentsChanged();
//        }

//        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
using System;
using System.Collections.Generic;

namespace ObserverPatternWithBuiltInObservables
{
    public class WeatherData : IObservable<WeatherInfo>
    {
        List<IObserver<WeatherInfo>> Observers = new List<IObserver<WeatherInfo>>();

        private WeatherInfo _weatherInfo;

        public WeatherInfo WeatherInfo
        {
            get
            {
                return _weatherInfo;
            }
            set
            {
                _weatherInfo = value;
                Notify(WeatherInfo);
            }
        }

        private void Notify(WeatherInfo wInfo)
        {
            foreach (var observer in Observers)
            {
                observer.OnNext(wInfo);
            }
        }

        private void Stop()
        {
            foreach (var observer in Observers.ToArray())
            {
                if (Observers.Contains(observer))
                    observer.OnCompleted();
                Observers.Clear();
            }
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber(Observers, observer);
        }


        public virtual void Unsubscribe(IObserver<WeatherInfo> observer)
        {
            var unsubscriber = new Unsubscriber(Observers, observer);
            unsubscriber.Dispose();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherInfo>> _observers;
            private IObserver<WeatherInfo> _observerer;

            public Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observerer)
            {
                _observers = observers;
                _observerer = observerer;
            }

            public void Dispose()
            {
                if (_observerer != null && _observers.Contains(_observerer))
                    _observers.Remove(_observerer);
            }
        }
    }
}
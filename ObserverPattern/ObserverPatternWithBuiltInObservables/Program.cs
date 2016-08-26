using ObserverPatternWithBuiltInObservables.Displays;
using System.Threading;

namespace ObserverPatternWithBuiltInObservables
{
    class Program
    {
        /// <summary>
        /// The Observer Pattern defines a one-to-many dependency between objects so that
        /// when one object changes state, all of its dependents are notified and updated
        /// automatically. Object which changes state is called - subject. Object which 
        /// subscribes to subject is called - observer.
        /// 
        /// This project uses built in observer pattern.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var wd = new WeatherData();

            var disp = new CurrentConditionsDisplay();

            using (wd.Subscribe(disp))
            {
                var wi = new WeatherInfo
                {
                    Humidity = 80,
                    Pressure = 65,
                    Temperature = 30.4f
                };
                wd.WeatherInfo = wi;
                Thread.Sleep(2000);
                wi = new WeatherInfo
                {
                    Humidity = 85,
                    Pressure = 65,
                    Temperature = 31.4f
                };
                wd.WeatherInfo = wi;
                wd.Unsubscribe(disp);
                Thread.Sleep(2000);
                wi = new WeatherInfo
                {
                    Humidity = 60,
                    Pressure = 65,
                    Temperature = 29.4f
                };
                wd.WeatherInfo = wi;
            }
        }
    }


}

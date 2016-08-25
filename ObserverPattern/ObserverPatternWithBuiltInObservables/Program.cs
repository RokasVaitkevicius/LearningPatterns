//using ObserverPatternWithBuiltInObservables.Displays;
//using System.Threading;

//namespace ObserverPatternWithBuiltInObservables
//{
//    class Program
//    {
//        /// <summary>
//        /// The Observer Pattern defines a one-to-many dependency between objects so that
//        /// when one object changes state, all of its dependents are notified and updated
//        /// automatically. Object which changes state is called - subject. Object which 
//        /// subscribes to subject is called - observer.
//        /// 
//        /// This project uses built in observer pattern.
//        /// </summary>
//        /// <param name="args"></param>
//        static void Main(string[] args)
//        {
//            var weatherData = new WeatherData();
//            var currentDisplay = new CurrentConditionsDisplay();

//            weatherData.SetMeasurments(80, 65, 30.4f);
//            Thread.Sleep(2000);
//            weatherData.SetMeasurments(82, 10, 29.4f);
//            Thread.Sleep(2000);
//            weatherData.SetMeasurments(78, 90, 29.2f);

//        }
//    }


//}

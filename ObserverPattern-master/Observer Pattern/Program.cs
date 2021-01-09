using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Program
    {
        /// <summary>
        /// The Observer pattern seeks to allow objects to notify their observers when their internal state changes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating a concert observable
            WeatherStation weatherStation = new WeatherStation(24);

            // creating a concert observer and we are passing an observable using dependency injection
            IObserver smartPhone = new SmartPhone(weatherStation);
            IObserver smartPhone1 = new SmartPhone(weatherStation);
            IObserver smartPhone2 = new SmartPhone(weatherStation);
            IObserver smartPhone3 = new SmartPhone(weatherStation);
            IObserver smartPhone4 = new SmartPhone(weatherStation);
            IObserver smartPhone5 = new SmartPhone(weatherStation);

            // adding a new observer to our observable
            weatherStation.Add(smartPhone);
            weatherStation.Add(smartPhone1);
            weatherStation.Add(smartPhone2);
            weatherStation.Add(smartPhone3);
            weatherStation.Add(smartPhone4);
            weatherStation.Add(smartPhone5);

            // the state of this observable have changed! now all our observers can pull the new state
            weatherStation.SetTemperaturt(33);

            weatherStation.SetTemperaturt(38);

            Console.ReadKey();


        }
    }
}

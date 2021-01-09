using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    // <summary>
    /// The ConcreteObserver class
    /// </summary>
    class SmartPhone : IObserver, iDisplay
    {
        // the observable
        private WeatherStation _weatherStation;
        public SmartPhone(WeatherStation WeatherStation)
        {
            _weatherStation = WeatherStation;
        }

        // pulling the state from this observable 
        public void display()
        {
           
            _weatherStation.GetTemperaturt();
        }

        // this state have changed
        public void Update()
        {
            Console.WriteLine("the WeatherStation has changed");
            // lets pull the new state
            display();
        }
    }
}

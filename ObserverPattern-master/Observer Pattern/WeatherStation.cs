using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    /// <summary>
    /// The ConcreteSubject class
    /// </summary>
    public class WeatherStation : IObservable
    {
        // our state
        private int _temperature;

        // list of observers that are Waiting for this state to change
        private static List<IObserver> _observers = new List<IObserver>();
        public WeatherStation(int Temperaturt)
        {
            _temperature = Temperaturt;
        }

        // add an observers
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        // calling all the observers and letting them know that the state have changed and the can pull now
        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update();
            }
        }

        // remove an observer
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // changing this state
        public void SetTemperaturt(int Temperaturt)
        {

            _temperature = Temperaturt;
            // calling all observers
            Notify();
        }

        // returns the state
        public void GetTemperaturt()
        {

            Console.WriteLine(this._temperature);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{

    /// <summary>
    /// The Context class
    /// </summary>
    class Steak
    {
        private Doneness _state;
        private string _beefCut;

        public Steak(string beefCut)
        {
            _beefCut = beefCut;
            _state = new Rare(0.0, this);
        }

        public double CurrentTemp
        {
            get { return _state.CurrentTemp; }
        }

        public Doneness State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void AddTemp(double amount)
        {
            // using the state func to change CurrentTemp then it will check if the state have changed
            _state.AddTemp(amount);
            Console.WriteLine($"Decreased temperature by {amount} degrees.");
            Console.WriteLine($"Current temp is {CurrentTemp}");
            Console.WriteLine($"Status is {State.GetType().Name}");
            Console.WriteLine("");
        }

        public void RemoveTemp(double amount)
        {
            // using the state func to change CurrentTemp then it will check if the state have changed
            _state.RemoveTemp(amount);
            Console.WriteLine($"Decreased temperature by {amount} degrees.");
            Console.WriteLine($"Current temp is {CurrentTemp}");
            Console.WriteLine($"Status is {State.GetType().Name}");
            Console.WriteLine("");
        }
    }
}

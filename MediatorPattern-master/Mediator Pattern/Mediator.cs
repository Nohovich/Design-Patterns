using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// The Mediator interface, which defines a send message method which the concrete mediators must implement.
    /// </summary>
    interface Mediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }

    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    class ConcessionsMediator : Mediator
    {
        // our roles
        private NorthConcessionStand _northConcessions;
        private SouthConcessionStand _southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { _northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { _southConcessions = value; }
        }

        /// <summary>
        /// gets a message and broadcast it to everyone that signed up
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        public void SendMessage(string message, ConcessionStand concessionStand)
        {
            if (concessionStand == _northConcessions)
            {
                // calling the ConcessionStand to pull the info
                _southConcessions.Notify(message);
            }
            else
            {
                // calling the ConcessionStand to pull the info
                _northConcessions.Notify(message);
            }
        }
    }

    /// <summary>
    /// The Colleague abstract class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    abstract class ConcessionStand
    {
        protected Mediator mediator;

        public ConcessionStand(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class NorthConcessionStand : ConcessionStand
    {
        // Constructor
        public NorthConcessionStand(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// sending a message through the mediator and passing it this NorthConcessionStand,
        /// so it will know who needs to get the message and who needs to get it 
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        /// <summary>
        /// this method is been used from the mediator when called it will pull the info
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// sending a message through the mediator and passing it this SouthConcessionStand,
        /// so it will know who needs to get the message and who needs to get it 
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        /// <summary>
        /// this method is been used from the mediator when called it will pull the info
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /// <summary>
    /// The Invoker demands the command carry out its request.
    /// </summary>
    class RemoteInvoker
    {
        // the concert command
        private Icommand _turnOnCommand;

        public Icommand TurnOnCommand
        {
            get { return _turnOnCommand; }
            set { TurnOnCommand = value; }
        }

        // the concert command
        private Icommand _turnOffCommand;

        public Icommand TurnOffCommand
        {
            get { return _turnOffCommand; }
            set { TurnOffCommand = value; }
        }
        /// <summary>
        /// the constructor we are passing our commands using dependency injection
        /// </summary>
        /// <param name="turnOffCommand"></param>
        /// <param name="turnOnCommand"></param>
        public RemoteInvoker(TurnOffCommand turnOffCommand, TurnOnCommand turnOnCommand)
        {
            this._turnOffCommand = turnOffCommand;
            this._turnOnCommand = turnOnCommand;
        }
       
    }
}

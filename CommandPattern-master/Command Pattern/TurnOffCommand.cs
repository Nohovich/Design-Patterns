using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /// <summary>
    /// The ConcreteCommand defines a binding between a Receiver and an action.
    /// </summary>
    class TurnOffCommand : Icommand
    {
        // the receiver
        private Lemp _lemp;
        public TurnOffCommand(Lemp lemp)
        {
            this._lemp = lemp;
        }

        /// <summary>
        /// after getting execute command from the invoker,
        /// this concreteCommand delegates to the receiver and tells it to do the action
        /// </summary>
        public void Execute()
        {
            this._lemp.Off();
        }

        public void UnExecute()
        {
            this._lemp.On();
        }
    }
}

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
    class TurnOnCommand : Icommand
    {
        private Lemp _lemp;
        public TurnOnCommand(Lemp lemp)
        {
            this._lemp = lemp;
        }

        /// <summary>
        /// after getting execute command from the invoker,
        /// this concreteCommand delegates to the receiver and tells it to do the action
        /// </summary>
        public void Execute()
        {
            this._lemp.On();
        }

        public void UnExecute()
        {
            this._lemp.Off();
        }
    }
}

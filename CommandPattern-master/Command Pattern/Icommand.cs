using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /// <summary>
    /// The Command interface declares a method for executing a command.
    /// </summary>
    interface Icommand
    {
        void Execute();
        void UnExecute();
    }
}

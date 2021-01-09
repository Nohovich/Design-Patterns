using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        /// <summary>
        /// The Command design pattern encapsulates a request as an object,
        /// thereby allowing us developers to treat that request differently based upon what class receives said command.
        /// Further, it enables much more complex architectures,
        /// and even enables operations such as undo/redo.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating a new receiver
            Lemp lemp = new Lemp();
            // creating a new command and passing it the receiver
            TurnOffCommand turnOffCommand = new TurnOffCommand(lemp);
            TurnOnCommand turnOnCommand = new TurnOnCommand(lemp);
            // creating a new invoker and passing it the commands
            RemoteInvoker remoteInvoker = new RemoteInvoker(turnOffCommand, turnOnCommand);
            // executing the command
            remoteInvoker.TurnOffCommand.Execute();
            Console.ReadKey();

        }
    }
}
